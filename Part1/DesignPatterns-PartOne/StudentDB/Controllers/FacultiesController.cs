using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentDB.Data;
using StudentDB.Models;
using StudentDB.Repository.Abstract;
using StudentDB.UnitOfWork.Abstract;

namespace StudentDB.Controllers
{
    public class FacultiesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Faculty> _repository;

        public FacultiesController(IRepository<Faculty> repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }

        // GET: Faculties
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetAll());
        }

        // GET: Faculties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faculty = await _repository.Get(f => f.Id == id);
            if (faculty == null)
            {
                return NotFound();
            }

            return View(faculty);
        }

        // GET: Faculties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Faculties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                await _repository.Add(faculty);
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faculty);
        }

        // GET: Faculties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentList = await _repository.Get(s => s.Id == id);
            var student = studentList.First();
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Faculties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Faculty faculty)
        {
            if (id != faculty.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repository.Update(faculty);
                    await _unitOfWork.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await FacultyExists(faculty.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(faculty);
        }

        // GET: Faculties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faculty = await _repository.Get(f => f.Id == id);

            var f = faculty.FirstOrDefault();
            if (f == null)
            {
                return NotFound();
            }

            return View(f);
        }

        // POST: Faculties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faculty = await _repository.GetById(id);
            _repository.Delete(faculty);
            await _unitOfWork.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> FacultyExists(int id)
        {
            var result = await _repository.GetById(id);

            if (result != null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

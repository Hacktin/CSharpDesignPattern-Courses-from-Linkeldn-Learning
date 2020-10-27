using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentDB.Models;

namespace StudentDB.Data
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext (DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Faculty> Faculties { get; set; }
    }
}

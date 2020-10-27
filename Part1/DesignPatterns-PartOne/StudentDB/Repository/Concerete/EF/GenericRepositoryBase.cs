using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentDB.Repository.Abstract;

namespace StudentDB.Repository.Concerete.EF
{
    public class GenericRepositoryBase<TEntity, TContext> : IRepository<TEntity>
    where TEntity : class
    where TContext : DbContext, new()
    {
        internal TContext _context;
        internal DbSet<TEntity> _dbSet;

        public GenericRepositoryBase(TContext context)
        {
            this._context = context;
            this._dbSet = _context.Set<TEntity>();
        }

        public async Task Add(TEntity entity)
        {
           await _dbSet.AddAsync(entity);
        }

        public virtual void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbSet.Where(filter).ToListAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public  virtual void Update(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}

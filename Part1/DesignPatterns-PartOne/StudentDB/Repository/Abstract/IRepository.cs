using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StudentDB.Repository.Abstract
{
    public interface IRepository<T> where T:class
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> filter);

        Task Add(T entity);

        void Delete(int id);
        void Delete(T entity);
        
        void Update(T entity);
        void Update(int id);
    }
}

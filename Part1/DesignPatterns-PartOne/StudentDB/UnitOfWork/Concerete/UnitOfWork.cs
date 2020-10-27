using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentDB.UnitOfWork.Abstract;

namespace StudentDB.UnitOfWork.Concerete
{
    public class UnitOfWork<TContext> : IUnitOfWork
    where TContext:DbContext,new()
    {

        TContext context=new TContext();
        private bool disposed = false;
        public void Dispose()
        {
           Dispose(true);
           GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            disposing = true;
        }



        public void Save()
        {
            context.SaveChanges();
        }

        public async Task SaveAsync()
        {
             await context.SaveChangesAsync();
        }
    }
}

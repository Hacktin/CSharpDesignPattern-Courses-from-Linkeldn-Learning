using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentDB.Repository.Concerete.EF;

namespace StudentDB.UnitOfWork.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        void Save();

        Task SaveAsync();
    }
}

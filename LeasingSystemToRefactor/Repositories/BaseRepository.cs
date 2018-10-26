using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Repositories
{
    public abstract class BaseRepository<T> 
    {
        public abstract void Add(T item);
        public abstract void Delete(int id);
        public abstract List<T> GetAll();
        public abstract T GetById(int id);

    }
}

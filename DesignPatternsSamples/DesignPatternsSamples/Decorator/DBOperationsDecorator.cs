using DesignPatternsSamples.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Decorator
{
    public abstract class DBOperationsDecorator : IDBOperations
    {
        IDBOperations dBOperations;
        public DBOperationsDecorator(IDBOperations dBOperations)
        {
            this.dBOperations = dBOperations;
        }
        public virtual List<User> GetAll()
        {
            return dBOperations.GetAll();
        }

        public virtual User GetById(int id)
        {
            return dBOperations.GetById(id);
        }

        public virtual void Insert(User newRecord)
        {
            dBOperations.Insert(newRecord);
        }
    }
}

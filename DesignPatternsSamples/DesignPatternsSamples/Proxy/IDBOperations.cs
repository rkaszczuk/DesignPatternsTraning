using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Proxy
{
    public interface IDBOperations
    {
        List<User> GetAll();
        User GetById(int id);
        void Insert(User newRecord);
    }
}

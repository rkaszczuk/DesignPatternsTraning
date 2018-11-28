using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Text;

namespace DesignPatternsSamples.Proxy
{
    public class UserDBOperationsProxy : IDBOperations
    {
        private IDBOperations dBOperations;
        private MemoryCache memoryCache = new MemoryCache("DB_CACHE");
        private CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
        private IDBOperations GetDBOperations()
        {
            if (dBOperations == null)
            {
                dBOperations = new UserDBOperations();
            }
            return dBOperations;
        }
        public List<User> GetAll()
        {
            var result = memoryCache.AddOrGetExisting("GET_ALL", dBOperations.GetAll(), cacheItemPolicy);
            return (List<User>)result;
        }

        public User GetById(int id)
        {
            if (id < 0)
            {
                throw new Exception();
            }
            var result = memoryCache.AddOrGetExisting("GET_BY_ID", dBOperations.GetById(id), cacheItemPolicy);
            return (User)result;

        }

        public void Insert(User newRecord)
        {
            if (newRecord == null)
            {
                throw new Exception();
            }
            dBOperations.Insert(newRecord);
        }
    }
}

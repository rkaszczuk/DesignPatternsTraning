using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatternsSamples.Proxy
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
    internal class UserDBOperations : IDBOperations
    {
        public static List<User> users = new List<User>()
        {
            new User(){Id = 1, Username = "Admin", Password="Admin1"}
        };

        public void Insert(User newRecord)
        {
            users.Add(newRecord);
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            return users.FirstOrDefault(x => x.Id == id);
        }
    }
}

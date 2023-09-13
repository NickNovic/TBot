using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code.Models;

namespace Code.Repositories
{
    public class UserRepository : IUserRepository
    {
        UsersDbContext DataBase;// { get; set; } 
        public UserRepository()
        {
            DataBase = new UsersDbContext();
        }
        public void Add(User user)
        {
            DataBase.UsersDb.Add(user);
            DataBase.SaveChanges();
        }
        public void Update(User user)
        {
            DataBase.UsersDb.Update(user);
        }
        public void Delete(User user)
        {
            //DataBase.UsersDb.Delete(user);
        }
    }
}
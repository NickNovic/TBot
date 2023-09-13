using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code.Models;

namespace Code.Repositories
{
    interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
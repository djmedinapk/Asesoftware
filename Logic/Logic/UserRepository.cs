using Core.DataTest;
using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserRepository : IUserRepository
    {
        public User getUserById(int id)
        {
            return DbUsers.Find(id);
        }

        public IReadOnlyList<User> getUsers()
        {
            return DbUsers.ToList();
        }
    }
}

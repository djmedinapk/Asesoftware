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
        public Task<User> getUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<User>> getUsersAsync()
        {
            throw new NotImplementedException();
        }
    }
}

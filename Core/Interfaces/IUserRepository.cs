using Core.Entities;
using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IUserRepository
    {
        User getUserById(int id);
        IReadOnlyList<User> getUsers();
    }
}

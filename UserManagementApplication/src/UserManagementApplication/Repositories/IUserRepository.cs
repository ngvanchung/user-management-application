using System.Collections.Generic;
using UserManagementApplication.DomainModels;

namespace UserManagementApplication.Repositories
{
    public interface IUserRepository
    {
        IList<User> GetUsers();
        User GetUserById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
    }
}

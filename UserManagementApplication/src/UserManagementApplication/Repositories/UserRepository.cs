using System.Linq;
using System.Collections.Generic;
using UserManagementApplication.Data;
using UserManagementApplication.DomainModels;

namespace UserManagementApplication.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IList<User> GetUsers()
        {
            return DataContext.GetUsers();
        }

        public User GetUserById(int id)
        {
            return DataContext.GetUserById(id);
        }

        public void CreateUser(User user)
        {
            var maxId = DataContext.GetUsers().Max(u => u.Id);
            user.Id = maxId + 1;

            DataContext.Insert(user);
        }

        public void UpdateUser(User user)
        {
            DataContext.Update(user);
        }
    }
}

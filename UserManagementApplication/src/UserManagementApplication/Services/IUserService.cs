using System.Collections.Generic;
using UserManagementApplication.ViewModels;

namespace UserManagementApplication.Services
{
    public interface IUserService
    {
        IList<UserViewModel> GetUsers();
        UserViewModel GetUserById(int id);
        void CreateUser(UserViewModel userViewModel);
        void UpdateUser(int id, UserViewModel userViewModel);
    }
}

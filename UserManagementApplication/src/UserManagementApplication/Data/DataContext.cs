using System.Collections.Generic;
using System.Linq;
using UserManagementApplication.DomainModels;

namespace UserManagementApplication.Data
{
    public static class DataContext
    {
        private static List<User> Users;

        static DataContext()
        {
            Users = new List<User>
            {
                new User{ Id = 100, Name = "Nguyen Van Giau", Age = 18, Address ="Nguyen Van Troi" },
                new User{ Id = 101, Name = "Le Thi Tham", Age = 20, Address ="Nam Ky Khoi Nghia" },
                new User{ Id = 102, Name = "Dao Van Hai", Age = 22, Address ="Hoang Van Thu" },
            };
        }

        public static IList<User> GetUsers()
        {
            return Users;
        }

        public static User GetUserById(int id)
        {
            return Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public static void Insert(User user)
        {
            Users.Add(user);
        }

        public static void Update(User user)
        {
            var updatedUser = Users.Where(u => u.Id == user.Id).First();
            updatedUser.Name = user.Name;
            updatedUser.Age = user.Age;
            updatedUser.Address = user.Address;
        }
    }
}

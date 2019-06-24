using System;
using System.Collections.Generic;
using System.Net;
using UserManagementApplication.ViewModels;
using UserManagementApplication.Exceptions;
using UserManagementApplication.Repositories;
using AutoMapper;
using UserManagementApplication.DomainModels;

namespace UserManagementApplication.Services
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;

            this.mapper = mapper;
        }

        public IList<UserViewModel> GetUsers()
        {
            var users = userRepository.GetUsers();

            return mapper.Map<List<UserViewModel>>(users);
        }

        public UserViewModel GetUserById(int id)
        {
            var user = userRepository.GetUserById(id);

            return mapper.Map<UserViewModel>(user);
        }

        public void CreateUser(UserViewModel userViewModel)
        {
            userRepository.CreateUser(mapper.Map<User>(userViewModel));
        }

        public void UpdateUser(int id, UserViewModel userViewModel)
        {
            var user  = userRepository.GetUserById(id);

            if (user == null)
            {
                throw new UserManagementException(HttpStatusCode.NotFound, "User does not exist in system");
            }

            userViewModel.Id = id;

            userRepository.UpdateUser(mapper.Map<User>(userViewModel));
        }
    }
}

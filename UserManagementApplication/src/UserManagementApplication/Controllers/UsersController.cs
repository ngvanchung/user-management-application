using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UserManagementApplication.ViewModels;
using UserManagementApplication.Services;

namespace UserManagementApplication.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService service;

        public UsersController(IUserService userService)
        {
            service = userService;
        }

        [HttpGet]
        public IList<UserViewModel> GetUsers()
        {
            return service.GetUsers();
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public UserViewModel GetUserById([FromRoute]int id)
        {
            return service.GetUserById(id);
        }

        [HttpPost]
        public void CreateUser([FromBody]UserViewModel userViewModel)
        {
            service.CreateUser(userViewModel);
        }

        [HttpPut("{id}")]
        public void UpdateUser([FromRoute]int id, [FromBody]UserViewModel userViewModel)
        {
            service.UpdateUser(id, userViewModel);
        }

        //[HttpPatch("{id}")]
        //public void UpdatePartialUser([FromRoute]int id, [FromBody]UserViewModel userViewModel)
        //{
        //    service.UpdatePartialUser(id, userViewModel);
        //}
    }
}

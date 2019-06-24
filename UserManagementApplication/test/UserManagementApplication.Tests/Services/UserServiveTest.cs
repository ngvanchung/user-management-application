using System.Collections.Generic;
using AutoMapper;
using NSubstitute;
using UserManagementApplication.DomainModels;
using UserManagementApplication.Mappers;
using UserManagementApplication.Repositories;
using UserManagementApplication.Services;
using UserManagementApplication.ViewModels;
using Xunit;

namespace UserManagementApplication.Tests.Services
{
    public class UserServiveTest
    {
        private readonly UserService service;
        private readonly IUserRepository repository;
        private readonly MapperConfiguration mapperConfiguration;
        private readonly IMapper mapper;

        public UserServiveTest()
        {
            repository = Substitute.For<IUserRepository>();
            mapperConfiguration = new MapperConfiguration(new MapProfile());
            mapper = new Mapper(mapperConfiguration);
            service = new UserService(repository, mapper);
        }

        [Fact]
        public void GetUsers_WithValidParameters_ShouldHaveOneElement()
        {
            // Arrange
            int id = 101;
            string name = "Nguyen Van A";
            int age = 10;
            string address = "Ha Noi";

            repository.GetUsers().Returns(new List<User> { new User { Id = id, Name = name, Age = age, Address = address } });

            // Act
            IList<UserViewModel> users = service.GetUsers();

            // Assert
            Assert.NotNull(users);
            Assert.Collection(users, user => Assert.Contains(name, user.Name));
        }

        [Fact]
        public void GetUserById_WithValidParameters_SholdNotBeNull()
        {
            // Arrange
            int id = 101;
            string name = "Nguyen Van A";
            int age = 10;
            string address = "Ha Noi";
            repository.GetUserById(id).Returns(new User { Id = id, Name = name, Age = age, Address = address });

            // Act
            var user = service.GetUserById(id);

            // Assert
            Assert.NotNull(user);
            Assert.Equal(user.Name, name);
            Assert.Equal(user.Age, age);
            Assert.Equal(user.Address, address);
        }
    }
}

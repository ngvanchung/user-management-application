# user-management-application

Open project:
- Use Visual Studio 2017
- Open file UserManagementApplication.sln

Test project:

Open Postman:
- Get all users: GET https://localhost:44308/api/users
- Get user by Id: GET https://localhost:44308/api/users/{id}
- Create user: POST https://localhost:44308/api/users
- Update user: PUT https://localhost:44308/api/users/{id}

Payload:
{
  "name":"Nguyen Van A",
  "age": 10,
  "address":"Ho Chi Minh City"}
}

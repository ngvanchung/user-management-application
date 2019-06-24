using System;
using System.Net;

namespace UserManagementApplication.Exceptions
{
    public class UserManagementException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public UserManagementException()
        {
        }

        public UserManagementException(string message) : base(message)
        {
        }

        public UserManagementException(string message, Exception inner)
        : base(message, inner)
        {
        }

        public UserManagementException(HttpStatusCode statusCode, string message) : base(message)
        {
            HttpStatusCode = statusCode;
        }
    }
}

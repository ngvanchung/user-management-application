using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagementApplication.Results
{
    public class ErrorResult
    {
        public int Code { get; set; } = -1;

        public string Message { get; set; }

        public List<string> Errors { get; set; }
    }
}

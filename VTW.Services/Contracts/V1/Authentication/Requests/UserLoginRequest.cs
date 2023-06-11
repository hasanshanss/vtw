using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.API.Services.Contracts.V1.Authentication.Requests
{
    public class UserLoginRequest
    {
        public string Password { get; set; }
        public string UsernameOrEmail { get; set; }
    }
}

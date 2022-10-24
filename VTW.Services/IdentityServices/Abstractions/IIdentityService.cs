using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.Authentication.Requests;
using VTW.API.Services.Contracts.Authentication.Responses;

namespace VTW.API.Services.IdentityServices.Abstractions
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(UserAuthenticationRequest user);
        Task<AuthenticationResult> LoginAsync(UserAuthenticationRequest user);
    }
}

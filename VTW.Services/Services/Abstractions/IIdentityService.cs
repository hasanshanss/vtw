using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.Authentication.Responses;
using VTW.API.Services.Contracts.V1.Authentication.Requests;

namespace VTW.API.Services.Services.Abstractions
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(UserRegistrationRequest user);
        Task<AuthenticationResult> LoginAsync(UserLoginRequest user);
        Task<AuthenticationResult> RefreshTokenAsync(string token, string refreshToken);
        ClaimsPrincipal GetPrincipalFromToken(string token);
    }
}

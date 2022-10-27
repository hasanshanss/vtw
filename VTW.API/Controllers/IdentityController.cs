using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VTW.API.Services.Contracts.Authentication.Requests;
using VTW.API.Services.Contracts.Authentication.Responses;
using VTW.API.Services.IdentityServices.Abstractions;

namespace VTW.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserAuthenticationRequest user)
        {
            var authResponse = await _identityService.RegisterAsync(user);
            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedReponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserAuthenticationRequest user)
        {
            var authResponse = await _identityService.LoginAsync(user);
            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedReponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });
        }

        [HttpPost]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest refreshTokenRequest)
        {
            var authResponse = await _identityService.RefreshTokenAsync(refreshTokenRequest.Token, refreshTokenRequest.RefreshToken);
            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedReponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token,
                RefreshToken = authResponse.RefreshToken
            });
        }


    }
}

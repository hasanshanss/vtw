using MediatR;
using Microsoft.AspNetCore.Mvc;
using VTW.API.Helpers.Routes.V1;

[ApiController]
public abstract class BaseApiController : ControllerBase
{
    protected IMediator Mediator { get; set; }
}
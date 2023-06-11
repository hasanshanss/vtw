using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using VTW.API.Extensions;
using VTW.API.Helpers.Routes.V1;
using VTW.API.RequestHandlers.Commands.CommandModels;
using VTW.API.Services.Contracts.V1.TeamContracts;
using VTW.API.Services.Contracts.V1.TeamContracts.Requests;
using VTW.API.Services.Services.Abstractions;

namespace VTW.API.Controllers.V1.Admin
{
    [ApiController]
    public class TeamController : AdminBaseController
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }


        [Route(ApiRoutes.Team.Create)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateTeamRequest createTeamRequest)
        {
            createTeamRequest.CreatedBy = HttpContext.GetUserId();
            var team = await _teamService.AddTeamAsync(createTeamRequest);

            

            return CreatedAtAction(nameof(Get), new { Id = team.Id }, team);
        }

        [Route(ApiRoutes.Team.GetAll)]
        [HttpGet]
        public IEnumerable<TeamDto> GetAll()
        {
            return _teamService.GetTeamList();
        }

        [Route(ApiRoutes.Team.Get)]
        [HttpGet]
        public Task<TeamDto> Get([FromRoute] int teamId)
        {
            return _teamService.GetOneTeamAsync(teamId);
        }

        [Route(ApiRoutes.Team.Delete)]
        [HttpDelete]
        public IActionResult Delete(int teamId)
        {
            _teamService.DeleteTeam(teamId);
            return Ok("Deleted");
        }

        [Route(ApiRoutes.Team.Update)]
        [HttpPut]
        public IActionResult Update(UpdateTeamRequest updateTeamRequest)
        {
            var updatedTeam = _teamService.UpdateTeam(updateTeamRequest);
            return Ok(updatedTeam);


        }


    }
}

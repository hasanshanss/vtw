using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VTW.API.Services.Contracts.Team.Requests;
using VTW.DAL.Entities;
using VTW.DAL.Repositories.Abstractions;
using VTW.Services.Abstractions;

namespace VTW.API.Controllers.Admin
{
    [ApiController]
    public class TeamController : AdminBaseController
    {
        private readonly ITeamService _teamService;
        
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "";
        }

        [HttpPost]
        public async Task Post([FromBody] CreateTeamRequest TeamRequestDto)
        {
            await _teamService.AddTeamAsync(TeamRequestDto);
            //return CreatedAtAction(nameof(Get), new { Id = TeamRequestDto.TeamId }, TeamRequestDto);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Team team)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VTW.API.Extensions;
using VTW.API.Services.Contracts.V1.TeamContracts.Requests;
using VTW.API.Services.Services.Abstractions;
using VTW.DAL.Entities;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.API.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : BaseApiController
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

        public async Task Post([FromBody] CreateTeamRequest createTeamRequest)
        {

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

using Microsoft.AspNetCore.Mvc;
using VTW.API.Services.Contracts.TeamCategory.Requests;
using VTW.API.Services.TeamCategoryServices.Abstractions;
using VTW.DAL.Entities;
using VTW.Services.Abstractions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VTW.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamCategoryController : ControllerBase
    {
        private readonly ITeamCategoryService _teamCategoryService;
        public TeamCategoryController(ITeamCategoryService teamCategoryService)
        {
            _teamCategoryService = teamCategoryService;
        }

        // GET: api/<TeamCategoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TeamCategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TeamCategoryController>
        [HttpPost]
        public async Task Post([FromBody] CreateTeamCategoryRequest TeamCategoryRequestDto)
        {
            await _teamCategoryService.AddTeamCategoryAsync(TeamCategoryRequestDto);
        }

        // PUT api/<TeamCategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeamCategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

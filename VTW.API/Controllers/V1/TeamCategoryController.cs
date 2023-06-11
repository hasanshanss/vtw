using Microsoft.AspNetCore.Mvc;
using VTW.API.Extensions;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts.Requests;
using VTW.API.Services.Services.Abstractions;

namespace VTW.API.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamCategoryController : BaseApiController
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
        public async Task Post([FromBody] CreateTeamCategoryRequest createTeamCategoryRequest)
        {

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

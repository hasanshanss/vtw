using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using VTW.API.Extensions;
using VTW.API.Helpers.Routes.V1;
using VTW.API.RequestHandlers.Commands.CommandModels;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts.Requests;
using VTW.API.Services.Services.Abstractions;

namespace VTW.API.Controllers.V1.Admin
{
    [ApiController]
    public class TeamCategoryController : AdminBaseController
    {
        private readonly ITeamCategoryService _teamCategoryService;
        public TeamCategoryController(ITeamCategoryService teamCategoryService)
        {
            _teamCategoryService = teamCategoryService;
        }


        [Route(ApiRoutes.TeamCategory.Create)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateTeamCategoryRequest createTeamCategoryRequest)
        {
            createTeamCategoryRequest.CreatedBy = HttpContext.GetUserId();
            var teamCategory = await _teamCategoryService.AddTeamCategoryAsync(createTeamCategoryRequest);


            return CreatedAtAction(nameof(Get), new { Id = teamCategory.Id }, teamCategory);
        }

        [Route(ApiRoutes.TeamCategory.GetAll)]
        [HttpGet]
        public IEnumerable<TeamCategoryDto> GetAll()
        {
            return _teamCategoryService.GetTeamCategoryList();
        }

        [Route(ApiRoutes.TeamCategory.Get)]
        [HttpGet]
        public Task<TeamCategoryDto> Get([FromRoute] int teamCategoryId)
        {
            return _teamCategoryService.GetOneTeamCategoryAsync(teamCategoryId);
        }

        [Route(ApiRoutes.TeamCategory.Delete)]
        [HttpDelete]
        public IActionResult Delete(int teamCategoryId)
        {
            _teamCategoryService.DeleteTeamCategory(teamCategoryId);
            return Ok("Deleted");
        }

        [Route(ApiRoutes.TeamCategory.Update)]
        [HttpPut]
        public IActionResult Update(UpdateTeamCategoryRequest updateTeamCategoryRequest)
        {
            var updatedTeamCategory = _teamCategoryService.UpdateTeamCategory(updateTeamCategoryRequest);
            return Ok(updatedTeamCategory);

            
        }


    }
}

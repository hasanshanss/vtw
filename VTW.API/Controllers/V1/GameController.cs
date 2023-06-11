using Microsoft.AspNetCore.Mvc;
using VTW.API.Extensions;
using VTW.API.Services.Contracts.V1.VoteContracts;
using VTW.API.Services.Contracts.V1.VoteContracts.Requests;
using VTW.API.Services.Contracts.V1.GameContracts.Requests;
using VTW.API.Services.Contracts.V1.VoteContracts.Responses;
using VTW.API.Services.Contracts.V1.GameContracts;
using VTW.API.Helpers.Routes.V1;

namespace VTW.API.Controllers.V1
{
    [ApiController]
    public class GameController : BaseApiController
    {

        public GameController()
        {
        }

        [Route(ApiRoutes.Games.GetAll)]
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "" };

        }

        [Route(ApiRoutes.Games.Create)]
        [HttpPost]
        public async Task Post([FromBody] CreateGameRequest createGameRequest)
        {

        }

        //[HttpPost("/Vote")]
        //public async Task<CreateVoteResponse> Vote([FromBody] CreateVoteRequest createVoteDto)
        //{
        //    //createVoteDto.VoterId = HttpContext.GetUserId();

        //    //var firstVoteDto = await _voteService.UpdateFirstVoterAsync(createVoteDto);
        //    //var biggestVoteDto = await _voteService.UpdateMostVoterAsync(createVoteDto);

        //    //if (firstVoteDto.VoterId != createVoteDto.VoterId
        //    //    && biggestVoteDto.VoterId != createVoteDto.VoterId)
        //    //{
        //    //    await _voteService.AddVoteAsync(createVoteDto);
        //    //}

        //    //return new CreateVoteResponse(firstVoteDto, biggestVoteDto);
        //}

        // PUT api/<VoteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            //await _gameService.DeleteGameAsync(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.GameContracts.Requests;
using VTW.API.Services.Contracts.V1.GameContracts;
using VTW.DAL.Repositories;

namespace VTW.API.Services.Services.Abstractions
{
    public interface IGameService 
    {
        //Delete
        Task DeleteGameAsync(long id);
        Task SoftDeleteGameAsync(long id, byte[] timeStamp);
        Task DeleteRangeGameAsync(IEnumerable<DeleteGameRequest> Games);

        //Get
        Task<GameDto> GetOneGameAsync(long id);
        IEnumerable<GameDto> GetGameBy(GameDto gameDto);

        IEnumerable<GameDto> GetGameList();
        Task<long> GetCountAsync();

        //Insert&Update
        Task<GameDto> AddGameAsync(CreateGameRequest Game);
        Task<IEnumerable<GameDto>> AddGameRangeAsync(IEnumerable<CreateGameRequest> GameList);
        GameDto UpdateGame(UpdateGameRequest GameToUpdate);
        IEnumerable<GameDto> UpdateGameRange(IEnumerable<UpdateGameRequest> GameList);

        Task<bool> IsGameFinished(int gameId);
        Task<DateTime> GetRemainingTime(int gameId);
    }
}

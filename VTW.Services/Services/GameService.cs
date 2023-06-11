using AutoMapper;
using VTW.API.Services.Contracts.V1.GameContracts;
using VTW.API.Services.Contracts.V1.GameContracts.Requests;
using VTW.API.Services.Services.Abstractions;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.API.Services.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly IGameTeamInfoRepository _gameTeamInfoRepository;
        private readonly IMapper _mapper;

        public GameService(IGameRepository gameRepository, IMapper mapper, IVoteRepository voteRepository, IGameTeamInfoRepository gameTeamInfoRepository)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
            _gameTeamInfoRepository = gameTeamInfoRepository;
        }

        public async Task<GameDto> AddGameAsync(CreateGameRequest GameDto)
        {
            //Game Game = _mapper.Map<Game>(GameDto);
            //await _gameRepository.AddAsync(Game);
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GameDto>> AddGameRangeAsync(IEnumerable<CreateGameRequest> GameList)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeGameAsync(IEnumerable<DeleteGameRequest> Games)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGameAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GameDto> GetOneGameAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameDto> GetGameBy(GameDto gameDto)
        {
            var games = _gameRepository.GetBy(m => m.IsStarted == gameDto.IsStarted
            && m.IsFinished == gameDto.IsFinished);
            //&& (gameDto.TeamCategoryId != 0 || m.GameTeamInfoNavigations.Any(m => m.TeamNavigation.TeamCategoryId == gameDto.TeamCategoryId))
            //&& (gameDto.VoterId != 0 || m.GameTeamInfoNavigations
            //.Any(m => m.VoteNavigations
            //.Any(m => m.Id == gameDto.VoterId))), 
            //m=>m.OrderBy(m=>m.CreatedDate),
            //"GameTeamInfoNavigations");

            return _mapper.Map<IEnumerable<GameDto>>(games);
        }

        public IEnumerable<GameDto> GetGameList()
        {
            return _mapper.Map<IEnumerable<GameDto>>(_gameRepository.GetAll());
        }



        public Task SoftDeleteGameAsync(long id, byte[] timeStamp)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsGameFinished(int gameId)
        {
            var game = await _gameRepository.FindAsync(gameId);
            return game.EndDate > DateTime.UtcNow;
        }

        public Task<DateTime> GetRemainingTime(int gameId)
        {
            throw new NotImplementedException();
        }

        public GameDto UpdateGame(UpdateGameRequest GameToUpdate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameDto> UpdateGameRange(IEnumerable<UpdateGameRequest> GameList)
        {
            throw new NotImplementedException();
        }
    }
}

using MediatR;
using VTW.API.RequestHandlers.QueryModels;
using VTW.API.Services.Contracts.V1.GameContracts;
using VTW.API.Services.Services.Abstractions;

namespace VTW.API.RequestHandlers.Create
{
    public class GetGameRequestHandler : IRequestHandler<GetGameQuery, IEnumerable<GameDto>>
    {
        private readonly IGameService _gameService;
        public GetGameRequestHandler(IGameService gameService)
        {
            _gameService = gameService;
        }

        public Task<IEnumerable<GameDto>> Handle(GetGameQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_gameService.GetGameList());
        }
    }
}

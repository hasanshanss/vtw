using MediatR;
using VTW.API.RequestHandlers.Commands.CommandModels;
using VTW.API.Services.Contracts.V1.GameContracts;
using VTW.API.Services.Services.Abstractions;

namespace VTW.API.RequestHandlers.Create
{
    public class CreateGameRequestHandler : IRequestHandler<CreateGameCommand, GameDto>
    {
        private readonly IGameService _gameService;
        public CreateGameRequestHandler(IGameService gameService)
        {
            _gameService = gameService;
        }

        public async Task<GameDto> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            return await _gameService.AddGameAsync(request);
        }
    }
}

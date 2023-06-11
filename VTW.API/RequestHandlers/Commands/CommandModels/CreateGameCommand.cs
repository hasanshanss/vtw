using MediatR;
using VTW.API.Services.Contracts.V1.GameContracts;
using VTW.API.Services.Contracts.V1.GameContracts.Requests;

namespace VTW.API.RequestHandlers.Commands.CommandModels
{
    public class CreateGameCommand : CreateGameRequest, IRequest<GameDto>
    {

    }
}

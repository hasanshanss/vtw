using MediatR;
using VTW.API.Services.Contracts.V1.GameContracts;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts;

namespace VTW.API.RequestHandlers.QueryModels
{
    public class GetGameQuery : GameDto, IRequest<IEnumerable<GameDto>>
    {
    }
}

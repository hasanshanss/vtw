using AutoMapper;
using VTW.API.Services.Contracts.V1.TeamContracts;
using VTW.API.Services.Contracts.V1.TeamContracts.Requests;
using VTW.API.Services.Contracts.V1.GameContracts.Requests;
using VTW.DAL.Entities;

namespace VTW.API.Services.MappingProfiles.TeamProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<CreateTeamRequest, Team>().ReverseMap();
            CreateMap<UpdateTeamRequest, Team>().ReverseMap();
            CreateMap<TeamDto, Team>().ReverseMap();
        }
    }
}

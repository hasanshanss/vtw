using AutoMapper;
using VTW.API.Services.Contracts.Team;
using VTW.API.Services.Contracts.Team.Requests;
using VTW.DAL.Entities;

namespace VTW.API.MappingProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<CreateTeamRequest, Team>().ReverseMap();
            CreateMap<UpdateTeamRequest, Team>().ReverseMap();
            CreateMap<DeleteTeamRequest, Team>().ReverseMap();
            CreateMap<TeamDto, Team>().ReverseMap();
        }
    }
}

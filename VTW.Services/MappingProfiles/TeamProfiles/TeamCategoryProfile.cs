using AutoMapper;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts.Requests;
using VTW.DAL.Entities;

namespace VTW.API.Services.MappingProfiles.TeamProfiles
{
    public class TeamCategoryProfile : Profile
    {
        public TeamCategoryProfile()
        {
            CreateMap<CreateTeamCategoryRequest, TeamCategory>().ReverseMap();
            CreateMap<UpdateTeamCategoryRequest, TeamCategory>().ReverseMap();
            CreateMap<TeamCategoryDto, TeamCategory>().ReverseMap();
        }
    }
}

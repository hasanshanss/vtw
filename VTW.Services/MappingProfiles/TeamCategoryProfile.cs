using AutoMapper;
using VTW.API.Services.Contracts.TeamCategory;
using VTW.API.Services.Contracts.TeamCategory.Requests;
using VTW.DAL.Entities;

namespace VTW.API.MappingProfiles
{
    public class TeamCategoryProfile : Profile
    {
        public TeamCategoryProfile()
        {
            CreateMap<CreateTeamCategoryRequest, TeamCategory>().ReverseMap();
            CreateMap<UpdateTeamCategoryRequest, TeamCategory>().ReverseMap();
            CreateMap<DeleteTeamCategoryRequest, TeamCategory>().ReverseMap();
            CreateMap<TeamCategoryRequestDto, TeamCategory>().ReverseMap();
        }
    }
}

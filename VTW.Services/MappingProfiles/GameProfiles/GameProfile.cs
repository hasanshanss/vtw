using AutoMapper;
using VTW.API.Services.Contracts.V1.GameContracts;
using VTW.API.Services.Contracts.V1.GameContracts.Requests;
using VTW.DAL.Entities;

namespace VTW.API.Services.MappingProfiles.GameProfiles
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<CreateGameRequest, Game>()
                .ForMember(v => v.GameTeamInfoNavigations, opt => opt.MapFrom<GameTeamInfoResolver>())
                .ReverseMap(); 

            CreateMap<UpdateGameRequest, Game>().ReverseMap();
            CreateMap<DeleteGameRequest, Game>().ReverseMap();

            CreateMap<GameDto, Game>()
                .ForMember(v => v.GameTeamInfoNavigations, opt => opt.MapFrom(m=>m.GameTeamInfos))
                .ReverseMap();
        }

        public class GameTeamInfoResolver : IValueResolver<CreateGameRequest, Game, ICollection<GameTeamInfo>>
        {
            public ICollection<GameTeamInfo> Resolve(CreateGameRequest source, Game destination, ICollection<GameTeamInfo> destMember, ResolutionContext context)
            {
                destMember.Add(new GameTeamInfo() { TeamId = source.Team1_Id });
                destMember.Add(new GameTeamInfo() { TeamId = source.Team2_Id });
                return destMember;
            }
        }
        
    }
}

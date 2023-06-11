using AutoMapper;
using VTW.API.Services.Contracts.V1.VoteContracts.Requests;
using VTW.API.Services.Contracts.V1.VoteContracts;
using VTW.API.Services.Contracts.V1.VoteContracts.Requests;
using VTW.DAL.Entities;

namespace VTW.API.Services.MappingProfiles.VoteProfiles
{
    public class VoteProfile : Profile
    {
        public VoteProfile()
        {
            CreateMap<CreateVoteRequest, Vote>();
            CreateMap<CreateVoteRequest, VoteDto>();
            CreateMap<UpdateVoteRequest, Vote>().ReverseMap();
            CreateMap<DeleteVoteRequest, Vote>().ReverseMap();
            CreateMap<VoteDto, Vote>().ReverseMap();
        }

       
    }
}

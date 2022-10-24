using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.TeamCategory;
using VTW.API.Services.Contracts.TeamCategory.Requests;
using VTW.API.Services.TeamCategoryServices.Abstractions;
using VTW.DAL.Entities;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.API.Services.TeamServices
{
    public class TeamCategoryService : ITeamCategoryService
    {
        private ITeamCategoryRepository _teamCategoryRepository;
        private readonly IMapper _mapper;
        public TeamCategoryService(IMapper mapper, 
            ITeamCategoryRepository teamCategoryRepository)
        {
            _mapper = mapper;
            _teamCategoryRepository = teamCategoryRepository;
        }

        public async Task AddTeamCategoryAsync(CreateTeamCategoryRequest TeamCategoryRequestDto)
        {
            TeamCategory teamCategory = _mapper.Map<TeamCategory>(TeamCategoryRequestDto);
            await _teamCategoryRepository.AddAsync(teamCategory);
        }

        public Task AddTeamCategoryAsync(IEnumerable<CreateTeamCategoryRequest> teamCategoryList)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeTeamCategoryAsync(IEnumerable<DeleteTeamCategoryRequest> teamCategorys)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTeamCategoryAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TeamCategoryRequestDto> GetOneTeamCategoryAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamCategoryRequestDto> GetTeamCategoryBy(Expression<Func<TeamCategoryRequestDto, bool>> filter = null, Func<IQueryable<TeamCategoryRequestDto>, IOrderedQueryable<TeamCategoryRequestDto>> orderBy = null, bool isDeleted = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamCategoryRequestDto> GetTeamCategoryList()
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteTeamCategoryAsync(long id, byte[] timeStamp)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTeamCategoryAsync(UpdateTeamCategoryRequest teamCategoryToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTeamCategoryAsync(IEnumerable<UpdateTeamCategoryRequest> teamCategoryList)
        {
            throw new NotImplementedException();
        }
    }
}

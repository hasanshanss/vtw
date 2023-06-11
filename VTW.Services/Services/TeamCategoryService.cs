using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.TeamContracts.Requests;
using VTW.API.Services.Contracts.V1.TeamContracts;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts.Requests;
using VTW.DAL.Entities;
using VTW.DAL.Repositories;
using VTW.DAL.Repositories.Abstractions;
using VTW.API.Services.Services.Abstractions;

namespace VTW.API.Services.Services
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

        public async Task<TeamCategory> AddTeamCategoryAsync(CreateTeamCategoryRequest createTeamCategoryRequest)
        {
            TeamCategory teamCategory = _mapper.Map<TeamCategory>(createTeamCategoryRequest);
            await _teamCategoryRepository.AddAsync(teamCategory);
            return teamCategory;
        }

        public async Task<IEnumerable<TeamCategoryDto>> AddTeamCategoryRangeAsync(IEnumerable<CreateTeamCategoryRequest> createTeamCategoryRequests)
        {
            IEnumerable<TeamCategory> teams = _mapper.Map<IEnumerable<TeamCategory>>(createTeamCategoryRequests);
            await _teamCategoryRepository.AddRangeAsync(teams);
            return _mapper.Map<IEnumerable<TeamCategoryDto>>(teams);
        }

        public void DeleteRangeTeamCategory(IEnumerable<int> teamCategorys)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeamCategory(int id)
        {
            _teamCategoryRepository.Delete(id);
            
        }

        public Task<int> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TeamCategoryDto> GetOneTeamCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamCategoryDto> GetTeamCategoryBy(Expression<Func<TeamCategoryDto, bool>> filter = null, Func<IQueryable<TeamCategoryDto>, IOrderedQueryable<TeamCategoryDto>> orderBy = null, bool isDeleted = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamCategoryDto> GetTeamCategoryList()
        {
            return _mapper.Map<IEnumerable<TeamCategoryDto>>(_teamCategoryRepository.GetAll());
        }

        public void SoftDeleteTeamCategory(int id, byte[] timeStamp)
        {
            throw new NotImplementedException();
        }

        public TeamCategory UpdateTeamCategory(UpdateTeamCategoryRequest teamToUpdate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamCategory>  UpdateTeamCategory(IEnumerable<UpdateTeamCategoryRequest> teamList)
        {
            throw new NotImplementedException();
        }

       
    }
}

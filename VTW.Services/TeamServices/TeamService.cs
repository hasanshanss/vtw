using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.Team;
using VTW.API.Services.Contracts.Team.Requests;
using VTW.DAL.Entities;
using VTW.DAL.Repositories.Abstractions;
using VTW.Services.Abstractions;

namespace VTW.Services.TeamServices
{
    public class TeamService : ITeamService
    {
        private ITeamRepository _teamRepository;
        private readonly IMapper _mapper;
        public TeamService(IMapper mapper, ITeamRepository teamRepository)
        {
            _mapper = mapper;
            _teamRepository = teamRepository;
        }

        public async Task AddTeamAsync(CreateTeamRequest TeamDto)
        {
            Team team = _mapper.Map<Team>(TeamDto);
            await _teamRepository.AddAsync(team);
        }

        public Task AddTeamAsync(IEnumerable<CreateTeamRequest> teamList)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeTeamAsync(IEnumerable<DeleteTeamRequest> teams)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTeamAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TeamDto> GetOneTeamAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamDto> GetTeamBy(Expression<Func<TeamDto, bool>> filter = null, Func<IQueryable<TeamDto>, IOrderedQueryable<TeamDto>> orderBy = null, bool isDeleted = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamDto> GetTeamList()
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteTeamAsync(long id, byte[] timeStamp)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTeamAsync(UpdateTeamRequest teamToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTeamAsync(IEnumerable<UpdateTeamRequest> teamList)
        {
            throw new NotImplementedException();
        }
    }
}

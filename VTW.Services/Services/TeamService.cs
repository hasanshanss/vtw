using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.TeamContracts;
using VTW.API.Services.Contracts.V1.TeamContracts.Requests;
using VTW.API.Services.Services.Abstractions;
using VTW.DAL.Entities;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.API.Services.Services
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

        public async Task<TeamDto> AddTeamAsync(CreateTeamRequest createTeamDto)
        {
            Team team = _mapper.Map<Team>(createTeamDto);
            await _teamRepository.AddAsync(team);

            var filePath = Path.GetTempFileName();

            using (var stream = File.Create(filePath))
            {
                await createTeamDto.Image.CopyToAsync(stream);
            }

            return _mapper.Map<TeamDto>(team);
        }

        public async Task<IEnumerable<TeamDto>> AddTeamRangeAsync(IEnumerable<CreateTeamRequest> createTeamDtos)
        {
            IEnumerable<Team> teams = _mapper.Map<IEnumerable<Team>>(createTeamDtos);
            await _teamRepository.AddRangeAsync(teams);
            return _mapper.Map<IEnumerable<TeamDto>>(teams);
        }


        public void DeleteRangeTeam(IEnumerable<int> teams)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeam(int id)
        {
            _teamRepository.Delete(id);
        }

        public Task<int> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TeamDto> GetOneTeamAsync(int id)
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

        public void SoftDeleteTeam(int id, byte[] timeStamp)
        {
            throw new NotImplementedException();
        }

        public TeamDto UpdateTeam(UpdateTeamRequest teamToUpdate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamDto> UpdateTeamRange(IEnumerable<UpdateTeamRequest> teamList)
        {
            throw new NotImplementedException();
        }
    }
}

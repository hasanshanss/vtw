using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.VoteContracts;
using VTW.API.Services.Contracts.V1.VoteContracts.Requests;
using VTW.DAL.Entities;
using VTW.DAL.Repositories.Abstractions;
using System.Diagnostics.Contracts;
using VTW.API.Services.Contracts.V1.TeamContracts;
using VTW.API.Services.Services.Abstractions;

namespace VTW.API.Services.Services
{
    public class VoteService : IVoteService
    {

        private readonly IVoteRepository _voteRepository;
        private readonly IGameTeamInfoRepository _gameTeamInfoRepository;
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public VoteService(IMapper mapper, IVoteRepository voteRepository, IGameTeamInfoRepository gameTeamInfoRepository, IGameRepository gameRepository)
        {
            _mapper = mapper;
            _voteRepository = voteRepository;
            _gameTeamInfoRepository = gameTeamInfoRepository;
            _gameRepository = gameRepository;
        }
        public async Task AddVoteAsync(CreateVoteRequest createVoteDto)
        {
            await _voteRepository.AddAsync(_mapper.Map<Vote>(createVoteDto));

            var gameTeamInfo = await _gameTeamInfoRepository.FindAsync(createVoteDto.GameTeamInfoId);
            gameTeamInfo.TotalAmount += createVoteDto.VoteAmount;
            _gameTeamInfoRepository.Update(gameTeamInfo);
        }

        public Task AddVoteAsync(IEnumerable<CreateVoteRequest> VoteList)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeVoteAsync(IEnumerable<DeleteVoteRequest> Votes)
        {
            throw new NotImplementedException();
        }

        public Task DeleteVoteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<VoteDto> GetOneVoteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VoteDto> GetVoteBy(Expression<Func<VoteDto, bool>> filter = null, Func<IQueryable<VoteDto>, IOrderedQueryable<VoteDto>> orderBy = null, bool isDeleted = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VoteDto> GetVoteList()
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteVoteAsync(long id, byte[] timeStamp)
        {
            throw new NotImplementedException();
        }

        public Task UpdateVoteAsync(UpdateVoteRequest VoteToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateVoteAsync(IEnumerable<UpdateVoteRequest> VoteList)
        {
            throw new NotImplementedException();
        }

        public async Task<VoteDto> UpdateFirstVoterAsync(CreateVoteRequest createVoteDto)
        {
            GameTeamInfo gameTeamInfo = await _gameTeamInfoRepository.FindAsync(createVoteDto.GameTeamInfoId);

            if (string.IsNullOrEmpty(gameTeamInfo.FirstVoterId))
            {
                gameTeamInfo.FirstVoterId = createVoteDto.VoterId;
                _gameTeamInfoRepository.Update(gameTeamInfo);
            }

            Vote firstVote = _mapper.Map<Vote>(createVoteDto);
            await _voteRepository.AddAsync(firstVote);

            return _mapper.Map<VoteDto>(createVoteDto);
        }

        public async Task<VoteDto> UpdateMostVoterAsync(CreateVoteRequest createVoteDto)
        {
            Vote mostVote = _voteRepository.MaxBy(m => m.VoteAmount);

            if (createVoteDto.VoteAmount > mostVote.VoteAmount)
            {
                GameTeamInfo gameTeamInfo = await _gameTeamInfoRepository.FindAsync(createVoteDto.GameTeamInfoId);
                gameTeamInfo.MostVoterId = createVoteDto.VoterId;
                _gameTeamInfoRepository.Update(gameTeamInfo);
            }

            mostVote = _mapper.Map<Vote>(createVoteDto);
            await _voteRepository.AddAsync(mostVote);

            return _mapper.Map<VoteDto>(mostVote);
        }


    }
}

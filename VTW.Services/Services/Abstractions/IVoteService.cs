using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.VoteContracts.Requests;
using VTW.API.Services.Contracts.V1.VoteContracts;
using VTW.DAL.Repositories;
using VTW.API.Services.Contracts.V1.TeamContracts;

namespace VTW.API.Services.Services.Abstractions
{
    public interface IVoteService
    {
        //Delete
        Task DeleteVoteAsync(long id);
        Task SoftDeleteVoteAsync(long id, byte[] timeStamp);
        Task DeleteRangeVoteAsync(IEnumerable<DeleteVoteRequest> Votes);

        //Get
        Task<VoteDto> GetOneVoteAsync(long id);
        IEnumerable<VoteDto> GetVoteBy(Expression<Func<VoteDto, bool>> filter = null,
                                        Func<IQueryable<VoteDto>, IOrderedQueryable<VoteDto>> orderBy = null,
                                        bool isDeleted = false);

        IEnumerable<VoteDto> GetVoteList();
        Task<long> GetCountAsync();

        //Insert&Update
        Task AddVoteAsync(CreateVoteRequest Vote);
        Task AddVoteAsync(IEnumerable<CreateVoteRequest> VoteList);
        Task UpdateVoteAsync(UpdateVoteRequest VoteToUpdate);
        Task UpdateVoteAsync(IEnumerable<UpdateVoteRequest> VoteList);
        Task<VoteDto> UpdateFirstVoterAsync(CreateVoteRequest createVoteDto);
        Task<VoteDto> UpdateMostVoterAsync(CreateVoteRequest createVoteDto);
    }
}

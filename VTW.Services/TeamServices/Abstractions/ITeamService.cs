using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.Team;
using VTW.API.Services.Contracts.Team.Requests;

namespace VTW.Services.Abstractions
{
    public interface ITeamService
    {
        //Delete
        Task DeleteTeamAsync(long id);
        Task SoftDeleteTeamAsync(long id, byte[] timeStamp);
        Task DeleteRangeTeamAsync(IEnumerable<DeleteTeamRequest> teams);

        //Get
        Task<TeamDto> GetOneTeamAsync(long id);
        IEnumerable<TeamDto> GetTeamBy(Expression<Func<TeamDto, bool>> filter = null,
                                        Func<IQueryable<TeamDto>, IOrderedQueryable<TeamDto>> orderBy = null,
                                        bool isDeleted = false);

        IEnumerable<TeamDto> GetTeamList();
        Task<long> GetCountAsync();

        //Insert&Update
        Task AddTeamAsync(CreateTeamRequest team);
        Task AddTeamAsync(IEnumerable<CreateTeamRequest> teamList);
        Task UpdateTeamAsync(UpdateTeamRequest teamToUpdate);
        Task UpdateTeamAsync(IEnumerable<UpdateTeamRequest> teamList);

    }
}

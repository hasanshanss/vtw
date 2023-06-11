using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.TeamContracts;
using VTW.API.Services.Contracts.V1.TeamContracts.Requests;
using VTW.DAL.Entities;

namespace VTW.API.Services.Services.Abstractions
{
    public interface ITeamService
    {
        //Delete
        void DeleteTeam(int id);
        void SoftDeleteTeam(int id, byte[] timeStamp);
        void DeleteRangeTeam(IEnumerable<int> teams);

        //Get
        Task<TeamDto> GetOneTeamAsync(int id);
        IEnumerable<TeamDto> GetTeamBy(Expression<Func<TeamDto, bool>> filter = null,
                                        Func<IQueryable<TeamDto>, IOrderedQueryable<TeamDto>> orderBy = null,
                                        bool isDeleted = false);

        IEnumerable<TeamDto> GetTeamList();
        Task<int> GetCountAsync();

        //Insert&Update
        Task<TeamDto> AddTeamAsync(CreateTeamRequest team);
        Task<IEnumerable<TeamDto>> AddTeamRangeAsync(IEnumerable<CreateTeamRequest> teamList);
        TeamDto UpdateTeam(UpdateTeamRequest teamToUpdate);
        IEnumerable<TeamDto> UpdateTeamRange(IEnumerable<UpdateTeamRequest> teamList);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.Team;
using VTW.API.Services.Contracts.TeamCategory;
using VTW.API.Services.Contracts.TeamCategory.Requests;

namespace VTW.API.Services.TeamCategoryServices.Abstractions
{
    public interface ITeamCategoryService
    {
        //Delete
        Task DeleteTeamCategoryAsync(long id);
        Task SoftDeleteTeamCategoryAsync(long id, byte[] timeStamp);
        Task DeleteRangeTeamCategoryAsync(IEnumerable<DeleteTeamCategoryRequest> teams);

        //Get
        Task<TeamCategoryRequestDto> GetOneTeamCategoryAsync(long id);
        IEnumerable<TeamCategoryRequestDto> GetTeamCategoryBy(Expression<Func<TeamCategoryRequestDto, bool>> filter = null,
                                        Func<IQueryable<TeamCategoryRequestDto>, IOrderedQueryable<TeamCategoryRequestDto>> orderBy = null,
                                        bool isDeleted = false);

        IEnumerable<TeamCategoryRequestDto> GetTeamCategoryList();
        Task<long> GetCountAsync();

        //Insert&Update
        Task AddTeamCategoryAsync(CreateTeamCategoryRequest team);
        Task AddTeamCategoryAsync(IEnumerable<CreateTeamCategoryRequest> teamList);
        Task UpdateTeamCategoryAsync(UpdateTeamCategoryRequest teamToUpdate);
        Task UpdateTeamCategoryAsync(IEnumerable<UpdateTeamCategoryRequest> teamList);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.Contracts.V1.TeamContracts;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts.Requests;
using VTW.DAL.Entities;

namespace VTW.API.Services.Services.Abstractions
{
    public interface ITeamCategoryService
    {
        //Delete
        void DeleteTeamCategory(int id);
        void SoftDeleteTeamCategory(int id, byte[] timeStamp);
        void DeleteRangeTeamCategory(IEnumerable<int> teams);

        //Get
        Task<TeamCategoryDto> GetOneTeamCategoryAsync(int id);
        IEnumerable<TeamCategoryDto> GetTeamCategoryBy(Expression<Func<TeamCategoryDto, bool>> filter = null,
                                        Func<IQueryable<TeamCategoryDto>, IOrderedQueryable<TeamCategoryDto>> orderBy = null,
                                        bool isDeleted = false);

        IEnumerable<TeamCategoryDto> GetTeamCategoryList();
        Task<int> GetCountAsync();

        //Insert&Update
        Task<TeamCategory> AddTeamCategoryAsync(CreateTeamCategoryRequest team);
        Task<IEnumerable<TeamCategoryDto>> AddTeamCategoryRangeAsync(IEnumerable<CreateTeamCategoryRequest> teamList);
        TeamCategory UpdateTeamCategory(UpdateTeamCategoryRequest teamToUpdate);
        IEnumerable<TeamCategory> UpdateTeamCategory(IEnumerable<UpdateTeamCategoryRequest> teamList);
    }
}

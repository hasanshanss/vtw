using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.DAL.Entities;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.DAL.Repositories
{
    public class TeamCategoryRepository : BaseRepository<TeamCategory, int>, ITeamCategoryRepository
    {
        public TeamCategoryRepository(VtwContext context) : base(context)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VTW.DAL.Entities;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.DAL.Repositories
{
    public class VoteRepository : BaseRepository<Vote, long>, IVoteRepository
    {
        public VoteRepository(VtwContext context) : base(context)
        {

        }

    }
}

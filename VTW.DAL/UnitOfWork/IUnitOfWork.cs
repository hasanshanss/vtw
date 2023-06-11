using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ITeamRepository TeamRepository { get; }
        public IGameRepository GameRepository { get; }
        Task CommitAsync();
    }
}

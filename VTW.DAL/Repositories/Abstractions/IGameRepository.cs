using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.DAL.Entities;

namespace VTW.DAL.Repositories.Abstractions
{
    public interface IGameRepository : IRepository<Game, int>
    {
    }
}

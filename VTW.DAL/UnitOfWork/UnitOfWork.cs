using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.DAL.Entities;
using VTW.DAL.Repositories;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private VtwContext _vtwContext;
        private IGameRepository _GameRepository;
        private ITeamRepository _teamRepository;
        private ITeamCategoryRepository _teamCategoryRepository;

        public UnitOfWork(VtwContext vtwContext)
        {
            _vtwContext = vtwContext;
        }

        public IGameRepository GameRepository
        {
            get
            {
                return _GameRepository ?? (_GameRepository = new GameRepository(_vtwContext));
            }
        }


        public ITeamRepository TeamRepository
        {
            get
            {
                return _teamRepository ?? (_teamRepository = new TeamRepository(_vtwContext));
            }
        }

        public ITeamCategoryRepository TeamCategoryRepository
        {
            get
            {
                return _teamCategoryRepository ?? (_teamCategoryRepository = new TeamCategoryRepository(_vtwContext));
            }

        }
        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}

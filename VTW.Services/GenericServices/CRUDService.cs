using AutoMapper;
using VTW.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.API.Services.GenericServices.Abstractions;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.API.Services.GenericServices
{
    public class CRUDService<TEntity, TId> : ICRUDService<TEntity, TId>
    {
        private IMapper _mapper;
        private IRepository<TEntity, TId> _repository;

        //public CRUDService(IMapper mapper, BaseRepository<TEntity,TId> repository)
        //{
        //    _mapper = mapper;
        //    _repository = repository;
        //}

        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(IEnumerable<TEntity> entityList)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<TId> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetOneAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(TId id, byte[] timeStamp)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IEnumerable<TEntity> entityList)
        {
            throw new NotImplementedException();
        }
    }
}

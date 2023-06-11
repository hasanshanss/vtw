using AutoMapper;
using VTW.API.Services.Services.Abstractions;
using VTW.DAL.Repositories;
using VTW.DAL.Repositories.Abstractions;

namespace VTW.API.Services.Services
{
    public class BaseService<TEntity, TId> : IBaseService<TEntity, TId>
    {
        private IRepository<TEntity, TId> _repository;

        public BaseService(IRepository<TEntity, TId> repository)
        {
            _repository = repository;
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
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

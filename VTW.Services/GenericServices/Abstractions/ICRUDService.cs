namespace VTW.API.Services.GenericServices.Abstractions
{
    public interface ICRUDService<TEntity, TId>
    {
        Task DeleteAsync(TId id);
        Task SoftDeleteAsync(TId id, byte[] timeStamp);
        Task DeleteRangeAsync(IEnumerable<TEntity> entities);

        //Get
        Task<TEntity> GetOneAsync(TId id);

        IEnumerable<TEntity> GetList();
        Task<TId> GetCountAsync();

        //Insert&Update
        Task AddAsync(TEntity entity);
        Task AddAsync(IEnumerable<TEntity> entityList);
        Task UpdateAsync(TEntity entityToUpdate);
        Task UpdateAsync(IEnumerable<TEntity> entityList);

    }
}

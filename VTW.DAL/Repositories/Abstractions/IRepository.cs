using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VTW.DAL.Repositories.Abstractions
{
    public interface IRepository<TEntity, TId> : IDisposable
    {
        //Delete
        void Delete(TId id);
        void SoftDelete(TId id, byte[] timeStamp);
        void DeleteRange(IEnumerable<TEntity> entities);

        //Get
        IEnumerable<TEntity> GetBy(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilter = true);

        TEntity MaxBy<TKey>(
            Expression<Func<TEntity, TKey>> filter,
            bool ignoreQueryFilter = false);

        TEntity MinBy<TKey>(
            Expression<Func<TEntity, TKey>> filter,
            bool ignoreQueryFilter = false);
        Task<TEntity> FindAsync(TId id);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> FindAsNoTrackingAsync(TId id);
        Task<TEntity> FindIgnoreQueryFilterAsync(TId id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllIgnoreQueryFilter();

        Task<int> GetCountAsync();

        //Insert&Update
        Task<TEntity> AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entityList);
        TEntity Update(TEntity entityToUpdate);
        IEnumerable<TEntity> UpdateRange(IEnumerable<TEntity> entityList);

        IEnumerable<TEntity> GetWithRawSql(string query,
            params object[] parameters);
    }
}

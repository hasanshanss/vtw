using Microsoft.EntityFrameworkCore;
using VTW.DAL.Entities;
using VTW.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VTW.DAL.Entities;

namespace VTW.DAL.Repositories
{
    public abstract class BaseRepository<TEntity, TId> : IRepository<TEntity, TId>
                                            where TEntity : BaseEntity<TId>, new()
    {
        internal VtwContext context;
        internal DbSet<TEntity> dbSet;

        protected BaseRepository(VtwContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual void Delete(TId id)
        {
            var entityToDelete = new TEntity { Id = (TId)id };
            dbSet.Remove(entityToDelete);
        }

        public virtual void SoftDelete(TId id, byte[] timeStamp)
        {
            var entityToDelete = new TEntity { Id = (TId)id };
            var entry = context.Entry(entityToDelete);
            entry.Property("Timestamp").CurrentValue = timeStamp;
            entry.Property("IsDeleted").CurrentValue = true;
        }

        public virtual void DeleteRange(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public virtual void Dispose()
        {
            
        }

        public async virtual Task<TEntity> FindAsync(TId id) => await dbSet.FindAsync(id);

        public async virtual Task<TEntity> FindAsNoTrackingAsync(TId id)
        {
            return await dbSet
                            .AsNoTracking()
                            .FirstOrDefaultAsync(m => m.Id.Equals(id));
        }
        public async virtual Task<TEntity> FindIgnoreQueryFilterAsync(TId id)
        {
            return await dbSet
                            .IgnoreQueryFilters()
                            .FirstOrDefaultAsync(m => m.Id.Equals(id));
        }


        public virtual IEnumerable<TEntity> GetAll() => dbSet;
        public virtual IEnumerable<TEntity> GetAllIgnoreQueryFilter() => dbSet.IgnoreQueryFilters();

        public virtual IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> filter = null,
                                                                  Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                                  string includeProperties = "",
                                                                  bool ignoreQueryFilter = false)
        {
            IQueryable<TEntity> query = dbSet;

            if (ignoreQueryFilter)
            {
                query = query.IgnoreQueryFilters();
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return orderBy != null ? orderBy(query) : query;
        }

        public async Task<int> GetCountAsync() => await dbSet.CountAsync();
        public virtual IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters) => dbSet.FromSqlRaw(query, parameters);
        public async virtual Task AddAsync(TEntity entity) => await dbSet.AddAsync(entity);
        public async virtual Task AddRangeAsync(IEnumerable<TEntity> entities) => await dbSet.AddRangeAsync(entities);
        public virtual void Update(TEntity entityToUpdate) => dbSet.Update(entityToUpdate);
        public virtual void UpdateRange(IEnumerable<TEntity> entityList) => dbSet.UpdateRange(entityList);

    }
}

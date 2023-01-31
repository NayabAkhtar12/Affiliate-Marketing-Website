using AM.Data.Models;
using System;
using System.Linq.Expressions;

namespace AM.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IList<TEntity> GetAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>>Predicate);

        void save(TEntity entity);

        void Delete(TEntity entity);
    }
}
using AM.Data.Interfaces;
using AM.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AM.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AffiliateMarketingDbContext _context;

        protected readonly DbSet<TEntity> _dbset;

        public Repository(AffiliateMarketingDbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();

        }

        public IList<TEntity> GetAll()
        {
            return _dbset.ToList();     
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> Predicate)
        {
            return _dbset.Where(Predicate);
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
            { return; }

            var dbEntity = _context.Entry(entity);
            if(dbEntity.State!=EntityState.Deleted)
            {
                dbEntity.State = EntityState.Deleted;

            }
            else
            {
                _dbset.Attach(entity);
                _dbset.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void save(TEntity entity)
        {
        if(entity.Id>0)
            {
                _dbset.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        else
            {
                _dbset.Add(entity);
                _context.SaveChanges();
            }

        }
    }
}

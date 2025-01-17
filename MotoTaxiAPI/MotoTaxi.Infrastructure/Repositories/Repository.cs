using Microsoft.EntityFrameworkCore;
using MotoTaxi.Domain.Core;
using MotoTaxi.Infrastructure.Data;

namespace MotoTaxi.Infrastructure.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : Entity<TKey>
    {
        protected readonly ApplicationDataContext _dataContext;
        protected readonly DbSet<TEntity> _entity;

        public Repository(ApplicationDataContext context)
        {
            _dataContext = context ?? throw new ArgumentNullException(nameof(context));
            _entity = _dataContext.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            _entity.Add(obj);
        }

        public virtual TEntity GetById(TKey id)
        {
            return _entity.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _entity;
        }
        public virtual void Update(TEntity obj)
        {
            _entity.Update(obj);
        }

        public void Dispose()
        {
            _dataContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public Task<TEntity> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            try
            {
                var item = _dataContext.SaveChanges();
                return item;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"DbUpdateException: {ex.Message}");
                Console.WriteLine($"InnerException: {ex.InnerException?.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }
    }
}

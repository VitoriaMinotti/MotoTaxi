namespace MotoTaxi.Domain.Core
{
    public interface IRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        TEntity GetById(TKey id);
        IQueryable<TEntity> GetAll();
        Task<TEntity> SaveChangesAsync();
        int SaveChanges();
    }
}

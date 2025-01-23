namespace MotoTaxi.Domain.Core
{
    public interface IEntity
    {
    }

    public abstract class Entity<TKey>
    {
        public TKey Id
        {
            get; protected set;
        }
    }
}

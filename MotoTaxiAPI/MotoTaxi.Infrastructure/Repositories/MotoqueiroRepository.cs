using Microsoft.EntityFrameworkCore;
using MotoTaxi.Domain.Models.MotoqueiroAggregate;
using MotoTaxi.Infrastructure.Data;


namespace MotoTaxi.Infrastructure.Repositories
{
    public class MotoqueiroRepository : Repository<Motoqueiro, Guid>, IMotoqueiroRepository
    {
        public MotoqueiroRepository(ApplicationDataContext context): base (context)
        {
        }

        public override Motoqueiro GetById(Guid id)
        {
            return _entity
                .Include( x  => x.Endereco )
                .FirstOrDefault(x => x.Id == id);

        }
    }
}

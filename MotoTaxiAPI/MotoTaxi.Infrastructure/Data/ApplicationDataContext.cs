
using Microsoft.EntityFrameworkCore;
using MotoTaxi.Domain.Models.MotoqueiroAggregate;

namespace MotoTaxi.Infrastructure.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { }

        public DbSet<Motoqueiro> Motoqueiros { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotoTaxi.Domain.Models.MotoqueiroAggregate;

namespace MotoTaxi.Infrastructure.Data.Configurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(e => e.Id)
               .IsRequired()
            .ValueGeneratedNever();

            builder.Property(e => e.Rua)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(70);

            builder.Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}

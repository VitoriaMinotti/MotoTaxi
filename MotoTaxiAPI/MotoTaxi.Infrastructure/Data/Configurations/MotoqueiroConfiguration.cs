using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotoTaxi.Domain.Core;
using MotoTaxi.Domain.Models.MotoqueiroAggregate;

namespace MotoTaxi.Infrastructure.Data.Configurations
{
    public class MotoqueiroConfiguration : IEntityTypeConfiguration<Motoqueiro>
    {

        public void Configure(EntityTypeBuilder<Motoqueiro> builder)
        {
            builder.Property(e => e.Id)
                .IsRequired()
            .ValueGeneratedNever();

            builder.Property(e => e.Nome)
                .IsRequired()
            .HasMaxLength(200);

            builder.Property(e => e.Apelido)
                .HasMaxLength(50);

            builder.Property(e => e.DataNascimento)
            .IsRequired();

            builder.Property(e => e.Telefone)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.TelefoneEmergencia)
                .HasMaxLength(20);

            builder.Property(e => e.Rg)
                .HasMaxLength(20);

            builder.Property(e => e.Cpf)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(e => e.DataVencimentoCnh)
                .IsRequired();

            builder.Property(e => e.EstadoCivil)
                .HasMaxLength(20);

            builder.Property(e => e.DataContratacao)
                .IsRequired();

            builder.Property(e => e.Ativo)
                .IsRequired();

            builder.Property(e => e.DataDesligamento)
                .IsRequired(false);
        }
    }
}

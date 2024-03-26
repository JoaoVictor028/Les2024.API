using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoLes2024.Models;

namespace ProjetoLes2024.Data.Configs
{
    public class CidadeConfig : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("cid_id").ValueGeneratedOnAdd();
            builder.Property(c => c.Nome).HasColumnName("cid_nome");
            builder.Property(c => c.EstadoId).HasColumnName("cid_est_id");

            builder
                .HasOne(c => c.Estado)
                .WithMany()
                .HasForeignKey(c => c.EstadoId)
                .HasConstraintName("FK_cid_est_id");
        }
    }
}

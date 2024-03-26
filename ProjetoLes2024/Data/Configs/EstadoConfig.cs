using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoLes2024.Models;

namespace ProjetoLes2024.Data.Configs
{
    public class EstadoConfig : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("est_id").ValueGeneratedOnAdd();
            builder.Property(e => e.Nome).HasColumnName("est_nome");
            builder.Property(e => e.Sigla).HasColumnName("est_sigla");
        }
    }

}

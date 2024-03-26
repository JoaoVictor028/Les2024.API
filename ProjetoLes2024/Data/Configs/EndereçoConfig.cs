using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoLes2024.Models;

namespace ProjetoLes2024.Data.Configs
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("end_id").ValueGeneratedOnAdd();
            builder.Property(e => e.Logradouro).HasColumnName("end_logradouro");
            builder.Property(e => e.Numero).HasColumnName("end_numero");
            builder.Property(e => e.Cep).HasColumnName("end_cep");
            builder.Property(e => e.CidadeId).HasColumnName("end_cid_id");

            builder
            .HasOne(e => e.Cidade)
            .WithMany()
            .HasForeignKey(e => e.CidadeId)
            .HasConstraintName("FK_end_cidade_id");
        }
    }
}

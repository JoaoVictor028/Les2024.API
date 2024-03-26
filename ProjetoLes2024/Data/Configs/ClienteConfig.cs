using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoLes2024.Models;

namespace ProjetoLes2024.Data.Configs
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("cli_id").ValueGeneratedOnAdd();
            builder.Property(p=> p.Email).HasColumnName("cli_email");
            builder.Property(p => p.EnderecoId).HasColumnName("end_cli_id");

            builder
            .HasOne(p => p.Endereco)
            .WithMany()
            .HasForeignKey(p => p.EnderecoId)
            .HasConstraintName("FK_end_cli_id");

        }
    }
}

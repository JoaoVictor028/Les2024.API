﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoLes2024.Data.Contextos;

#nullable disable

namespace ProjetoLes2024.Migrations
{
    [DbContext(typeof(ClienteContext))]
    partial class ClienteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ProjetoLes2024.Models.Cidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("cid_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("EstadoId")
                        .HasColumnType("bigint")
                        .HasColumnName("cid_est_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("cid_nome");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("ProjetoLes2024.Models.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("cli_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("cli_email");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint")
                        .HasColumnName("end_cli_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProjetoLes2024.Models.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("end_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("end_cep");

                    b.Property<long>("CidadeId")
                        .HasColumnType("bigint")
                        .HasColumnName("end_cid_id");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("end_logradouro");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("end_numero");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ProjetoLes2024.Models.Estado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("est_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("est_nome");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("est_sigla");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("ProjetoLes2024.Models.Cidade", b =>
                {
                    b.HasOne("ProjetoLes2024.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .IsRequired()
                        .HasConstraintName("FK_cid_est_id");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("ProjetoLes2024.Models.Cliente", b =>
                {
                    b.HasOne("ProjetoLes2024.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .IsRequired()
                        .HasConstraintName("FK_end_cli_id");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("ProjetoLes2024.Models.Endereco", b =>
                {
                    b.HasOne("ProjetoLes2024.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .IsRequired()
                        .HasConstraintName("FK_end_cidade_id");

                    b.Navigation("Cidade");
                });
#pragma warning restore 612, 618
        }
    }
}

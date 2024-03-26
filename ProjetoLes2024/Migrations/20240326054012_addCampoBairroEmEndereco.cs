using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLes2024.Migrations
{
    /// <inheritdoc />
    public partial class addCampoBairroEmEndereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Enderecos");
        }
    }
}

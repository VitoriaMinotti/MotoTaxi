using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotoTaxi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class endereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Motoqueiros");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Motoqueiros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcInformatique.Data.Migrations
{
    /// <inheritdoc />
    public partial class f2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idUtilisateur",
                table: "Equipements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "idUtilisateur",
                table: "Equipements",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

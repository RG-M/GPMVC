using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcInformatique.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateAppel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "App_Id",
                table: "Appels",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Appels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Equipement_Id",
                table: "Appels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Utilisateur_Id",
                table: "Appels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appels_Equipement_Id",
                table: "Appels",
                column: "Equipement_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Appels_Utilisateur_Id",
                table: "Appels",
                column: "Utilisateur_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appels_AspNetUsers_Utilisateur_Id",
                table: "Appels",
                column: "Utilisateur_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appels_Equipements_Equipement_Id",
                table: "Appels",
                column: "Equipement_Id",
                principalTable: "Equipements",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appels_AspNetUsers_Utilisateur_Id",
                table: "Appels");

            migrationBuilder.DropForeignKey(
                name: "FK_Appels_Equipements_Equipement_Id",
                table: "Appels");

            migrationBuilder.DropIndex(
                name: "IX_Appels_Equipement_Id",
                table: "Appels");

            migrationBuilder.DropIndex(
                name: "IX_Appels_Utilisateur_Id",
                table: "Appels");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Appels");

            migrationBuilder.DropColumn(
                name: "Equipement_Id",
                table: "Appels");

            migrationBuilder.DropColumn(
                name: "Utilisateur_Id",
                table: "Appels");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Appels",
                newName: "App_Id");
        }
    }
}

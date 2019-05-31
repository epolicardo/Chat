using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Migrations
{
    public partial class Modificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Salas_IdSalaId",
                table: "Mensajes");

            migrationBuilder.RenameColumn(
                name: "IdSalaId",
                table: "Mensajes",
                newName: "SalaId");

            migrationBuilder.RenameIndex(
                name: "IX_Mensajes_IdSalaId",
                table: "Mensajes",
                newName: "IX_Mensajes_SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Salas_SalaId",
                table: "Mensajes",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Salas_SalaId",
                table: "Mensajes");

            migrationBuilder.RenameColumn(
                name: "SalaId",
                table: "Mensajes",
                newName: "IdSalaId");

            migrationBuilder.RenameIndex(
                name: "IX_Mensajes_SalaId",
                table: "Mensajes",
                newName: "IX_Mensajes_IdSalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Salas_IdSalaId",
                table: "Mensajes",
                column: "IdSalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

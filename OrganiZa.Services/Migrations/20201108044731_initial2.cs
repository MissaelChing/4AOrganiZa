using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganiZa.Services.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Colegiatura",
                table: "Pagos",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "IdE",
                table: "Pagos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagosModelsId",
                table: "Escuela",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_PagosModelsId",
                table: "Escuela",
                column: "PagosModelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Escuela_Pagos_PagosModelsId",
                table: "Escuela",
                column: "PagosModelsId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Escuela_Pagos_PagosModelsId",
                table: "Escuela");

            migrationBuilder.DropIndex(
                name: "IX_Escuela_PagosModelsId",
                table: "Escuela");

            migrationBuilder.DropColumn(
                name: "Colegiatura",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "IdE",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "PagosModelsId",
                table: "Escuela");
        }
    }
}

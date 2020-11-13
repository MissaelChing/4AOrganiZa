using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganiZa.Services.Migrations
{
    public partial class nuevo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalendarioModelsId",
                table: "Tutor",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CalendarioModelsId",
                table: "Pagos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NReferencia",
                table: "Escuela",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Alumno",
                table: "Calendario",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Colegiatura",
                table: "Calendario",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "IdP",
                table: "Calendario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdT",
                table: "Calendario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "statusdepago",
                table: "Calendario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_CalendarioModelsId",
                table: "Tutor",
                column: "CalendarioModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_CalendarioModelsId",
                table: "Pagos",
                column: "CalendarioModelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Calendario_CalendarioModelsId",
                table: "Pagos",
                column: "CalendarioModelsId",
                principalTable: "Calendario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutor_Calendario_CalendarioModelsId",
                table: "Tutor",
                column: "CalendarioModelsId",
                principalTable: "Calendario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Calendario_CalendarioModelsId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutor_Calendario_CalendarioModelsId",
                table: "Tutor");

            migrationBuilder.DropIndex(
                name: "IX_Tutor_CalendarioModelsId",
                table: "Tutor");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_CalendarioModelsId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "CalendarioModelsId",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "CalendarioModelsId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "NReferencia",
                table: "Escuela");

            migrationBuilder.DropColumn(
                name: "Alumno",
                table: "Calendario");

            migrationBuilder.DropColumn(
                name: "Colegiatura",
                table: "Calendario");

            migrationBuilder.DropColumn(
                name: "IdP",
                table: "Calendario");

            migrationBuilder.DropColumn(
                name: "IdT",
                table: "Calendario");

            migrationBuilder.DropColumn(
                name: "statusdepago",
                table: "Calendario");
        }
    }
}

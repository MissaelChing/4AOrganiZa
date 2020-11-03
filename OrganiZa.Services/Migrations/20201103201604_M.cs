using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganiZa.Services.Migrations
{
    public partial class M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EscuelaModelsId",
                table: "Tutor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreE",
                table: "Tutor",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Telefono",
                table: "Tutor",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "AdministradorModelsId",
                table: "Escuela",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CalendarioModelsId",
                table: "Escuela",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Colegiatura",
                table: "Escuela",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "IdT",
                table: "Escuela",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NombreAd",
                table: "Escuela",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdE",
                table: "Administrador",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Calendario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    IdE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_EscuelaModelsId",
                table: "Tutor",
                column: "EscuelaModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_AdministradorModelsId",
                table: "Escuela",
                column: "AdministradorModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_CalendarioModelsId",
                table: "Escuela",
                column: "CalendarioModelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Escuela_Administrador_AdministradorModelsId",
                table: "Escuela",
                column: "AdministradorModelsId",
                principalTable: "Administrador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Escuela_Calendario_CalendarioModelsId",
                table: "Escuela",
                column: "CalendarioModelsId",
                principalTable: "Calendario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutor_Escuela_EscuelaModelsId",
                table: "Tutor",
                column: "EscuelaModelsId",
                principalTable: "Escuela",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Escuela_Administrador_AdministradorModelsId",
                table: "Escuela");

            migrationBuilder.DropForeignKey(
                name: "FK_Escuela_Calendario_CalendarioModelsId",
                table: "Escuela");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutor_Escuela_EscuelaModelsId",
                table: "Tutor");

            migrationBuilder.DropTable(
                name: "Calendario");

            migrationBuilder.DropIndex(
                name: "IX_Tutor_EscuelaModelsId",
                table: "Tutor");

            migrationBuilder.DropIndex(
                name: "IX_Escuela_AdministradorModelsId",
                table: "Escuela");

            migrationBuilder.DropIndex(
                name: "IX_Escuela_CalendarioModelsId",
                table: "Escuela");

            migrationBuilder.DropColumn(
                name: "EscuelaModelsId",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "NombreE",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "AdministradorModelsId",
                table: "Escuela");

            migrationBuilder.DropColumn(
                name: "CalendarioModelsId",
                table: "Escuela");

            migrationBuilder.DropColumn(
                name: "Colegiatura",
                table: "Escuela");

            migrationBuilder.DropColumn(
                name: "IdT",
                table: "Escuela");

            migrationBuilder.DropColumn(
                name: "NombreAd",
                table: "Escuela");

            migrationBuilder.DropColumn(
                name: "IdE",
                table: "Administrador");
        }
    }
}

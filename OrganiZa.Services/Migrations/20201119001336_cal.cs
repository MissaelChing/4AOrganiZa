using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganiZa.Services.Migrations
{
    public partial class cal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    MesPago = table.Column<string>(nullable: true),
                    ModoP = table.Column<string>(nullable: true),
                    Colegiatura = table.Column<double>(nullable: false),
                    statusdepago = table.Column<string>(nullable: true),
                    Alumno = table.Column<string>(nullable: true),
                    IdE = table.Column<int>(nullable: false),
                    IdP = table.Column<int>(nullable: false),
                    IdT = table.Column<int>(nullable: false),
                    IdA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Usuario = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    Rolusuario = table.Column<string>(nullable: true),
                    IdT = table.Column<int>(nullable: false),
                    IdA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Alumno = table.Column<string>(nullable: true),
                    Fichapago = table.Column<string>(nullable: true),
                    NombreT = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Colegiatura = table.Column<double>(nullable: false),
                    Mespagado = table.Column<string>(nullable: true),
                    voucher = table.Column<byte[]>(nullable: true),
                    TutorId = table.Column<int>(nullable: false),
                    IdE = table.Column<int>(nullable: false),
                    statusdepago = table.Column<string>(nullable: true),
                    CalendarioModelsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_Calendario_CalendarioModelsId",
                        column: x => x.CalendarioModelsId,
                        principalTable: "Calendario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Escuela",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    NombreE = table.Column<string>(nullable: true),
                    NombreAd = table.Column<string>(nullable: true),
                    ModoP = table.Column<string>(nullable: true),
                    NReferencia = table.Column<int>(nullable: false),
                    Colegiatura = table.Column<double>(nullable: false),
                    IdA = table.Column<int>(nullable: false),
                    CalendarioModelsId = table.Column<int>(nullable: true),
                    PagosModelsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escuela", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Escuela_Calendario_CalendarioModelsId",
                        column: x => x.CalendarioModelsId,
                        principalTable: "Calendario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escuela_Pagos_PagosModelsId",
                        column: x => x.PagosModelsId,
                        principalTable: "Pagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Rolusuario = table.Column<string>(nullable: true),
                    NombreAd = table.Column<string>(nullable: true),
                    UsersId = table.Column<int>(nullable: true),
                    EscuelaModelsId = table.Column<int>(nullable: true),
                    CalendarioModelsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administrador_Calendario_CalendarioModelsId",
                        column: x => x.CalendarioModelsId,
                        principalTable: "Calendario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Administrador_Escuela_EscuelaModelsId",
                        column: x => x.EscuelaModelsId,
                        principalTable: "Escuela",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Administrador_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Rolusuario = table.Column<string>(nullable: true),
                    Alumno = table.Column<string>(nullable: true),
                    NombreT = table.Column<string>(nullable: true),
                    Telefono = table.Column<double>(nullable: false),
                    NombreE = table.Column<string>(nullable: true),
                    FichaPago = table.Column<string>(nullable: true),
                    IdE = table.Column<int>(nullable: false),
                    UsersId = table.Column<int>(nullable: true),
                    EscuelaModelsId = table.Column<int>(nullable: true),
                    CalendarioModelsId = table.Column<int>(nullable: true),
                    PagosModelsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutor_Calendario_CalendarioModelsId",
                        column: x => x.CalendarioModelsId,
                        principalTable: "Calendario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tutor_Escuela_EscuelaModelsId",
                        column: x => x.EscuelaModelsId,
                        principalTable: "Escuela",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tutor_Pagos_PagosModelsId",
                        column: x => x.PagosModelsId,
                        principalTable: "Pagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tutor_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrador_CalendarioModelsId",
                table: "Administrador",
                column: "CalendarioModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrador_EscuelaModelsId",
                table: "Administrador",
                column: "EscuelaModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrador_UsersId",
                table: "Administrador",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_CalendarioModelsId",
                table: "Escuela",
                column: "CalendarioModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_PagosModelsId",
                table: "Escuela",
                column: "PagosModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_CalendarioModelsId",
                table: "Pagos",
                column: "CalendarioModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_CalendarioModelsId",
                table: "Tutor",
                column: "CalendarioModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_EscuelaModelsId",
                table: "Tutor",
                column: "EscuelaModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_PagosModelsId",
                table: "Tutor",
                column: "PagosModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_UsersId",
                table: "Tutor",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "Escuela");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Calendario");
        }
    }
}

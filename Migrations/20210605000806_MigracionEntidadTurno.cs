using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turnos.Migrations
{
    public partial class MigracionEntidadTurno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    IdTurno = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", unicode: false, nullable: false),
                    IdMedico = table.Column<int>(type: "int", unicode: false, nullable: false),
                    FechaHoraInicio = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false),
                    FechaHoraFin = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.IdTurno);
                    table.ForeignKey(
                        name: "FK_Turno_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turno_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turno_IdMedico",
                table: "Turno",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_IdPaciente",
                table: "Turno",
                column: "IdPaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turno");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaClinicaWeb.Core.Migrations
{
    public partial class Relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HabitacionId",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedicoId",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_HabitacionId",
                table: "Pacientes",
                column: "HabitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_MedicoId",
                table: "Pacientes",
                column: "MedicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Habitaciones_HabitacionId",
                table: "Pacientes",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Medicos_MedicoId",
                table: "Pacientes",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Habitaciones_HabitacionId",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Medicos_MedicoId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_HabitacionId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_MedicoId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HabitacionId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "MedicoId",
                table: "Pacientes");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_gestion_solicitudes.Migrations
{
    /// <inheritdoc />
    public partial class fechaResolucion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaResolucion",
                table: "T_Solicitud",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaResolucion",
                table: "T_Solicitud");
        }
    }
}

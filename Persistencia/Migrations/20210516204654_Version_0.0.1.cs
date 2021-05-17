using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Version_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comercio",
                columns: table => new
                {
                    id_comercio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    non_comercio = table.Column<string>(nullable: true),
                    num_aforo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comercio", x => x.id_comercio);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    id_estado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.id_estado);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    id_servicio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_servicio = table.Column<string>(nullable: true),
                    hora_apertura = table.Column<TimeSpan>(nullable: false),
                    hora_cierre = table.Column<TimeSpan>(nullable: false),
                    id_comercio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.id_servicio);
                    table.ForeignKey(
                        name: "FK_Servicios_Comercio_id_comercio",
                        column: x => x.id_comercio,
                        principalTable: "Comercio",
                        principalColumn: "id_comercio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    id_turno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_turno = table.Column<DateTime>(nullable: false),
                    hora_inicio = table.Column<DateTime>(nullable: false),
                    hora_fin = table.Column<DateTime>(nullable: false),
                    id_estado = table.Column<int>(nullable: false),
                    id_servicio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.id_turno);
                    table.ForeignKey(
                        name: "FK_Turno_Estado_id_estado",
                        column: x => x.id_estado,
                        principalTable: "Estado",
                        principalColumn: "id_estado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turno_Servicios_id_servicio",
                        column: x => x.id_servicio,
                        principalTable: "Servicios",
                        principalColumn: "id_servicio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_id_comercio",
                table: "Servicios",
                column: "id_comercio");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_id_estado",
                table: "Turno",
                column: "id_estado");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_id_servicio",
                table: "Turno",
                column: "id_servicio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turno");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Comercio");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace taller_proyecto_aws.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "participantes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    apellido = table.Column<string>(type: "text", nullable: true),
                    edad = table.Column<string>(type: "text", nullable: true),
                    genero = table.Column<string>(type: "text", nullable: true),
                    ciudad = table.Column<string>(type: "text", nullable: true),
                    tiempo = table.Column<double>(type: "double precision", nullable: false),
                    distancia = table.Column<double>(type: "double precision", nullable: false),
                    ritmo = table.Column<double>(type: "double precision", nullable: false),
                    lugar = table.Column<string>(type: "text", nullable: true),
                    rol = table.Column<string>(type: "text", nullable: true),
                    correo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_participantes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "participantes");
        }
    }
}

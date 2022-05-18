using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcesionariaMVC1.Migrations
{
    public partial class migracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    anio = table.Column<int>(type: "int", nullable: false),
                    kilometros = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehiculo");
        }
    }
}

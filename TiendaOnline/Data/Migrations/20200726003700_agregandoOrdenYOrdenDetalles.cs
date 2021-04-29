using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaOnline.Data.Migrations
{
    public partial class agregandoOrdenYOrdenDetalles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    numeroOrden = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    numeroTel = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Lat = table.Column<string>(nullable: false),
                    Long = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrdenDetalles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrdenID = table.Column<int>(nullable: false),
                    ProductoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDetalles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrdenDetalles_Orden_OrdenID",
                        column: x => x.OrdenID,
                        principalTable: "Orden",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenDetalles_Productos_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Productos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDetalles_OrdenID",
                table: "OrdenDetalles",
                column: "OrdenID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDetalles_ProductoID",
                table: "OrdenDetalles",
                column: "ProductoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenDetalles");

            migrationBuilder.DropTable(
                name: "Orden");
        }
    }
}

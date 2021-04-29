using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaOnline.Data.Migrations
{
    public partial class cambiandoRequiredFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SliderFoto",
                table: "Slider",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SliderFoto",
                table: "Slider",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

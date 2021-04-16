using Microsoft.EntityFrameworkCore.Migrations;

namespace VendaWebMvc.Migrations
{
    public partial class Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "RegistroVendas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "RegistroVendas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

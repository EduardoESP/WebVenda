using Microsoft.EntityFrameworkCore.Migrations;

namespace VendaWebMvc.Migrations
{
    public partial class formularios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroVendas_Vendedor_VendedorId",
                table: "RegistroVendas");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "RegistroVendas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Departamento",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroVendas_Vendedor_VendedorId",
                table: "RegistroVendas",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroVendas_Vendedor_VendedorId",
                table: "RegistroVendas");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "RegistroVendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Departamento",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroVendas_Vendedor_VendedorId",
                table: "RegistroVendas",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressAndPhone_Persons_PersonID",
                table: "AddressAndPhone");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "AddressAndPhone",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressAndPhone_Persons_PersonID",
                table: "AddressAndPhone",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressAndPhone_Persons_PersonID",
                table: "AddressAndPhone");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "AddressAndPhone",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressAndPhone_Persons_PersonID",
                table: "AddressAndPhone",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

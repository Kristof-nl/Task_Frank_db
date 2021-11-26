using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Frank_db.Migrations
{
    public partial class AddAddressIdToAddressesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Addresses",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Addresses",
                type: "varchar(25)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Town");
        }
    }
}

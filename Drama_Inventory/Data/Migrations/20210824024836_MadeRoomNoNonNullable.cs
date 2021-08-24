using Microsoft.EntityFrameworkCore.Migrations;

namespace Drama_Inventory.Data.Migrations
{
    public partial class MadeRoomNoNonNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoomNo",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoomNo",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}

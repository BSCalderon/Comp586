using Microsoft.EntityFrameworkCore.Migrations;

namespace LittleListApp.Data.Migrations
{
    public partial class AddItemUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDone",
                table: "Items",
                newName: "IsDone");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "IsDone",
                table: "Items",
                newName: "isDone");
        }
    }
}

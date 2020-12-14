using Microsoft.EntityFrameworkCore.Migrations;

namespace LittleListApp.Data.Migrations
{
    public partial class AddItemsCreatedCheckMark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Checked",
                table: "Items",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Checked",
                table: "Items");
        }
    }
}

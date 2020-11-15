using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectWorkspace.Migrations
{
    public partial class PopcornPoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PaidWithPopcornPoints",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PopcornPoints",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaidWithPopcornPoints",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "PopcornPoints",
                table: "Order");
        }
    }
}

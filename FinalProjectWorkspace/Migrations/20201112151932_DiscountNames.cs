using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectWorkspace.Migrations
{
    public partial class DiscountNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountName",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountName",
                table: "Ticket");
        }
    }
}

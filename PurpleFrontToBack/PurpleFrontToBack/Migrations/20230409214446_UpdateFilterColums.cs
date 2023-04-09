using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleFrontToBack.Migrations
{
    public partial class UpdateFilterColums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Filter",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Filter",
                table: "Categories");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleFrontToBack.Migrations
{
    public partial class CreateTablesNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SliderImgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderImgs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SliderInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderImgId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SliderInfos_SliderImgs_SliderImgId",
                        column: x => x.SliderImgId,
                        principalTable: "SliderImgs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SliderInfos_SliderImgId",
                table: "SliderInfos",
                column: "SliderImgId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SliderInfos");

            migrationBuilder.DropTable(
                name: "SliderImgs");
        }
    }
}

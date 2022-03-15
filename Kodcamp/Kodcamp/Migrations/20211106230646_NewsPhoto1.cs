using Microsoft.EntityFrameworkCore.Migrations;

namespace Kodcamp.Migrations
{
    public partial class NewsPhoto1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiyCategories");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrlDetail1",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrlDetail2",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrlDetail3",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrlDetail1",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ImageUrlDetail2",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ImageUrlDetail3",
                table: "News");

            migrationBuilder.CreateTable(
                name: "ActivitiyCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiyCategories", x => x.Id);
                });
        }
    }
}

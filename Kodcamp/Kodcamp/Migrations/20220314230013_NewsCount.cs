using Microsoft.EntityFrameworkCore.Migrations;

namespace Kodcamp.Migrations
{
    public partial class NewsCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoderCount",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LikeCount",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmileCount",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnlikeCount",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoderCount",
                table: "News");

            migrationBuilder.DropColumn(
                name: "LikeCount",
                table: "News");

            migrationBuilder.DropColumn(
                name: "SmileCount",
                table: "News");

            migrationBuilder.DropColumn(
                name: "UnlikeCount",
                table: "News");
        }
    }
}

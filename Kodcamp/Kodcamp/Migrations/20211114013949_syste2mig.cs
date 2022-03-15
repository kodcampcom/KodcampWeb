using Microsoft.EntityFrameworkCore.Migrations;

namespace Kodcamp.Migrations
{
    public partial class syste2mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type2",
                table: "SystemInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type2",
                table: "SystemInfo");
        }
    }
}

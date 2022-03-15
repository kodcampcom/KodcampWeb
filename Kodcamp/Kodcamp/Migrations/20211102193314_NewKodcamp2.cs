using Microsoft.EntityFrameworkCore.Migrations;

namespace Kodcamp.Migrations
{
    public partial class NewKodcamp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewSystemTypem",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewSystemTypem",
                table: "Activities");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Default2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bachelor",
                table: "mySkills");

            migrationBuilder.DropColumn(
                name: "Html",
                table: "mySkills");

            migrationBuilder.RenameColumn(
                name: "Wordpress",
                table: "mySkills",
                newName: "percent");

            migrationBuilder.RenameColumn(
                name: "WebDev",
                table: "mySkills",
                newName: "ProgName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "percent",
                table: "mySkills",
                newName: "Wordpress");

            migrationBuilder.RenameColumn(
                name: "ProgName",
                table: "mySkills",
                newName: "WebDev");

            migrationBuilder.AddColumn<string>(
                name: "Bachelor",
                table: "mySkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Html",
                table: "mySkills",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

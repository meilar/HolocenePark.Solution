using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocenePark.Migrations
{
    public partial class FixTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genger",
                table: "Animals",
                newName: "Gender");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Animals",
                newName: "Genger");
        }
    }
}

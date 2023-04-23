using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class CreateSliderInfoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SliderInfos",
                table: "SliderInfos");

            migrationBuilder.RenameTable(
                name: "SliderInfos",
                newName: "SliderInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SliderInfo",
                table: "SliderInfo",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SliderInfo",
                table: "SliderInfo");

            migrationBuilder.RenameTable(
                name: "SliderInfo",
                newName: "SliderInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SliderInfos",
                table: "SliderInfos",
                column: "Id");
        }
    }
}

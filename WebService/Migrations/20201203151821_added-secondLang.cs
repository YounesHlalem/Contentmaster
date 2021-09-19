using Microsoft.EntityFrameworkCore.Migrations;

namespace WebService.Migrations
{
    public partial class addedsecondLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_language",
                columns: new[] { "Id", "Code", "NativeName" },
                values: new object[] { 2, "EN", "English" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_language",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

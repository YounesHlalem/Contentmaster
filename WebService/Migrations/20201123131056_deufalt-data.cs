using Microsoft.EntityFrameworkCore.Migrations;

namespace WebService.Migrations
{
    public partial class deufaltdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_language",
                columns: new[] { "Id", "Code", "NativeName" },
                values: new object[] { 1, "NL", "Nederlands" });

            migrationBuilder.InsertData(
                table: "tbl_role",
                columns: new[] { "Id", "DisplayName", "Name" },
                values: new object[] { 1, "User", "User" });

            migrationBuilder.InsertData(
                table: "tbl_role",
                columns: new[] { "Id", "DisplayName", "Name" },
                values: new object[] { 2, "Administrator", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_language",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_role",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

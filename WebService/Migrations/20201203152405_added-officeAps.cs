using Microsoft.EntityFrameworkCore.Migrations;

namespace WebService.Migrations
{
    public partial class addedofficeAps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_office_application",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Word" });

            migrationBuilder.InsertData(
                table: "tbl_office_application",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Excel" });

            migrationBuilder.InsertData(
                table: "tbl_office_application",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Powerpoint" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_office_application",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_office_application",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_office_application",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

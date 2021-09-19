using Microsoft.EntityFrameworkCore.Migrations;

namespace WebService.Migrations
{
    public partial class deufaltuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Password", "PreferredLanguageId" },
                values: new object[] { 1, "admin@local.host", "Admin", "Admin", "$2a$11$DM380SovMqqQpFqCGTPL3uAL64fG7.MRSlzb/gLrRSvJOmwhQw/Ze", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

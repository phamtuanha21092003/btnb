using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace btvn.Migrations
{
    /// <inheritdoc />
    public partial class SeedTblMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblMembers",
                columns: new[] { "MemberName", "Email", "Gender", "MemberPassword", "Phone", "YearOfBirth" },
                values: new object[,]
                {
                    { "a", "test@example.com", true, null, null, 2021 },
                    { "b", "testb@example.com", true, null, null, 2022 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblMembers",
                keyColumn: "MemberName",
                keyValue: "a");

            migrationBuilder.DeleteData(
                table: "tblMembers",
                keyColumn: "MemberName",
                keyValue: "b");
        }
    }
}

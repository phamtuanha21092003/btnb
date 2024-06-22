using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace btvn.Migrations
{
    /// <inheritdoc />
    public partial class CreateMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblMembers",
                columns: table => new
                {
                    MemberName = table.Column<string>(type: "TEXT", nullable: false),
                    YearOfBirth = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<bool>(type: "INTEGER", nullable: false),
                    MemberPassword = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMembers", x => x.MemberName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblMembers");
        }
    }
}

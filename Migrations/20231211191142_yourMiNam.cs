using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations
{
    /// <inheritdoc />
    public partial class yourMiNam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "UserManagements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserManagements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "UserManagements");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserManagements");
        }
    }
}

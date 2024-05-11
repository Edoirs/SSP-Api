using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations
{
    /// <inheritdoc />
    public partial class TaxpayerTypeId : Migration
    {
        /// <inheritdoc />
       
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
           name: "UserManagements",
           columns: table => new
           {
               Id = table.Column<int>(type: "int", nullable: false)
                   .Annotation("SqlServer:Identity", "1, 1"),
               VerificationOtp = table.Column<int>(type: "int", nullable: false),
               CompanyRin = table.Column<string>(type: "nvarchar(max)", nullable: true),
               PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
               UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
               CreatedBy = table.Column<long>(type: "bigint", nullable: false),
               ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
               ModifiedBy = table.Column<long>(type: "bigint", nullable: false),
               IsDeleted = table.Column<bool>(type: "bit", nullable: false),
               Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
               CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
               TaxpayerTypeId = table.Column<int>(type: "int", nullable: true),
               Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_UserManagements", x => x.Id);
           });
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserManagements");
        } 
    }
}

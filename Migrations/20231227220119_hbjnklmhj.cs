using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations
{
    /// <inheritdoc />
    public partial class hbjnklmhj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormH1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SURNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OTHERNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHONENUMBER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JTBTIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NATIONALITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PENSION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NHF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NHIS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LIFEASSURANCE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONSOLIDATEDRELIEFALLOWANCECRA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ANNUALTAXPAID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TOTALMONTHSPAID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Basic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherIncome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormH1s", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormH1s");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations
{
    /// <inheritdoc />
    public partial class jhjfgfgfffkl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       

            migrationBuilder.CreateTable(
                name: "FiledFormH",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiledStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxPayerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<int>(type: "int", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiledFormH", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormH1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxPayerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SURNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OTHERNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHONENUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JTBTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NATIONALITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOMEADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PENSION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NHF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NHIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LIFEASSURANCE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONSOLIDATEDRELIEFALLOWANCECRA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANNUALTAXPAID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOTALMONTHSPAID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherIncome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FiledStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormH1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormH3s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxPayerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SURNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OTHERNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHONENUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JTBTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NATIONALITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOMEADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STARTMONTH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherIncome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PENSION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NHF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NHIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LIFEASSURANCE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormH3s", x => x.Id);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "FiledFormH");

            migrationBuilder.DropTable(
                name: "FormH1s");

            migrationBuilder.DropTable(
                name: "FormH3s");
        }
    }
}

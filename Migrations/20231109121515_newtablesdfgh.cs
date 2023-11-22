using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations
{
    /// <inheritdoc />
    public partial class newtablesdfgh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    business_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    business_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    link_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    industry_sector_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    industry_subsector_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    business_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    town_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ward_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lga_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxpayer_role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxpayer_role_id = table.Column<int>(type: "int", nullable: false),
                    employees_count = table.Column<int>(type: "int", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cooperates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cac_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxpayer_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    industry_sector_id = table.Column<int>(type: "int", nullable: false),
                    corporate_logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tax_office_id = table.Column<int>(type: "int", nullable: false),
                    created_by_app_id = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    has_valid_email = table.Column<int>(type: "int", nullable: false),
                    reminder_sent_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reminder_annual_return_sent_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reminder_annual_projection_sent_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parent_taxpayer_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    economic_activity_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    company_type_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state_tin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    normalized_state_tin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lga_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooperates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bvn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxpayer_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    other_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gross_income = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nhis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nhf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    basic = table.Column<int>(type: "int", nullable: false),
                    transport = table.Column<int>(type: "int", nullable: false),
                    rent = table.Column<int>(type: "int", nullable: false),
                    cra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zip_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    other_income = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    start_month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    corporate_id = table.Column<int>(type: "int", nullable: false),
                    deleted_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    home_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    total_income = table.Column<int>(type: "int", nullable: false),
                    life_assurance = table.Column<int>(type: "int", nullable: false),
                    state_tin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    normalized_state_tin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lga_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    asset_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    business_id = table.Column<int>(type: "int", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalGovernments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lga_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalGovernments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalGovtPostalCodees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    state_id = table.Column<int>(type: "int", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postalcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalGovtPostalCodees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Cooperates");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "LocalGovernments");

            migrationBuilder.DropTable(
                name: "LocalGovtPostalCodees");
        }
    }
}

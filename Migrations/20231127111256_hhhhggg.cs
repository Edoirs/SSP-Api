using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations
{
    /// <inheritdoc />
    public partial class hhhhggg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnnualReturns",
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
                    lga_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    town_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ward_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    corporate_id = table.Column<int>(type: "int", nullable: false),
                    taxpayer_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employees_count = table.Column<int>(type: "int", nullable: false),
                    taxpayer_role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualReturns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    annual_projection_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    corporate_id = table.Column<int>(type: "int", nullable: false),
                    app_id = table.Column<int>(type: "int", nullable: false),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxpayer_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projection_year = table.Column<int>(type: "int", nullable: false),
                    file_projection_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    forwarded_to = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_forwarded = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employees_count = table.Column<int>(type: "int", nullable: false),
                    business_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    business_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    business_primary_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projections", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnualReturns");

            migrationBuilder.DropTable(
                name: "Projections");
        }
    }
}

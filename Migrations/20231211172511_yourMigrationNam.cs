using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations
{
    /// <inheritdoc />
    public partial class yourMigrationNam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "Schedules",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "Schedules",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "Schedule_Records",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Schedule_Records",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "Schedule_Records",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "Projections",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Projections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "Projections",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "LocalGovtPostalCodees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "LocalGovtPostalCodees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "LocalGovtPostalCodees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "LocalGovernments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "LocalGovernments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "LocalGovernments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "employees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "employees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "Cooperates",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Cooperates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "Cooperates",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "Businesses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Businesses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "Businesses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "AnnualReturns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "AnnualReturns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "AnnualReturns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "UserManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VerificationOtp = table.Column<int>(type: "int", nullable: false),
                    CompanyRin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Schedule_Records");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Schedule_Records");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Schedule_Records");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LocalGovtPostalCodees");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "LocalGovtPostalCodees");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LocalGovtPostalCodees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Cooperates");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Cooperates");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Cooperates");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AnnualReturns");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "AnnualReturns");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "AnnualReturns");
        }
    }
}

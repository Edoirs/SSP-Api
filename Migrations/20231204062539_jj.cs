using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations
{
    /// <inheritdoc />
    public partial class jj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AnnualReturns",
                table: "AnnualReturns");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AnnualReturns");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AnnualReturns",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Projections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "approval_status",
                table: "Projections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LocalGovtPostalCodees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LocalGovernments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "state_tin",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "state_code",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "normalized_state_tin",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "asset_id",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cooperates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Businesses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AnnualReturns",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AnnualReturns",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnnualReturns",
                table: "AnnualReturns",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Schedule_Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gross_income = table.Column<int>(type: "int", nullable: false),
                    nhis = table.Column<int>(type: "int", nullable: false),
                    nhf = table.Column<int>(type: "int", nullable: false),
                    pension = table.Column<int>(type: "int", nullable: false),
                    cra = table.Column<float>(type: "real", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    schedule_id = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_income = table.Column<int>(type: "int", nullable: false),
                    life_assurance = table.Column<int>(type: "int", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule_Records", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    forwarded_to = table.Column<int>(type: "int", nullable: false),
                    assessment_status = table.Column<int>(type: "int", nullable: false),
                    date_forwarded = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    due_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_by_app_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    corporate_id = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    business_id = table.Column<int>(type: "int", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedule_Records");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnnualReturns",
                table: "AnnualReturns");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "approval_status",
                table: "Projections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LocalGovtPostalCodees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cooperates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AnnualReturns");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AnnualReturns",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "state_tin",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "state_code",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "normalized_state_tin",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "asset_id",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "AnnualReturns",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AnnualReturns",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnnualReturns",
                table: "AnnualReturns",
                column: "Id");
        }
    }
}

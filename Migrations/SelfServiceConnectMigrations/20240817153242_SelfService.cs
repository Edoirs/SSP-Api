using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations.SelfServiceConnectMigrations
{
    /// <inheritdoc />
    public partial class SelfService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "spike");

            migrationBuilder.CreateTable(
                name: "AddPayeInputFile",
                columns: table => new
                {
                    CompanyRIN = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    BusinessRIN = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TaxYear = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Input_pk", x => new { x.CompanyRIN, x.BusinessRIN, x.TaxYear });
                });

            migrationBuilder.CreateTable(
                name: "AdminUser",
                columns: table => new
                {
                    AdminUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PayeUserTypeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Username = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Designation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreateddDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUser", x => x.AdminUserId);
                });

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
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualReturns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assessment_Item_API",
                columns: table => new
                {
                    TaxPayerID = table.Column<int>(type: "int", nullable: false),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: false),
                    TaxPayerTypeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TaxPayerRIN = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AssetID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AssetRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    ProfileReferenceNo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ProfileDescription = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AssessmentRuleID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AssessmentRuleCode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AssessmentRuleName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AssessmentItemID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemReferenceNo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AssessmentGroupID = table.Column<int>(type: "int", nullable: true),
                    AssessmentGroupName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AssessmentSubGroupID = table.Column<int>(type: "int", nullable: true),
                    AssessmentSubGroupName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueStreamName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RevenueSubStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueSubStreamName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AssessmentItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemCategoryName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AssessmentItemSubCategoryID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemSubCategoryName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AgencyID = table.Column<int>(type: "int", nullable: true),
                    AgencyName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AssessmentItemName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ComputationID = table.Column<int>(type: "int", nullable: true),
                    ComputationName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TaxBaseAmount = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Percentage = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TaxAmount = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    id = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Assessment_rule_master_api",
                schema: "spike",
                columns: table => new
                {
                    AssessmentRuleId = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    AssessmentRuleCode = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: true),
                    ProfileID = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    AssessmentRuleName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    RuleRunID = table.Column<int>(type: "int", nullable: true),
                    PaymentFrequencyID = table.Column<int>(type: "int", nullable: true),
                    AssessmentAmount = table.Column<int>(type: "int", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TaxMonth = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PaymentOptionID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Assessment_Rules",
                columns: table => new
                {
                    assess_rules_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assess_rules_create_by = table.Column<int>(type: "int", nullable: true),
                    assess_rules_create_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    rule_code = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    profile = table.Column<int>(type: "int", nullable: true),
                    assessment_rule_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    rule_run = table.Column<int>(type: "int", nullable: true),
                    frequency = table.Column<int>(type: "int", nullable: true),
                    assessment_items = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    assessment_amount = table.Column<double>(type: "float", nullable: true),
                    tax_year = table.Column<int>(type: "int", nullable: true),
                    settlement_methods = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    payment_options = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ApiId = table.Column<int>(type: "int", nullable: true),
                    AssessmentRuleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_Rules", x => x.assess_rules_id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentRules",
                columns: table => new
                {
                    AssessmentRuleID = table.Column<double>(type: "float", nullable: true),
                    AssessmentRuleCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProfileID = table.Column<double>(type: "float", nullable: true),
                    AssessmentRuleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RuleRunID = table.Column<double>(type: "float", nullable: true),
                    PaymentFrequencyID = table.Column<double>(type: "float", nullable: true),
                    AssessmentAmount = table.Column<double>(type: "float", nullable: true),
                    TaxYear = table.Column<double>(type: "float", nullable: true),
                    TaxMonth = table.Column<double>(type: "float", nullable: true),
                    PaymentOptionID = table.Column<double>(type: "float", nullable: true),
                    Active = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    assess_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assess_create_by = table.Column<int>(type: "int", nullable: false),
                    assess_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    assessment_ref = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    assessment_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    tax_payer_type = table.Column<int>(type: "int", nullable: false),
                    tax_payer_rin = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    tax_payer_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    asset_type = table.Column<int>(type: "int", nullable: false),
                    asset_rin = table.Column<int>(type: "int", nullable: false),
                    profile_ref = table.Column<int>(type: "int", nullable: false),
                    rule_code = table.Column<int>(type: "int", nullable: false),
                    assessment_rule = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    tax_year = table.Column<int>(type: "int", nullable: false),
                    assessment_amount = table.Column<double>(type: "float", nullable: false),
                    settlement_due_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    settlement_status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "DUE"),
                    settlement_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    company_tin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AssessmentStatus = table.Column<int>(type: "int", nullable: true),
                    AssessmentApprovalStatus = table.Column<int>(type: "int", nullable: true),
                    company_rin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.assess_id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentStatus",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    StatusName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Assessme__C8EE206336DECD87", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Asset_Type",
                columns: table => new
                {
                    asset_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asset_create_by = table.Column<int>(type: "int", nullable: false),
                    asset_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    asset_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    asset_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset_Type", x => x.asset_id);
                });

            migrationBuilder.CreateTable(
                name: "AssetTaxPayerDetails_API",
                columns: table => new
                {
                    TPAID = table.Column<int>(type: "int", nullable: false),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerRINNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TaxPayerEmailAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TaxPayerMobileNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerRoleID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerRoleName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AssetID = table.Column<int>(type: "int", nullable: true),
                    AssetLGA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AssetRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AssetName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BuildingUnitID = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    UnitNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ActiveText = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiId = table.Column<int>(type: "int", nullable: true),
                    AssetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Business_Category",
                columns: table => new
                {
                    bs_ct_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bs_ct_create_by = table.Column<int>(type: "int", nullable: false),
                    bs_ct_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    business_type = table.Column<int>(type: "int", nullable: false),
                    business_category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    bs_ct_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_category", x => x.bs_ct_id);
                });

            migrationBuilder.CreateTable(
                name: "Business_Operations",
                columns: table => new
                {
                    bs_op_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bs_op_create_by = table.Column<int>(type: "int", nullable: false),
                    bs_op_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    business_type = table.Column<int>(type: "int", nullable: false),
                    business_operations = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    bs_op_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_operations", x => x.bs_op_id);
                });

            migrationBuilder.CreateTable(
                name: "Business_Sectors",
                columns: table => new
                {
                    bs_sc_id = table.Column<int>(type: "int", nullable: false),
                    bs_sc_create_by = table.Column<int>(type: "int", nullable: false),
                    bs_sc_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    business_type = table.Column<int>(type: "int", nullable: false),
                    business_category = table.Column<int>(type: "int", nullable: false),
                    business_sector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    bs_sc_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_sectors", x => x.bs_sc_id);
                });

            migrationBuilder.CreateTable(
                name: "Business_Structure",
                columns: table => new
                {
                    bs_st_id = table.Column<int>(type: "int", nullable: false),
                    bs_st_create_by = table.Column<int>(type: "int", nullable: false),
                    bs_st_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    business_type = table.Column<int>(type: "int", nullable: false),
                    business_structure = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    bs_ct_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_structure", x => x.bs_st_id);
                });

            migrationBuilder.CreateTable(
                name: "Business_Sub_Sectors",
                columns: table => new
                {
                    bs_sb_id = table.Column<int>(type: "int", nullable: false),
                    bs_sb_create_by = table.Column<int>(type: "int", nullable: false),
                    bs_sb_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    business_type = table.Column<int>(type: "int", nullable: false),
                    business_category = table.Column<int>(type: "int", nullable: false),
                    business_sector = table.Column<int>(type: "int", nullable: false),
                    business_sub_sector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    bs_sb_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_sub_sectors1", x => x.bs_sb_id);
                });

            migrationBuilder.CreateTable(
                name: "Business_Type",
                columns: table => new
                {
                    Business_Type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Business_Type_create_by = table.Column<int>(type: "int", nullable: false),
                    Business_Type_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Business_Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Business_Type_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Type_Type", x => x.Business_Type_id);
                });

            migrationBuilder.CreateTable(
                name: "Businesses_API_Main",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessID = table.Column<long>(type: "bigint", nullable: false),
                    BusinessRIN = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    AssetTypeID = table.Column<int>(type: "int", nullable: false),
                    AssetTypeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessTypeID = table.Column<int>(type: "int", nullable: false),
                    BusinessTypeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    LGAID = table.Column<int>(type: "int", nullable: false),
                    LGAName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessCategoryID = table.Column<int>(type: "int", nullable: false),
                    BusinessCategoryName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessSectorID = table.Column<int>(type: "int", nullable: false),
                    BusinessSectorName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessSubSectorID = table.Column<int>(type: "int", nullable: false),
                    BusinessSubSectorName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessStructureID = table.Column<int>(type: "int", nullable: false),
                    BusinessStructureName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessOperationID = table.Column<int>(type: "int", nullable: false),
                    BusinessOperationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false),
                    SizeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContactName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BusinessNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BusinessAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ApiId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Business__3214EC072C465F80", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Businesses_Full_API",
                columns: table => new
                {
                    TaxPayerID = table.Column<int>(type: "int", nullable: false),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: false),
                    TaxPayerTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TaxPayerName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TaxPayerRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BusinessID = table.Column<long>(type: "bigint", nullable: false),
                    BusinessRIN = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    AssetTypeID = table.Column<int>(type: "int", nullable: false),
                    AssetTypeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessTypeID = table.Column<int>(type: "int", nullable: false),
                    BusinessTypeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    LGAID = table.Column<int>(type: "int", nullable: false),
                    LGAName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessCategoryID = table.Column<int>(type: "int", nullable: false),
                    BusinessCategoryName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessSectorID = table.Column<int>(type: "int", nullable: false),
                    BusinessSectorName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessSubSectorID = table.Column<int>(type: "int", nullable: false),
                    BusinessSubSectorName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessStructureID = table.Column<int>(type: "int", nullable: false),
                    BusinessStructureName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    BusinessOperationID = table.Column<int>(type: "int", nullable: false),
                    BusinessOperationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false),
                    SizeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContactName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BusinessNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BusinessAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CompanyList_API",
                columns: table => new
                {
                    CompanyListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxPayerID = table.Column<long>(type: "bigint", nullable: false),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: false),
                    TaxPayerTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TaxPayerName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    TaxPayerRIN = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MobileNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TaxOffice = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyList_API", x => x.CompanyListID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ComplianceStatus",
                columns: table => new
                {
                    ComplianceStatusId = table.Column<int>(type: "int", nullable: false),
                    ComplianceStatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
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
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooperates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Economic_Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_by = table.Column<int>(type: "int", nullable: false),
                    Create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Tax_payer_type = table.Column<int>(type: "int", nullable: false),
                    Activity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_economic_activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Eirs_User",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    designation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mobile_no = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    created_by = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_by = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    modified_on = table.Column<DateTime>(type: "datetime", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eirs_User", x => x.user_id);
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
                    state_tin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    normalized_state_tin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lga_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    asset_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    business_id = table.Column<int>(type: "int", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    employee_rin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    employee_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    jtb_tin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesMonthlyIncome",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BusinessId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Basic = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Rent = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Transport = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Ltg = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Utility = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Meal = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Others = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Nhf = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Nhis = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Pension = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    LifeAssurance = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesMonthlyIncome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesMonthlySchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BusinessId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeRin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TaxMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Rent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Transport = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Pension = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nhf = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nhis = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LifeAssurance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CRA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TFP = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AssessementStatusId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesMonthlySchedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployerMonthlyAssessment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BusinessId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployerRin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: false),
                    TaxMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAssessed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AssessmentRefNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AssessmentRefId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__3214EC07CDF6292B", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployerMonthlyAssessmentHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BusinessId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployerRin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: false),
                    TaxMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAssessed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AssessmentRefNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AssessmentRefId = table.Column<int>(type: "int", nullable: true),
                    AssCreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AssCreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__3214EC07A319086D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FormH1EmployeeUpload",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IndividalId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PENSION = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NHF = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NHIS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LIFEASSURANCE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONSOLIDATEDRELIEFALLOWANCECRA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ANNUALTAXPAID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TOTALMONTHSPAID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Rent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Transport = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    datetcreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdby = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    modifiedby = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FormH3EmployeeUpload",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxPayerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IndividualId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STARTMONTH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Transport = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PENSION = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NHF = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NHIS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LIFEASSURANCE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    datetcreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    modifiedby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Individual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SURNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OTHERNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PHONENUMBER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeRin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JTBTIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NATIONALITY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HOMEADDRESS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datetcreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    modifiedby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMAIL_ADDRESS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BVN = table.Column<int>(type: "int", nullable: true),
                    ZIP_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGA_CODE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individual_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Individuals_API",
                columns: table => new
                {
                    TaxPayerID = table.Column<long>(type: "bigint", nullable: false),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: false),
                    TaxPayerTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TaxPayerName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    TaxPayerRIN = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MobileNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContactAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TaxOffice = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals_API", x => x.TaxPayerID);
                });

            migrationBuilder.CreateTable(
                name: "Local_Government_Areas",
                columns: table => new
                {
                    lga_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lga_create_by = table.Column<int>(type: "int", nullable: false),
                    lga_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    lga_class = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    lga = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    lga_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local_Government_Areas", x => x.lga_id);
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
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
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
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalGovtPostalCodees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MST_Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Password = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ContactName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ContactNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime", nullable: true),
                    FailedLoginCount = table.Column<int>(type: "int", nullable: true),
                    IsTOManager = table.Column<bool>(type: "bit", nullable: true),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true),
                    TOManagerID = table.Column<int>(type: "int", nullable: true),
                    SignaturePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IsDirector = table.Column<bool>(type: "bit", nullable: true),
                    AgencyID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    nationality_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    country_code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    adjective = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PayeInputFile",
                columns: table => new
                {
                    EmployerName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EmployerAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EmployerRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartMonth = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Title = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Surname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EmployeeRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeTIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AnnualBasic = table.Column<double>(type: "float", nullable: true),
                    AnnualRent = table.Column<double>(type: "float", nullable: true),
                    AnnualTransport = table.Column<double>(type: "float", nullable: true),
                    AnnualUtility = table.Column<double>(type: "float", nullable: true),
                    AnnualMeal = table.Column<double>(type: "float", nullable: true),
                    OtherAllowances_Annual = table.Column<double>(type: "float", nullable: true),
                    LeaveTransport_Annual = table.Column<double>(type: "float", nullable: true),
                    AnnualGross = table.Column<double>(type: "float", nullable: true),
                    Pension = table.Column<double>(type: "float", nullable: true),
                    NHF = table.Column<double>(type: "float", nullable: true),
                    NHIS = table.Column<double>(type: "float", nullable: true),
                    Assessment_Year = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    EndMonth = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApiId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: true),
                    AssetRin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PayeOuputFile",
                columns: table => new
                {
                    EmployerName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EmployerAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    EmployerRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartMonth = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Title = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Surname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EmployeeRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EmployeeTIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AnnualGross = table.Column<double>(type: "float", nullable: true),
                    CRA = table.Column<double>(type: "float", nullable: true),
                    ValidatedPension = table.Column<double>(type: "float", nullable: true),
                    ValidatedNHF = table.Column<double>(type: "float", nullable: true),
                    ValidatedNHIS = table.Column<double>(type: "float", nullable: true),
                    TaxFreePay = table.Column<double>(type: "float", nullable: true),
                    ChargeableIncome = table.Column<double>(type: "float", nullable: true),
                    AnnualTax = table.Column<double>(type: "float", nullable: true),
                    MonthlyTax = table.Column<double>(type: "float", nullable: true),
                    Assessment_Year = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EndMonth = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: true),
                    ApiId = table.Column<int>(type: "int", nullable: true),
                    AssetRin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PayeRole",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayeRole", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "PayeUserType",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayeUserType", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Pre_Asessment_Temp",
                schema: "spike",
                columns: table => new
                {
                    EmployerRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: true),
                    EmployerName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TaxYear = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    AssessmentRuleName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TaxMonth = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AssessmentItemName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TaxPayerTypeId = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeId = table.Column<int>(type: "int", nullable: true),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    AssessmentRuleID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AssessmentItemID = table.Column<int>(type: "int", nullable: true),
                    MonthlyTax = table.Column<double>(type: "float", nullable: true),
                    AssetRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
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
                    approval_status = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectionStatus",
                columns: table => new
                {
                    ProjectionStatusId = table.Column<int>(type: "int", nullable: false),
                    ProjectionStatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule_Records", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyID = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    BusinessID = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Commenter_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Commenter_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commenter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleComment", x => x.Id);
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Forwarded_To_Head_Of_Station = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    Declined = table.Column<bool>(type: "bit", nullable: false),
                    Assessed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settlement_Status",
                columns: table => new
                {
                    sett_st_id = table.Column<int>(type: "int", nullable: false),
                    sett_st_create_by = table.Column<int>(type: "int", nullable: false),
                    sett_st_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    settlement_status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    status_description = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settlement_Status", x => x.sett_st_id);
                });

            migrationBuilder.CreateTable(
                name: "Settlements",
                columns: table => new
                {
                    settle_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    settle_create_by = table.Column<int>(type: "int", nullable: false),
                    settle_create_on = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    settlement_ref = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    assessment_ref = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    assessment_amount = table.Column<double>(type: "float", nullable: false),
                    settlement_amount = table.Column<double>(type: "float", nullable: false),
                    settlement_method = table.Column<int>(type: "int", nullable: false),
                    settlement_status = table.Column<int>(type: "int", nullable: false),
                    settlement_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    settlement_notes = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settlements", x => x.settle_ID);
                });

            migrationBuilder.CreateTable(
                name: "SSPFiledFormH3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxPayerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IndividalId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PENSION = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NHF = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NHIS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LIFEASSURANCE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONSOLIDATEDRELIEFALLOWANCECRA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ANNUALTAXPAID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TOTALMONTHSPAID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Rent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Transport = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FiledStatus = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    DueDate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ComplianceStatus = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    datetcreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    modifiedby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSPFiledFormH1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SSPFiledFormH3s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxPayerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IndividalId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Transport = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PENSION = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NHF = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NHIS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LIFEASSURANCE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FiledStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    DueDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ComplianceStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datetcreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    modifiedby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tax_Offices",
                columns: table => new
                {
                    to_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    to_create_by = table.Column<int>(type: "int", nullable: false),
                    to_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    tax_office = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ta_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tax_office", x => x.to_id);
                });

            migrationBuilder.CreateTable(
                name: "Tax_Payer_Types",
                columns: table => new
                {
                    tptype_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tptype_create_by = table.Column<int>(type: "int", nullable: false),
                    tptype_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    tax_payer_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    tptype_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax_Payer_Types", x => x.tptype_id);
                });

            migrationBuilder.CreateTable(
                name: "TaxOffices",
                columns: table => new
                {
                    TaxOfficeId = table.Column<int>(type: "int", nullable: false),
                    TaxOfficeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TaxOffic__0890699DDE754B88", x => x.TaxOfficeId);
                });

            migrationBuilder.CreateTable(
                name: "TccRequest",
                columns: table => new
                {
                    EmployerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BusinessId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TccRequestYear = table.Column<int>(type: "int", nullable: true),
                    DateRequested = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestedById = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormH2PathName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TccRequestRefNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    title_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title_create_by = table.Column<int>(type: "int", nullable: false),
                    title_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    title_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.title_id);
                });

            migrationBuilder.CreateTable(
                name: "TokenManagement",
                schema: "spike",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    token = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    createdAt = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, defaultValueSql: "(getdate())"),
                    updatedAt = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TokenMan__3213E83FA0C45C2C", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    town_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    town_create_by = table.Column<int>(type: "int", nullable: false),
                    town_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    lga = table.Column<int>(type: "int", nullable: false),
                    towns = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    town_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.town_id);
                });

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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxpayerTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserManagements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    wards_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wards_create_by = table.Column<int>(type: "int", nullable: false),
                    wards_create_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    lga = table.Column<int>(type: "int", nullable: false),
                    wards = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ward_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "Ind_Assessment_Item_API",
                table: "Assessment_Item_API",
                columns: new[] { "AssetRIN", "AssessmentRuleCode" });

            migrationBuilder.CreateIndex(
                name: "ClusteredIndex-20190508-102124",
                table: "CompanyList_API",
                column: "TaxPayerID")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "Ind_CompanyList_API",
                table: "CompanyList_API",
                column: "TaxPayerRIN");

            migrationBuilder.CreateIndex(
                name: "UQ_EmployeeRin",
                table: "Individual",
                column: "EmployeeRin",
                unique: true,
                filter: "[EmployeeRin] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "Ind_PayeOuputFile",
                table: "PayeOuputFile",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20190508-102920",
                table: "PayeOuputFile",
                columns: new[] { "EmployerRIN", "EmployeeRIN", "Assessment_Year" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddPayeInputFile");

            migrationBuilder.DropTable(
                name: "AdminUser");

            migrationBuilder.DropTable(
                name: "AnnualReturns");

            migrationBuilder.DropTable(
                name: "Assessment_Item_API");

            migrationBuilder.DropTable(
                name: "Assessment_rule_master_api",
                schema: "spike");

            migrationBuilder.DropTable(
                name: "Assessment_Rules");

            migrationBuilder.DropTable(
                name: "AssessmentRules");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "AssessmentStatus");

            migrationBuilder.DropTable(
                name: "Asset_Type");

            migrationBuilder.DropTable(
                name: "AssetTaxPayerDetails_API");

            migrationBuilder.DropTable(
                name: "Business_Category");

            migrationBuilder.DropTable(
                name: "Business_Operations");

            migrationBuilder.DropTable(
                name: "Business_Sectors");

            migrationBuilder.DropTable(
                name: "Business_Structure");

            migrationBuilder.DropTable(
                name: "Business_Sub_Sectors");

            migrationBuilder.DropTable(
                name: "Business_Type");

            migrationBuilder.DropTable(
                name: "Businesses_API_Main");

            migrationBuilder.DropTable(
                name: "Businesses_Full_API");

            migrationBuilder.DropTable(
                name: "CompanyList_API");

            migrationBuilder.DropTable(
                name: "ComplianceStatus");

            migrationBuilder.DropTable(
                name: "Cooperates");

            migrationBuilder.DropTable(
                name: "Economic_Activities");

            migrationBuilder.DropTable(
                name: "Eirs_User");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "EmployeesMonthlyIncome");

            migrationBuilder.DropTable(
                name: "EmployeesMonthlySchedule");

            migrationBuilder.DropTable(
                name: "EmployerMonthlyAssessment");

            migrationBuilder.DropTable(
                name: "EmployerMonthlyAssessmentHistory");

            migrationBuilder.DropTable(
                name: "FileStatus");

            migrationBuilder.DropTable(
                name: "FormH1EmployeeUpload");

            migrationBuilder.DropTable(
                name: "FormH3EmployeeUpload");

            migrationBuilder.DropTable(
                name: "Individual");

            migrationBuilder.DropTable(
                name: "Individuals_API");

            migrationBuilder.DropTable(
                name: "Local_Government_Areas");

            migrationBuilder.DropTable(
                name: "LocalGovernments");

            migrationBuilder.DropTable(
                name: "LocalGovtPostalCodees");

            migrationBuilder.DropTable(
                name: "MST_Users");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "PayeInputFile");

            migrationBuilder.DropTable(
                name: "PayeOuputFile");

            migrationBuilder.DropTable(
                name: "PayeRole");

            migrationBuilder.DropTable(
                name: "PayeUserType");

            migrationBuilder.DropTable(
                name: "Pre_Asessment_Temp",
                schema: "spike");

            migrationBuilder.DropTable(
                name: "Projections");

            migrationBuilder.DropTable(
                name: "ProjectionStatus");

            migrationBuilder.DropTable(
                name: "Schedule_Records");

            migrationBuilder.DropTable(
                name: "ScheduleComment");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "ScheduleStatus");

            migrationBuilder.DropTable(
                name: "Settlement_Status");

            migrationBuilder.DropTable(
                name: "Settlements");

            migrationBuilder.DropTable(
                name: "SSPFiledFormH3");

            migrationBuilder.DropTable(
                name: "SSPFiledFormH3s");

            migrationBuilder.DropTable(
                name: "Tax_Offices");

            migrationBuilder.DropTable(
                name: "Tax_Payer_Types");

            migrationBuilder.DropTable(
                name: "TaxOffices");

            migrationBuilder.DropTable(
                name: "TccRequest");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "TokenManagement",
                schema: "spike");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "UserManagements");

            migrationBuilder.DropTable(
                name: "Wards");
        }
    }
}

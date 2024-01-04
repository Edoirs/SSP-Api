using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfPortalAPi.Migrations.ApiDb
{
    /// <inheritdoc />
    public partial class bhhjjkk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address_Types",
                columns: table => new
                {
                    AddressTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressTypeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address_Types", x => x.AddressTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Agency_Types",
                columns: table => new
                {
                    AgencyTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agency_Types", x => x.AgencyTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AL_Screen",
                columns: table => new
                {
                    ASLID = table.Column<int>(type: "int", nullable: false),
                    ASLName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AL_Screen", x => x.ASLID);
                });

            migrationBuilder.CreateTable(
                name: "Assessment",
                columns: table => new
                {
                    AssessmentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AssessmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    AssessmentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SettlementDueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SettlementStatusID = table.Column<int>(type: "int", nullable: true),
                    SettlementDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AssessmentNotes = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    BillPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment", x => x.AssessmentID);
                });

            migrationBuilder.CreateTable(
                name: "Assessment_Item_Category",
                columns: table => new
                {
                    AssessmentItemCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentItemCategoryName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_Item_Category", x => x.AssessmentItemCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Asset_Types",
                columns: table => new
                {
                    AssetTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetTypeName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset_Types", x => x.AssetTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Building_Completion",
                columns: table => new
                {
                    BuildingCompletionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingCompletionName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building_Completion", x => x.BuildingCompletionID);
                });

            migrationBuilder.CreateTable(
                name: "Building_Ownership",
                columns: table => new
                {
                    BuildingOwnershipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingOwnershipName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building_Ownership", x => x.BuildingOwnershipID);
                });

            migrationBuilder.CreateTable(
                name: "Building_Purpose",
                columns: table => new
                {
                    BuildingPurposeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingPurposeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building_Purpose", x => x.BuildingPurposeID);
                });

            migrationBuilder.CreateTable(
                name: "Building_Types",
                columns: table => new
                {
                    BuildingTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingTypeName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building_Types", x => x.BuildingTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Business_Types",
                columns: table => new
                {
                    BusinessTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTypeName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Types", x => x.BusinessTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Certificate_Types",
                columns: table => new
                {
                    CertificateTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateTypeName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    AgencyID = table.Column<int>(type: "int", nullable: true),
                    SEDE_PDFTemplateID = table.Column<int>(type: "int", nullable: true),
                    CNPrefix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNSerialNumber = table.Column<int>(type: "int", nullable: true),
                    CertificateTemplatePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SignMode = table.Column<int>(type: "int", nullable: true),
                    Approver1 = table.Column<int>(type: "int", nullable: true),
                    Approver2 = table.Column<int>(type: "int", nullable: true),
                    ProcessingTypeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate_Types", x => x.CertificateTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Dealer_Types",
                columns: table => new
                {
                    DealerTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerTypeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer_Types", x => x.DealerTypeID);
                });

            migrationBuilder.CreateTable(
                name: "DI_EdoGIS_MDA_Service_Items_2_2021",
                columns: table => new
                {
                    Ref = table.Column<double>(type: "float", nullable: true),
                    MDAServiceItemName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RevenueStreamName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RevenueSubStreamName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ItemCategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ItemSubCategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RevenueAgencyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TaxBaseAmount = table.Column<double>(type: "float", nullable: true),
                    ComputationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Percentage = table.Column<double>(type: "float", nullable: true),
                    TaxAmount = table.Column<double>(type: "float", nullable: true),
                    MDAServiceItemID = table.Column<int>(type: "int", nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueSubStreamID = table.Column<int>(type: "int", nullable: true),
                    ItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    ItemSubCategoryID = table.Column<int>(type: "int", nullable: true),
                    RevenueAgencyID = table.Column<int>(type: "int", nullable: true),
                    ComputationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DI_EdoGIS_MDA_Service_Items_2021",
                columns: table => new
                {
                    Ref = table.Column<double>(type: "float", nullable: true),
                    MDAServiceItemID = table.Column<int>(type: "int", nullable: true),
                    MDAServiceItemName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueStreamName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RevenueSubStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueSubStreamName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    ItemCategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ItemSubCategoryID = table.Column<int>(type: "int", nullable: true),
                    ItemSubCategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RevenueAgencyID = table.Column<int>(type: "int", nullable: true),
                    RevenueAgencyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TaxBaseAmount = table.Column<double>(type: "float", nullable: true),
                    ComputationID = table.Column<int>(type: "int", nullable: true),
                    ComputationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Percentage = table.Column<double>(type: "float", nullable: true),
                    TaxAmount = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DI_EdoGIS_MDA_Services_2_2021",
                columns: table => new
                {
                    Ref = table.Column<double>(type: "float", nullable: true),
                    MDAServiceName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RunRuleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FrequencyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TaxYear = table.Column<double>(type: "float", nullable: true),
                    PaymentOptionName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SettlementMethodNames = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SerivceAmount = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ServiceItemRef = table.Column<double>(type: "float", nullable: true),
                    MDAServiceID = table.Column<int>(type: "int", nullable: true),
                    RunRuleID = table.Column<int>(type: "int", nullable: true),
                    FrequencyID = table.Column<int>(type: "int", nullable: true),
                    PaymentOptionID = table.Column<int>(type: "int", nullable: true),
                    SettlementMethodIds = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MDAServiceItemIds = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DI_EdoGIS_MDA_Services_2021",
                columns: table => new
                {
                    Ref = table.Column<double>(type: "float", nullable: true),
                    MDAServiceID = table.Column<int>(type: "int", nullable: true),
                    MDAServiceName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RunRuleID = table.Column<int>(type: "int", nullable: true),
                    RunRuleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FrequencyID = table.Column<int>(type: "int", nullable: true),
                    FrequencyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TaxYear = table.Column<double>(type: "float", nullable: true),
                    PaymentOptionID = table.Column<int>(type: "int", nullable: true),
                    PaymentOptionName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SettlementMethodIds = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SettlementMethodNames = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SerivceAmount = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MDAServiceItemIds = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ServiceItemRef = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DI_MDA_Service_2021",
                columns: table => new
                {
                    Ref = table.Column<double>(type: "float", nullable: true),
                    MDAServiceName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RunRuleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FrequencyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TaxYear = table.Column<double>(type: "float", nullable: true),
                    PaymentOptionName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SettlementMethodNames = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SerivceAmount = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ServiceItemRef = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MDAServiceID = table.Column<int>(type: "int", nullable: true),
                    RunRuleID = table.Column<int>(type: "int", nullable: true),
                    FrequencyID = table.Column<int>(type: "int", nullable: true),
                    PaymentOptionID = table.Column<int>(type: "int", nullable: true),
                    SettlementMethodIds = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MDAServiceItemIds = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DI_MDA_Service_Items_2021",
                columns: table => new
                {
                    Ref = table.Column<double>(type: "float", nullable: true),
                    MDAServiceItemName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RevenueStreamName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RevenueSubStreamName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ItemCategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ItemSubCategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RevenueAgencyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TaxBaseAmount = table.Column<double>(type: "float", nullable: true),
                    ComputationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Percentage = table.Column<double>(type: "float", nullable: true),
                    TaxAmount = table.Column<double>(type: "float", nullable: true),
                    MDAServiceItemID = table.Column<int>(type: "int", nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueSubStreamID = table.Column<int>(type: "int", nullable: true),
                    ItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    ItemSubCategoryID = table.Column<int>(type: "int", nullable: true),
                    RevenueAgencyID = table.Column<int>(type: "int", nullable: true),
                    ComputationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Directorates",
                columns: table => new
                {
                    DirectorateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorateName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directorates", x => x.DirectorateID);
                });

            migrationBuilder.CreateTable(
                name: "EED_Individual",
                columns: table => new
                {
                    EEDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true),
                    TIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BVN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Gender = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Title = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    first_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    middle_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    last_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateOfOrigin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaritalStatus = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Occupation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Nationality = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    house_number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    street_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    city = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LGAName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ContactAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxOffice = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Notification = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EED_Individual", x => x.EEDID);
                });

            migrationBuilder.CreateTable(
                name: "EGA",
                columns: table => new
                {
                    EGAID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    AssetID = table.Column<int>(type: "int", nullable: true),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    AssessmentRuleID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemID = table.Column<int>(type: "int", nullable: true),
                    TaxBaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Result = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ErrorMessage = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BillRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGA", x => x.EGAID);
                });

            migrationBuilder.CreateTable(
                name: "ELMAH_Error",
                columns: table => new
                {
                    ErrorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Application = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Host = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Source = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    User = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StatusCode = table.Column<int>(type: "int", nullable: false),
                    TimeUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllXml = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ELMAH_Error", x => x.ErrorId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "EM_Bank",
                columns: table => new
                {
                    BankID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BankAccountNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BankDescription = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_Bank", x => x.BankID);
                });

            migrationBuilder.CreateTable(
                name: "EM_BankStatement",
                columns: table => new
                {
                    BSID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TaxMonth = table.Column<int>(type: "int", nullable: true),
                    PaymentRefNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PaymentDateTime = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CustomerName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Category = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RevenueHead = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Bank = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_BankStatement", x => x.BSID);
                });

            migrationBuilder.CreateTable(
                name: "EM_Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "EM_DataSource",
                columns: table => new
                {
                    DataSourceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSourceName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_DataSource", x => x.DataSourceID);
                });

            migrationBuilder.CreateTable(
                name: "EM_IGRClassification",
                columns: table => new
                {
                    IGRClassificationID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevenueHeadID = table.Column<int>(type: "int", nullable: true),
                    TaxMonth = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_IGRClassification", x => x.IGRClassificationID);
                });

            migrationBuilder.CreateTable(
                name: "EM_ImportLog",
                columns: table => new
                {
                    ImportLogID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    ImportFilePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ImportDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotalRecord = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_ImportLog", x => x.ImportLogID);
                });

            migrationBuilder.CreateTable(
                name: "EM_MAP_IGRClassification_Entry",
                columns: table => new
                {
                    CDSEID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IGRClassificationID = table.Column<long>(type: "bigint", nullable: true),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSEID = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_MAP_IGRClassification_Entry", x => x.CDSEID);
                });

            migrationBuilder.CreateTable(
                name: "EM_PD_Main_Authorized",
                columns: table => new
                {
                    PDMAID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TaxMonth = table.Column<int>(type: "int", nullable: true),
                    PaymentRefNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PaymentDateTime = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AssessmentReference = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ReceiptNo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CustomerName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RevenueItem = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DepositSlip = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ChequeValueDate = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Bank = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AdditionalInfo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BankBranch = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerType = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PaymentCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RetrievalRefNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AuthID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_PD_Main_Authorized", x => x.PDMAID);
                });

            migrationBuilder.CreateTable(
                name: "EM_PD_Main_Pending",
                columns: table => new
                {
                    PDMPID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TaxMonth = table.Column<int>(type: "int", nullable: true),
                    PaymentRefNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PaymentDateTime = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AssessmentReference = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ReceiptNo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CustomerName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RevenueItem = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DepositSlip = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ChequeValueDate = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Bank = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AdditionalInfo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BankBranch = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerType = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PaymentCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RetrievalRefNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AuthID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_PD_Main_Pending", x => x.PDMPID);
                });

            migrationBuilder.CreateTable(
                name: "EM_PD_MVA_Authorized",
                columns: table => new
                {
                    PDMVAID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TaxMonth = table.Column<int>(type: "int", nullable: true),
                    PaymentRefNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PaymentDateTime = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AssessmentReference = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ReceiptNo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CustomerName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RevenueItem = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DepositSlip = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ChequeValueDate = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Bank = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AdditionalInfo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BankBranch = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerType = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PaymentCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RetrievalRefNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AuthID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_PD_MVA_Authorized", x => x.PDMVAID);
                });

            migrationBuilder.CreateTable(
                name: "EM_PD_MVA_Pending",
                columns: table => new
                {
                    PDMVPID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TaxMonth = table.Column<int>(type: "int", nullable: true),
                    PaymentRefNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PaymentDateTime = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AssessmentReference = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ReceiptNo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CustomerName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RevenueItem = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DepositSlip = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ChequeValueDate = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Bank = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AdditionalInfo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BankBranch = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerType = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PaymentCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RetrievalRefNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AuthID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_PD_MVA_Pending", x => x.PDMVPID);
                });

            migrationBuilder.CreateTable(
                name: "EPLD_Business",
                columns: table => new
                {
                    EPLDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true),
                    RegisteredName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BusinessTypeID = table.Column<int>(type: "int", nullable: true),
                    BusinessTypename = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LGAID = table.Column<int>(type: "int", nullable: true),
                    LGAName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BusinessCategoryID = table.Column<int>(type: "int", nullable: true),
                    BusinessCategoryName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BusinessSectorID = table.Column<int>(type: "int", nullable: true),
                    BusinessSectorName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BusinessSubSectorID = table.Column<int>(type: "int", nullable: true),
                    BusinessSubSectorName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BusinessStructureID = table.Column<int>(type: "int", nullable: true),
                    BusinessStructureName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BusinessOperationID = table.Column<int>(type: "int", nullable: true),
                    BusinessOperationName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: true),
                    SizeName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ContactName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BusinessNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BusinessAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerRoleID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerRoleName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_GenderID = table.Column<int>(type: "int", nullable: true),
                    ind_GenderName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_TitleID = table.Column<int>(type: "int", nullable: true),
                    ind_TitleName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_first_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_middle_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_last_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_date_of_birth = table.Column<DateTime>(type: "datetime", nullable: true),
                    ind_tin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_taxofficeid = table.Column<int>(type: "int", nullable: true),
                    ind_taxofficeName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_maritalstatusid = table.Column<int>(type: "int", nullable: true),
                    ind_maritalstatusName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_nationalityid = table.Column<int>(type: "int", nullable: true),
                    ind_nationalityName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_economic_activity_id = table.Column<int>(type: "int", nullable: true),
                    ind_economic_activity_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_notificationid = table.Column<int>(type: "int", nullable: true),
                    ind_notificationName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_tin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_taxofficeid = table.Column<int>(type: "int", nullable: true),
                    comp_taxofficeName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_cac_registrationnumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_economic_activity_id = table.Column<int>(type: "int", nullable: true),
                    comp_economic_activity_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_notificationid = table.Column<int>(type: "int", nullable: true),
                    comp_notificationName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RecordStatus = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RecordResult = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    RIN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EPLD_Business", x => x.EPLDID);
                });

            migrationBuilder.CreateTable(
                name: "EPLD_Individual",
                columns: table => new
                {
                    EPLDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true),
                    TIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BVN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GenderID = table.Column<int>(type: "int", nullable: true),
                    GenderName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TitleID = table.Column<int>(type: "int", nullable: true),
                    TitleName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    first_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    middle_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    last_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateOfOrigin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaritalStatusName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EconomicActivityID = table.Column<int>(type: "int", nullable: true),
                    EconomicActivityName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NationalityID = table.Column<int>(type: "int", nullable: true),
                    NationalityName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    house_number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    street_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    city = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LGAName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ContactAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true),
                    TaxOfficeName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NotificationMethodID = table.Column<int>(type: "int", nullable: true),
                    NotificationMethodName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MaritalStatusID = table.Column<int>(type: "int", nullable: true),
                    RecordStatus = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RecordResult = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    RIN = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EPLD_Individual", x => x.EPLDID);
                });

            migrationBuilder.CreateTable(
                name: "ESD_Business",
                columns: table => new
                {
                    ESDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true),
                    tin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    registered_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    main_trade_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    org_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    registration_number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    line_of_business_code = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    lob_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    date_of_registration = table.Column<DateTime>(type: "datetime", nullable: true),
                    commencement_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_of_incorporation = table.Column<DateTime>(type: "datetime", nullable: true),
                    house_number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    street_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    city = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LGAName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CountryName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FinYrBegin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FinYrEnd = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    director_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    director_phone = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    director_email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxAuthorityCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxAuthorityName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxpayerStatus = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    business_type = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    business_category = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    business_sector = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    business_sub_sector = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    business_structure = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    business_operation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Premises_Size = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Contact_Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ContactAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerType = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxPayerRole = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_Gender = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_Title = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_first_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_middle_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_last_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_date_of_birth = table.Column<DateTime>(type: "datetime", nullable: true),
                    ind_tin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_taxoffice = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_maritalstatus = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_nationality = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_economic_activity = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ind_notification = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_tin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_taxoffice = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_cac_registrationnumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_economic_activity = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    comp_notification = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    record_status = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    record_error = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESD_Business", x => x.ESDID);
                });

            migrationBuilder.CreateTable(
                name: "ESD_Individual",
                columns: table => new
                {
                    ESDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true),
                    TIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BVN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NIN = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Gender = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Title = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    first_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    middle_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    last_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateOfOrigin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaritalStatus = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Occupation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Nationality = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    house_number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    street_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    city = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LGAName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ContactAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxOffice = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Notification = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    record_status = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    record_error = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESD_Individual", x => x.ESDID);
                });

            migrationBuilder.CreateTable(
                name: "Exception_Type",
                columns: table => new
                {
                    ExceptionTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionTypeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exception_Type", x => x.ExceptionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "External_DataSource",
                columns: table => new
                {
                    DataSourceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSourceName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_External_DataSource", x => x.DataSourceID);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderID);
                });

            migrationBuilder.CreateTable(
                name: "GISFileAssessment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentID = table.Column<long>(type: "bigint", nullable: false),
                    AssessmentYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSaved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(CONVERT([bigint],(0)))"),
                    PageNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GISFileAssessment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GISFileAssessmentItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentID = table.Column<long>(type: "bigint", nullable: false),
                    AssetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssessmentAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSaved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GISFileAssessmentItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GISFileAsset",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetSubType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetLGA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetWard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetBillingZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetSubzone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetUse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetPurpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetRoadName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetOffStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoldingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetCofO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupportingDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccupierStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyOccupants = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccupancyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetFootprintPresent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetCompletionYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetFurnished = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetPerimeter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFloors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetLatitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetLongitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateOfRepair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelOfCompletion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasGenerator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasSwimmingPool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasFence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBuildings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfBldgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WallMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoofMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SewageAccess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricConnection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterConnectionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolidWasteCollectionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSaved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(CONVERT([bigint],(0)))"),
                    PageNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GISFileAsset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GISFileHolder",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSaved = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    FileId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(CONVERT([bigint],(0)))"),
                    PageNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GISFileHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GISFileInvoice",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isReversal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSaved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(CONVERT([bigint],(0)))"),
                    PageNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GISFileInvoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GISFileInvoiceItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceID = table.Column<long>(type: "bigint", nullable: false),
                    RevenueHeadId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSaved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GISFileInvoiceItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GISFileParty",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartyExtID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyDOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyNIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyNationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyMaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyRelation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcquisitionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSaved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileId = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "(CONVERT([bigint],(0)))"),
                    PageNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GISFileParty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GISTesting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Government_Types",
                columns: table => new
                {
                    GovernmentTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernmentTypeName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Government_Types", x => x.GovernmentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "JTB_Individual",
                columns: table => new
                {
                    JTBIndividualID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    bvn = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    nin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Title = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SBIRt_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    middle_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    last_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GenderName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateOfOrigin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaritalStatus = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Occupation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    nationality_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    taxpayer_photo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    date_of_registration = table.Column<DateTime>(type: "datetime", nullable: true),
                    house_number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    street_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    city = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LGAName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CountryName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxAuthorityCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxAuthorityName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxpayerStatus = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JTB_Individual", x => x.JTBIndividualID);
                });

            migrationBuilder.CreateTable(
                name: "JTB_Individual_Old",
                columns: table => new
                {
                    SN = table.Column<double>(type: "float", nullable: true),
                    IndividualID = table.Column<int>(type: "int", nullable: true),
                    IndividualRIN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    MobileNumber1 = table.Column<double>(type: "float", nullable: true),
                    GenderID = table.Column<int>(type: "int", nullable: true),
                    GenderName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TitleID = table.Column<int>(type: "int", nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TIN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MobileNumber2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EmailAddress1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BiometricDetails = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true),
                    TaxOfficeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MaritalStatusID = table.Column<int>(type: "int", nullable: true),
                    MaritalStatusName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NationalityID = table.Column<int>(type: "int", nullable: true),
                    NationalityName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EconomicActivitiesID = table.Column<int>(type: "int", nullable: true),
                    EconomicActivitiesName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NotificationMethodID = table.Column<int>(type: "int", nullable: true),
                    NotificationMethodName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "JTB_NonIndividual",
                columns: table => new
                {
                    JTBNonIndividualID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    registered_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    main_trade_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    org_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    registration_number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    phone_no_2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    email_address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    line_of_business_code = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    lob_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    date_of_registration = table.Column<DateTime>(type: "datetime", nullable: true),
                    commencement_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_of_incorporation = table.Column<DateTime>(type: "datetime", nullable: true),
                    house_number = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    street_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    city = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LGAName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StateName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CountryName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FinYrBegin = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FinYrEnd = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    director_name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    director_phone = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    director_email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxAuthorityCode = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxAuthorityName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TaxpayerStatus = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JTB_NonIndividual", x => x.JTBNonIndividualID);
                });

            migrationBuilder.CreateTable(
                name: "Land_Development",
                columns: table => new
                {
                    LandDevelopmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandDevelopmentName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Land_Development", x => x.LandDevelopmentID);
                });

            migrationBuilder.CreateTable(
                name: "Land_Ownership",
                columns: table => new
                {
                    LandOwnershipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandOwnershipName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Land_Ownership", x => x.LandOwnershipID);
                });

            migrationBuilder.CreateTable(
                name: "Land_Purpose",
                columns: table => new
                {
                    LandPurposeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandPurposeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Land_Purpose", x => x.LandPurposeID);
                });

            migrationBuilder.CreateTable(
                name: "Land_StreetCondition",
                columns: table => new
                {
                    LandStreetConditionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandStreetConditionName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Land_StreetCondition", x => x.LandStreetConditionID);
                });

            migrationBuilder.CreateTable(
                name: "Late_Charges",
                columns: table => new
                {
                    LateChargeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    Penalty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Interest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Late_Charges", x => x.LateChargeID);
                });

            migrationBuilder.CreateTable(
                name: "LGAClass",
                columns: table => new
                {
                    LGAClassID = table.Column<int>(type: "int", nullable: false),
                    LGAClassName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LGAClass", x => x.LGAClassID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_Assessment_LateCharge",
                columns: table => new
                {
                    ALCID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AAIID = table.Column<long>(type: "bigint", nullable: true),
                    ChargeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Penalty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Interest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Assessment_LateCharge", x => x.ALCID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_SignVisible",
                columns: table => new
                {
                    CSVID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateID = table.Column<long>(type: "bigint", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    SignDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SignSourceID = table.Column<int>(type: "int", nullable: true),
                    AdditionalSignatureLocation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StageID = table.Column<int>(type: "int", nullable: true),
                    DocumentWidth = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_SignVisible", x => x.CSVID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_CertificateType_Items",
                columns: table => new
                {
                    CTIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateTypeID = table.Column<int>(type: "int", nullable: true),
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_CertificateType_Items", x => x.CTIID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_PaymentAccount_Operation",
                columns: table => new
                {
                    POAID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OperationTypeID = table.Column<int>(type: "int", nullable: true),
                    From_TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    From_TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    From_SettlementMethodID = table.Column<int>(type: "int", nullable: true),
                    To_TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    To_TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    To_BillTypeID = table.Column<int>(type: "int", nullable: true),
                    To_BillID = table.Column<long>(type: "bigint", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    POAAccountId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_PaymentAccount_Operation", x => x.POAID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_TaxPayer_Asset_Profile_PT",
                columns: table => new
                {
                    TPAPPTID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TPAID = table.Column<long>(type: "bigint", nullable: true),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MAP_TaxPayer_Asset_Profile_TempPT", x => x.TPAPPTID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_TaxPayer_Document",
                columns: table => new
                {
                    TPDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentRefNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    DocumentTitle = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DocumentPath = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TaxPayer_Document", x => x.TPDID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_TaxPayer_Message",
                columns: table => new
                {
                    TPMID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender_TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    Sender_TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    Sender_StaffID = table.Column<int>(type: "int", nullable: true),
                    Receiver_TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    Receiver_TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    Receiver_StaffID = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TaxPayer_Message", x => x.TPMID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_TaxPayer_Review",
                columns: table => new
                {
                    TPRID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    ReviewStatusID = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TaxPayer_Review", x => x.TPRID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_IncomeStream",
                columns: table => new
                {
                    TRISID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCCRequestID = table.Column<long>(type: "bigint", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TotalIncomeEarned = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxPayerRoleID = table.Column<int>(type: "int", nullable: true),
                    BusinessID = table.Column<int>(type: "int", nullable: true),
                    BusinessName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BusinessTypeID = table.Column<int>(type: "int", nullable: true),
                    LGAID = table.Column<int>(type: "int", nullable: true),
                    BusinessOperationID = table.Column<int>(type: "int", nullable: true),
                    BusinessAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BusinessNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ContactPersonName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_IncomeStream", x => x.TRISID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_Notes",
                columns: table => new
                {
                    RNID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    StageID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NotesDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_Notes", x => x.RNID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_SignVisible",
                columns: table => new
                {
                    RSVID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    SignDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SignSourceID = table.Column<int>(type: "int", nullable: true),
                    AdditionalSignatureLocation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    StageID = table.Column<int>(type: "int", nullable: true),
                    DocumentWidth = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_SignVisible", x => x.RSVID);
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_Stages",
                columns: table => new
                {
                    RSID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    StageID = table.Column<long>(type: "bigint", nullable: true),
                    ControllerName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ActionName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_Stages", x => x.RSID);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    MaritalStatusID = table.Column<int>(type: "int", nullable: false),
                    MaritalStatusName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.MaritalStatusID);
                });

            migrationBuilder.CreateTable(
                name: "MST_CertificateStage",
                columns: table => new
                {
                    CertificateStageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateStageName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ControllerName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ActionName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_CertificateStage", x => x.CertificateStageID);
                });

            migrationBuilder.CreateTable(
                name: "MST_CertificateStatus",
                columns: table => new
                {
                    CertificateStatusID = table.Column<int>(type: "int", nullable: false),
                    CertificateStatusName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_CertificateStatus", x => x.CertificateStatusID);
                });

            migrationBuilder.CreateTable(
                name: "MST_Computation",
                columns: table => new
                {
                    ComputationID = table.Column<int>(type: "int", nullable: false),
                    ComputationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_Computation", x => x.ComputationID);
                });

            migrationBuilder.CreateTable(
                name: "MST_EmailStack",
                columns: table => new
                {
                    EmailStackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromAddress = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    ToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToCCName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToBCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToBCCName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentPath = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AttachmentName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    EmailSendOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmailSentSuccess = table.Column<bool>(type: "bit", nullable: true),
                    EmailSendCount = table.Column<int>(type: "int", nullable: true),
                    EmailCreatedOn = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_EmailStack", x => x.EmailStackId);
                });

            migrationBuilder.CreateTable(
                name: "MST_FieldType",
                columns: table => new
                {
                    FieldTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldTypeName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_FieldType", x => x.FieldTypeID);
                });

            migrationBuilder.CreateTable(
                name: "MST_LastNumber",
                columns: table => new
                {
                    LastID = table.Column<int>(type: "int", nullable: false),
                    LastNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LastNumberType = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_LastNumber", x => x.LastID);
                });

            migrationBuilder.CreateTable(
                name: "MST_PaymentStatus",
                columns: table => new
                {
                    PaymentStatusID = table.Column<int>(type: "int", nullable: false),
                    PaymentStatusName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_PaymentStatus", x => x.PaymentStatusID);
                });

            migrationBuilder.CreateTable(
                name: "MST_RegisterationStatus",
                columns: table => new
                {
                    RegisterationStatusID = table.Column<int>(type: "int", nullable: false),
                    RegisterationStatusName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_RegisterationStatus", x => x.RegisterationStatusID);
                });

            migrationBuilder.CreateTable(
                name: "MST_RuleRun",
                columns: table => new
                {
                    RuleRunID = table.Column<int>(type: "int", nullable: false),
                    RuleRunName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_RuleRun", x => x.RuleRunID);
                });

            migrationBuilder.CreateTable(
                name: "MST_TCCRequestStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_TCCRequestStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "MST_TCCStage",
                columns: table => new
                {
                    TCCStageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCCStageName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ControllerName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ActionName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_TCCStage", x => x.TCCStageID);
                });

            migrationBuilder.CreateTable(
                name: "MST_TCCStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_TCCStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    NationalityID = table.Column<int>(type: "int", nullable: false),
                    NationalityName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.NationalityID);
                });

            migrationBuilder.CreateTable(
                name: "NewERASTccHolder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TotalIncomeEarned = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AssessmentYear = table.Column<int>(type: "int", nullable: true),
                    Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BusinessName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LGA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewERASTccHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notification_Method",
                columns: table => new
                {
                    NotificationMethodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationMethodName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_Method", x => x.NotificationMethodID);
                });

            migrationBuilder.CreateTable(
                name: "Notification_Mode",
                columns: table => new
                {
                    NotificationModeID = table.Column<int>(type: "int", nullable: false),
                    NotificationModeName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_Mode", x => x.NotificationModeID);
                });

            migrationBuilder.CreateTable(
                name: "Notification_Type",
                columns: table => new
                {
                    NotificationTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TypeDescription = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_Type", x => x.NotificationTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Operation_Types",
                columns: table => new
                {
                    Operation_TypesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Operation_TypesName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation_Types", x => x.Operation_TypesID);
                });

            migrationBuilder.CreateTable(
                name: "PayDirect_Notifications",
                columns: table => new
                {
                    PDINotificationID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestParameter = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayDirect_Notifications", x => x.PDINotificationID);
                });

            migrationBuilder.CreateTable(
                name: "PayeTccHolder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndividualRIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AnnualGross = table.Column<double>(type: "float", nullable: true),
                    Cra = table.Column<double>(type: "float", nullable: true),
                    ValidatedPension = table.Column<double>(type: "float", nullable: true),
                    ValidatedNhf = table.Column<double>(type: "float", nullable: true),
                    ValidatedNhis = table.Column<double>(type: "float", nullable: true),
                    TaxFreePay = table.Column<double>(type: "float", nullable: true),
                    ChargeableIncome = table.Column<double>(type: "float", nullable: true),
                    AnnualTax = table.Column<double>(type: "float", nullable: true),
                    AnnualTaxII = table.Column<double>(type: "float", nullable: true),
                    MonthlyTax = table.Column<double>(type: "float", nullable: true),
                    RowID = table.Column<int>(type: "int", nullable: true),
                    AssessmentYear = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BusinessName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ReceiptDetail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayeTccHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment_Frequency",
                columns: table => new
                {
                    PaymentFrequencyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentFrequencyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Frequency", x => x.PaymentFrequencyID);
                });

            migrationBuilder.CreateTable(
                name: "Payment_Options",
                columns: table => new
                {
                    PaymentOptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentOptionName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Options", x => x.PaymentOptionID);
                });

            migrationBuilder.CreateTable(
                name: "Profile_Types",
                columns: table => new
                {
                    ProfileTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileTypeName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile_Types", x => x.ProfileTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Receipt_Status",
                columns: table => new
                {
                    ReceiptStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptStatusName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt_Status", x => x.ReceiptStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Revenue_Stream",
                columns: table => new
                {
                    RevenueStreamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevenueStreamName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EnableBillNotification = table.Column<bool>(type: "bit", nullable: true),
                    NotificationPeriod = table.Column<int>(type: "int", nullable: true),
                    EmailContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SMSContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillTemplatePath = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenue_Stream", x => x.RevenueStreamID);
                });

            migrationBuilder.CreateTable(
                name: "Review_Status",
                columns: table => new
                {
                    ReviewStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewStatusName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    StatusDescription = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review_Status", x => x.ReviewStatusID);
                });

            migrationBuilder.CreateTable(
                name: "RIN_Check",
                columns: table => new
                {
                    PHONE_NUMBER = table.Column<double>(type: "float", nullable: true),
                    IndividualRIN = table.Column<string>(name: "Individual RIN", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CompanyRIN = table.Column<string>(name: "Company RIN", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Scratch_Card_Dealers",
                columns: table => new
                {
                    ScratchCardDealerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScratchCardDealerName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    DealerTypeID = table.Column<int>(type: "int", nullable: true),
                    AgreedCommissionPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scratch_Card_Dealers", x => x.ScratchCardDealerID);
                });

            migrationBuilder.CreateTable(
                name: "Scratch_Card_Printer",
                columns: table => new
                {
                    ScratchCardPrinterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScratchCardPrinterName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    AgreedUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scratch_Card_Printer", x => x.ScratchCardPrinterID);
                });

            migrationBuilder.CreateTable(
                name: "ScratchCard_PurchaseRequest",
                columns: table => new
                {
                    SCPRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestReferenceNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DealerTypeID = table.Column<int>(type: "int", nullable: true),
                    ScratchCardDealerID = table.Column<int>(type: "int", nullable: true),
                    RequestedQty = table.Column<int>(type: "int", nullable: true),
                    Commission = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentStatusID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScratchCard_PurchaseRequest", x => x.SCPRequestID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceBill",
                columns: table => new
                {
                    ServiceBillID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceBillRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ServiceBillDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    ServiceBillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SettlementDueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SettlementStatusID = table.Column<int>(type: "int", nullable: true),
                    SettlementDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    BillPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceBill", x => x.ServiceBillID);
                });

            migrationBuilder.CreateTable(
                name: "Settlement_Method",
                columns: table => new
                {
                    SettlementMethodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettlementMethodName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settlement_Method", x => x.SettlementMethodID);
                });

            migrationBuilder.CreateTable(
                name: "Settlement_Status",
                columns: table => new
                {
                    SettlementStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettlementStatusName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    StatusDescription = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settlement_Status", x => x.SettlementStatusID);
                });

            migrationBuilder.CreateTable(
                name: "SFTP_DataSubmissionType",
                columns: table => new
                {
                    DataSubmissionTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSubmissionTypeName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TemplateFilePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SFTP_DataSubmissionType", x => x.DataSubmissionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "SFTP_DataSubmitter",
                columns: table => new
                {
                    DataSubmitterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RIN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    UserName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Password = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SFTP_DataSubmitter", x => x.DataSubmitterID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeID);
                });

            migrationBuilder.CreateTable(
                name: "SystemRole",
                columns: table => new
                {
                    SystemRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemRoleName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRole", x => x.SystemRoleID);
                });

            migrationBuilder.CreateTable(
                name: "Tax_Credit",
                columns: table => new
                {
                    TaxCreditID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    CreditDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax_Credit", x => x.TaxCreditID);
                });

            migrationBuilder.CreateTable(
                name: "TaxClearanceCertificate",
                columns: table => new
                {
                    TCCID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCCNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TCCDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    RequestRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TaxPayerDetails = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IncomeSource = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    CancelNotes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxClearanceCertificate", x => x.TCCID);
                });

            migrationBuilder.CreateTable(
                name: "TaxOffice",
                columns: table => new
                {
                    TaxOfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxOfficeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AddressTypeId = table.Column<int>(type: "int", nullable: true),
                    ZoneCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TaxPayer_Types",
                columns: table => new
                {
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxPayerTypeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPayer_Types", x => x.TaxPayerTypeID);
                });

            migrationBuilder.CreateTable(
                name: "TaxPayerPayment",
                columns: table => new
                {
                    TPPID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransactionTypeID = table.Column<int>(type: "int", nullable: true),
                    TransactionDescription = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    TransactionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMethodID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPayerPayment", x => x.TPPID);
                });

            migrationBuilder.CreateTable(
                name: "TCC_Request",
                columns: table => new
                {
                    TCCRequestID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ServiceBillID = table.Column<long>(type: "bigint", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    VisibleSignStatusID = table.Column<int>(type: "int", nullable: true),
                    PDFTemplateID = table.Column<int>(type: "int", nullable: true),
                    GeneratedPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ValidatedPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SignedVisiblePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SignedDigitalPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SealedPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SEDE_DocumentID = table.Column<int>(type: "int", nullable: true),
                    SEDE_OrderID = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCC_Request", x => x.TCCRequestID);
                });

            migrationBuilder.CreateTable(
                name: "TCCDetails",
                columns: table => new
                {
                    TCCDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    AssessableIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TCCTaxPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ERASTaxPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ERASAssessed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCCDetails", x => x.TCCDetailID);
                });

            migrationBuilder.CreateTable(
                name: "TccRefHolder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReqId = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    ReciptRef = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ReceiptDate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TccRefHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderID = table.Column<int>(type: "int", nullable: true),
                    TitleName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.TitleID);
                });

            migrationBuilder.CreateTable(
                name: "Treasury_Receipt",
                columns: table => new
                {
                    ReceiptID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ServiceBillID = table.Column<long>(type: "bigint", nullable: true),
                    AssessmentID = table.Column<long>(type: "bigint", nullable: true),
                    ReceiptAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReceiptDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    CancelledBy = table.Column<int>(type: "int", nullable: true),
                    CancelNotes = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Notes = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    GeneratedPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SignedPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SignSourceID = table.Column<int>(type: "int", nullable: true),
                    SignImgSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentUrl = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treasury_Receipt", x => x.ReceiptID);
                });

            migrationBuilder.CreateTable(
                name: "Unit_Occupancy",
                columns: table => new
                {
                    UnitOccupancyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitOccupancyName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit_Occupancy", x => x.UnitOccupancyID);
                });

            migrationBuilder.CreateTable(
                name: "Unit_Purpose",
                columns: table => new
                {
                    UnitPurposeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPurposeName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit_Purpose", x => x.UnitPurposeID);
                });

            migrationBuilder.CreateTable(
                name: "upload",
                columns: table => new
                {
                    sno = table.Column<double>(name: "s/no", type: "float", nullable: true),
                    AssessmentID = table.Column<double>(type: "float", nullable: true),
                    AARID = table.Column<double>(type: "float", nullable: true),
                    AAIID = table.Column<double>(type: "float", nullable: true),
                    TaxBaseAmount = table.Column<double>(type: "float", nullable: true),
                    TaxAmount = table.Column<double>(type: "float", nullable: true),
                    SettlementID = table.Column<double>(type: "float", nullable: true),
                    SettlementAmount = table.Column<double>(type: "float", nullable: true),
                    SettlementDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_Ownership",
                columns: table => new
                {
                    VehicleOwnershipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleOwnershipName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Ownership", x => x.VehicleOwnershipID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_Purpose",
                columns: table => new
                {
                    VehiclePurposeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclePurposeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Purpose", x => x.VehiclePurposeID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_Types",
                columns: table => new
                {
                    VehicleTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Types", x => x.VehicleTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    ZoneCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoneName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LgaId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedBY = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.ZoneCode);
                });

            migrationBuilder.CreateTable(
                name: "ZoneLGA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LgaName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ZoneCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneLGA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    AgencyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyTypeID = table.Column<int>(type: "int", nullable: true),
                    AgencyName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.AgencyID);
                    table.ForeignKey(
                        name: "FK_Agencies_Agency_Types",
                        column: x => x.AgencyTypeID,
                        principalTable: "Agency_Types",
                        principalColumn: "AgencyTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Audit_Log",
                columns: table => new
                {
                    ALID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ASLID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IPAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit_Log", x => x.ALID);
                    table.ForeignKey(
                        name: "FK_Audit_Log_AL_Screen",
                        column: x => x.ASLID,
                        principalTable: "AL_Screen",
                        principalColumn: "ASLID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Assessment_AssessmentRule",
                columns: table => new
                {
                    AARID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentID = table.Column<long>(type: "bigint", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    AssetID = table.Column<int>(type: "int", nullable: true),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    AssessmentRuleID = table.Column<int>(type: "int", nullable: true),
                    AssessmentYear = table.Column<int>(type: "int", nullable: true),
                    AssessmentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Assessment_AssessmentRule", x => x.AARID);
                    table.ForeignKey(
                        name: "FK_MAP_Assessment_AssessmentRule_Assessment",
                        column: x => x.AssessmentID,
                        principalTable: "Assessment",
                        principalColumn: "AssessmentID");
                });

            migrationBuilder.CreateTable(
                name: "Assessment_Item_SubCategory",
                columns: table => new
                {
                    AssessmentItemSubCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemSubCategoryName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_Item_SubCategory", x => x.AssessmentItemSubCategoryID);
                    table.ForeignKey(
                        name: "FK_Assessment_Item_SubCategory_Assessment_Item_Category",
                        column: x => x.AssessmentItemCategoryID,
                        principalTable: "Assessment_Item_Category",
                        principalColumn: "AssessmentItemCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "Assessment_Group",
                columns: table => new
                {
                    AssessmentGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    AssessmentGroupName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_Group", x => x.AssessmentGroupID);
                    table.ForeignKey(
                        name: "FK_Assessment_Group_Asset_Types",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileReferenceNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ProfileDescription = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    AssetTypeStatus = table.Column<int>(type: "int", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    ProfileTypeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileID);
                    table.ForeignKey(
                        name: "FK_Profiles_Asset_Types",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Profiles_BKP",
                columns: table => new
                {
                    ProfileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileReferenceNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ProfileDescription = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    AssetTypeStatus = table.Column<int>(type: "int", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    ProfileTypeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles_BKP", x => x.ProfileID);
                    table.ForeignKey(
                        name: "FK_Profiles_Asset_Types_BKP",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Business_Category",
                columns: table => new
                {
                    BusinessCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessCategoryName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BusinessTypeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Category", x => x.BusinessCategoryID);
                    table.ForeignKey(
                        name: "FK_Business_Category_Business_Types",
                        column: x => x.BusinessTypeID,
                        principalTable: "Business_Types",
                        principalColumn: "BusinessTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Business_Operation",
                columns: table => new
                {
                    BusinessOperationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessOperationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BusinessTypeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Operation", x => x.BusinessOperationID);
                    table.ForeignKey(
                        name: "FK_Business_Operation_Business_Types",
                        column: x => x.BusinessTypeID,
                        principalTable: "Business_Types",
                        principalColumn: "BusinessTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Business_Structure",
                columns: table => new
                {
                    BusinessStructureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessStructureName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    BusinessTypeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Structure", x => x.BusinessStructureID);
                    table.ForeignKey(
                        name: "FK_Business_Structure_Business_Types",
                        column: x => x.BusinessTypeID,
                        principalTable: "Business_Types",
                        principalColumn: "BusinessTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificateID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CertificateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CertificateTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    AssetID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    DisplayTypeID = table.Column<int>(type: "int", nullable: true),
                    OtherInformation = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SignerID = table.Column<int>(type: "int", nullable: true),
                    SignerRoleID = table.Column<int>(type: "int", nullable: true),
                    QRCodeID = table.Column<int>(type: "int", nullable: true),
                    QRImagePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VisibleSignStatusID = table.Column<int>(type: "int", nullable: true),
                    PDFTemplateID = table.Column<int>(type: "int", nullable: true),
                    CertificatePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    GeneratedPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ValidatedPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SignedVisiblePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SignedDigitalPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SealedPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SEDE_DocumentID = table.Column<int>(type: "int", nullable: true),
                    SEDE_OrderID = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CertificateID);
                    table.ForeignKey(
                        name: "FK_Certificates_Certificate_Types",
                        column: x => x.CertificateTypeID,
                        principalTable: "Certificate_Types",
                        principalColumn: "CertificateTypeID");
                });

            migrationBuilder.CreateTable(
                name: "EM_RevenueHead",
                columns: table => new
                {
                    RevenueHeadID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    RevenueHeadName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EM_RevenueHead", x => x.RevenueHeadID);
                    table.ForeignKey(
                        name: "FK_EM_RevenueHead_EM_Category",
                        column: x => x.CategoryID,
                        principalTable: "EM_Category",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "Land_Function",
                columns: table => new
                {
                    LandFunctionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandFunctionName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    LandPurposeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Land_Function", x => x.LandFunctionID);
                    table.ForeignKey(
                        name: "FK_Land_Function_Land_Purpose",
                        column: x => x.LandPurposeID,
                        principalTable: "Land_Purpose",
                        principalColumn: "LandPurposeID");
                });

            migrationBuilder.CreateTable(
                name: "LGA",
                columns: table => new
                {
                    LGAID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LGAName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LGAClassID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LGA", x => x.LGAID);
                    table.ForeignKey(
                        name: "FK_LGA_LGAClass",
                        column: x => x.LGAClassID,
                        principalTable: "LGAClass",
                        principalColumn: "LGAClassID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TaxPayer_Message_Document",
                columns: table => new
                {
                    TPMDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TPMID = table.Column<long>(type: "bigint", nullable: true),
                    DocumentName = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    DocumentPath = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TaxPayer_Message_Document", x => x.TPMDID);
                    table.ForeignKey(
                        name: "FK_MAP_TaxPayer_Message_Document_MAP_TaxPayer_Message",
                        column: x => x.TPMID,
                        principalTable: "MAP_TaxPayer_Message",
                        principalColumn: "TPMID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_Notes_Document",
                columns: table => new
                {
                    RNDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RNID = table.Column<long>(type: "bigint", nullable: true),
                    DocumentName = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    DocumentPath = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_Notes_Document", x => x.RNDID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_Notes_Document_MAP_TCCRequest_Notes",
                        column: x => x.RNID,
                        principalTable: "MAP_TCCRequest_Notes",
                        principalColumn: "RNID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_CertificateType_Field",
                columns: table => new
                {
                    CTFID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateTypeID = table.Column<int>(type: "int", nullable: true),
                    FieldName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FieldSlug = table.Column<string>(type: "varchar(550)", unicode: false, maxLength: 550, nullable: true),
                    FieldTypeID = table.Column<int>(type: "int", nullable: true),
                    FieldComboValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRequired = table.Column<bool>(type: "bit", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MST_ReceiverOption", x => x.CTFID);
                    table.ForeignKey(
                        name: "FK_MAP_CertificateType_Field_Certificate_Types",
                        column: x => x.CertificateTypeID,
                        principalTable: "Certificate_Types",
                        principalColumn: "CertificateTypeID");
                    table.ForeignKey(
                        name: "FK_MAP_CertificateType_Field_MST_FieldType",
                        column: x => x.FieldTypeID,
                        principalTable: "MST_FieldType",
                        principalColumn: "FieldTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NotificationMethodID = table.Column<int>(type: "int", nullable: true),
                    NotificationTypeID = table.Column<int>(type: "int", nullable: true),
                    EventRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    NotificationModeID = table.Column<int>(type: "int", nullable: true),
                    NotificationStatus = table.Column<bool>(type: "bit", nullable: true),
                    NotificationContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationID);
                    table.ForeignKey(
                        name: "FK_Notifications_Notification_Method",
                        column: x => x.NotificationMethodID,
                        principalTable: "Notification_Method",
                        principalColumn: "NotificationMethodID");
                    table.ForeignKey(
                        name: "FK_Notifications_Notification_Mode",
                        column: x => x.NotificationModeID,
                        principalTable: "Notification_Mode",
                        principalColumn: "NotificationModeID");
                    table.ForeignKey(
                        name: "FK_Notifications_Notification_Type",
                        column: x => x.NotificationTypeID,
                        principalTable: "Notification_Type",
                        principalColumn: "NotificationTypeID");
                });

            migrationBuilder.CreateTable(
                name: "MDA_Services",
                columns: table => new
                {
                    MDAServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MDAServiceCode = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    MDAServiceName = table.Column<string>(type: "varchar(2500)", unicode: false, maxLength: 2500, nullable: true),
                    RuleRunID = table.Column<int>(type: "int", nullable: true),
                    PaymentFrequencyID = table.Column<int>(type: "int", nullable: true),
                    ServiceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    PaymentOptionID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MDA_Services", x => x.MDAServiceID);
                    table.ForeignKey(
                        name: "FK_MDA_Services_MST_RuleRun",
                        column: x => x.RuleRunID,
                        principalTable: "MST_RuleRun",
                        principalColumn: "RuleRunID");
                    table.ForeignKey(
                        name: "FK_MDA_Services_Payment_Frequency",
                        column: x => x.PaymentFrequencyID,
                        principalTable: "Payment_Frequency",
                        principalColumn: "PaymentFrequencyID");
                    table.ForeignKey(
                        name: "FK_MDA_Services_Payment_Options",
                        column: x => x.PaymentOptionID,
                        principalTable: "Payment_Options",
                        principalColumn: "PaymentOptionID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Directorates_RevenueStream",
                columns: table => new
                {
                    DRSID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorateID = table.Column<int>(type: "int", nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Directorate_RevenueStream", x => x.DRSID);
                    table.ForeignKey(
                        name: "FK_MAP_Directorates_RevenueStream_Directorates",
                        column: x => x.DirectorateID,
                        principalTable: "Directorates",
                        principalColumn: "DirectorateID");
                    table.ForeignKey(
                        name: "FK_MAP_Directorates_RevenueStream_Revenue_Stream",
                        column: x => x.RevenueStreamID,
                        principalTable: "Revenue_Stream",
                        principalColumn: "RevenueStreamID");
                });

            migrationBuilder.CreateTable(
                name: "Revenue_SubStream",
                columns: table => new
                {
                    RevenueSubStreamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueSubStreamName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenue_SubStream", x => x.RevenueSubStreamID);
                    table.ForeignKey(
                        name: "FK_Revenue_SubStream_Revenue_Stream",
                        column: x => x.RevenueStreamID,
                        principalTable: "Revenue_Stream",
                        principalColumn: "RevenueStreamID");
                });

            migrationBuilder.CreateTable(
                name: "Settlement",
                columns: table => new
                {
                    SettlementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettlementRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ServiceBillID = table.Column<long>(type: "bigint", nullable: true),
                    AssessmentID = table.Column<long>(type: "bigint", nullable: true),
                    SettlementAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SettlementMethodID = table.Column<int>(type: "int", nullable: true),
                    SettlementDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SettlementNotes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TransactionRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settlement", x => x.SettlementID);
                    table.ForeignKey(
                        name: "FK_Settlement_Assessment",
                        column: x => x.AssessmentID,
                        principalTable: "Assessment",
                        principalColumn: "AssessmentID");
                    table.ForeignKey(
                        name: "FK_Settlement_ServiceBill",
                        column: x => x.ServiceBillID,
                        principalTable: "ServiceBill",
                        principalColumn: "ServiceBillID");
                    table.ForeignKey(
                        name: "FK_Settlement_Settlement_Method",
                        column: x => x.SettlementMethodID,
                        principalTable: "Settlement_Method",
                        principalColumn: "SettlementMethodID");
                });

            migrationBuilder.CreateTable(
                name: "SFTP_DataSubmission",
                columns: table => new
                {
                    DataSubmissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmissionRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    DataSubmitterID = table.Column<int>(type: "int", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    DataSubmissionTypeID = table.Column<int>(type: "int", nullable: true),
                    DocumentPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SFTP_DataSubmission", x => x.DataSubmissionID);
                    table.ForeignKey(
                        name: "FK_SFTP_DataSubmission_SFTP_DataSubmissionType",
                        column: x => x.DataSubmissionTypeID,
                        principalTable: "SFTP_DataSubmissionType",
                        principalColumn: "DataSubmissionTypeID");
                    table.ForeignKey(
                        name: "FK_SFTP_DataSubmission_SFTP_DataSubmitter",
                        column: x => x.DataSubmitterID,
                        principalTable: "SFTP_DataSubmitter",
                        principalColumn: "DataSubmitterID");
                });

            migrationBuilder.CreateTable(
                name: "SFTP_MAP_DataSubmitter_DataSubmissionType",
                columns: table => new
                {
                    DSTDSID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSubmissionTypeID = table.Column<int>(type: "int", nullable: true),
                    DataSubmitterID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SFTP_MAP_DataSubmitter_DataSubmissionType", x => x.DSTDSID);
                    table.ForeignKey(
                        name: "FK_SFTP_MAP_DataSubmitter_DataSubmissionType_SFTP_DataSubmissionType",
                        column: x => x.DataSubmissionTypeID,
                        principalTable: "SFTP_DataSubmissionType",
                        principalColumn: "DataSubmissionTypeID");
                    table.ForeignKey(
                        name: "FK_SFTP_MAP_DataSubmitter_DataSubmissionType_SFTP_DataSubmitter",
                        column: x => x.DataSubmitterID,
                        principalTable: "SFTP_DataSubmitter",
                        principalColumn: "DataSubmitterID");
                });

            migrationBuilder.CreateTable(
                name: "SystemUser",
                columns: table => new
                {
                    SystemUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemUserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserLogin = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UserPassword = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SystemRoleID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime", nullable: true),
                    FailedLoginCount = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUser", x => x.SystemUserID);
                    table.ForeignKey(
                        name: "FK_SystemUser_SystemRole",
                        column: x => x.SystemRoleID,
                        principalTable: "SystemRole",
                        principalColumn: "SystemRoleID");
                });

            migrationBuilder.CreateTable(
                name: "Economic_Activities",
                columns: table => new
                {
                    EconomicActivitiesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    EconomicActivitiesName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Economic_Activities", x => x.EconomicActivitiesID);
                    table.ForeignKey(
                        name: "FK_Economic_Activities_TaxPayer_Types",
                        column: x => x.TaxPayerTypeID,
                        principalTable: "TaxPayer_Types",
                        principalColumn: "TaxPayerTypeID");
                });

            migrationBuilder.CreateTable(
                name: "TaxPayer_Roles",
                columns: table => new
                {
                    TaxPayerRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerRoleName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    IsMultiLinkable = table.Column<bool>(type: "bit", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPayer_Roles", x => x.TaxPayerRoleID);
                    table.ForeignKey(
                        name: "FK_TaxPayer_Roles_Asset_Types",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                    table.ForeignKey(
                        name: "FK_TaxPayer_Roles_TaxPayer_Types",
                        column: x => x.TaxPayerTypeID,
                        principalTable: "TaxPayer_Types",
                        principalColumn: "TaxPayerTypeID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_Generate",
                columns: table => new
                {
                    RGID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Location = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsExpirable = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_Generate", x => x.RGID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_Generate_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_GenerateTCCDetail",
                columns: table => new
                {
                    GTCCDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_GenerateTCCDetail", x => x.GTCCDetailID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_GenerateTCCDetail_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_Issue",
                columns: table => new
                {
                    RIID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_Issue", x => x.RIID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_Issue_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_PrepareTCCDraft",
                columns: table => new
                {
                    PTCCDraftID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_PrepareTCCDraft", x => x.PTCCDraftID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_PrepareTCCDraft_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_Revoke",
                columns: table => new
                {
                    RRID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_Revoke", x => x.RRID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_Revoke_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_Seal",
                columns: table => new
                {
                    RSID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_Seal", x => x.RSID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_Seal_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_SignDigital",
                columns: table => new
                {
                    RSDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_SignDigital", x => x.RSDID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_SignDigital_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_Validate",
                columns: table => new
                {
                    RVID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_Validate", x => x.RVID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_Validate_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_ValidateTaxPayerIncome",
                columns: table => new
                {
                    VTPIncomeID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_ValidateTaxPayerIncome", x => x.VTPIncomeID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_ValidateTaxPayerIncome_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_ValidateTaxPayerInformation",
                columns: table => new
                {
                    VTPInformationID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_ValidateTaxPayerInformation", x => x.VTPInformationID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_ValidateTaxPayerInformation_TCC_Request",
                        column: x => x.RequestID,
                        principalTable: "TCC_Request",
                        principalColumn: "TCCRequestID");
                });

            migrationBuilder.CreateTable(
                name: "Unit_Function",
                columns: table => new
                {
                    UnitFunctionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitFunctionName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    UnitPurposeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit_Function", x => x.UnitFunctionID);
                    table.ForeignKey(
                        name: "FK_Unit_Function_Unit_Purpose",
                        column: x => x.UnitPurposeID,
                        principalTable: "Unit_Purpose",
                        principalColumn: "UnitPurposeID");
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_Function",
                columns: table => new
                {
                    VehicleFunctionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleFunctionName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    VehiclePurposeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Function", x => x.VehicleFunctionID);
                    table.ForeignKey(
                        name: "FK_Vehicle_Function_Vehicle_Purpose",
                        column: x => x.VehiclePurposeID,
                        principalTable: "Vehicle_Purpose",
                        principalColumn: "VehiclePurposeID");
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_SubTypes",
                columns: table => new
                {
                    VehicleSubTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleSubTypeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VehicleTypeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_SubTypes", x => x.VehicleSubTypeID);
                    table.ForeignKey(
                        name: "FK_Vehicle_SubTypes_Vehicle_Types",
                        column: x => x.VehicleTypeID,
                        principalTable: "Vehicle_Types",
                        principalColumn: "VehicleTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Assessment_SubGroup",
                columns: table => new
                {
                    AssessmentSubGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentGroupID = table.Column<int>(type: "int", nullable: true),
                    AssessmentSubGroupName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_SubGroup", x => x.AssessmentSubGroupID);
                    table.ForeignKey(
                        name: "FK_Assessment_SubGroup_Assessment_Group",
                        column: x => x.AssessmentGroupID,
                        principalTable: "Assessment_Group",
                        principalColumn: "AssessmentGroupID");
                });

            migrationBuilder.CreateTable(
                name: "Assessment_Rules",
                columns: table => new
                {
                    AssessmentRuleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentRuleCode = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    AssessmentRuleName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RuleRunID = table.Column<int>(type: "int", nullable: true),
                    PaymentFrequencyID = table.Column<int>(type: "int", nullable: true),
                    AssessmentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    TaxMonth = table.Column<int>(type: "int", nullable: true),
                    PaymentOptionID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_Rules", x => x.AssessmentRuleID);
                    table.ForeignKey(
                        name: "FK_Assessment_Rules_MST_RuleRun",
                        column: x => x.RuleRunID,
                        principalTable: "MST_RuleRun",
                        principalColumn: "RuleRunID");
                    table.ForeignKey(
                        name: "FK_Assessment_Rules_Payment_Frequency",
                        column: x => x.PaymentFrequencyID,
                        principalTable: "Payment_Frequency",
                        principalColumn: "PaymentFrequencyID");
                    table.ForeignKey(
                        name: "FK_Assessment_Rules_Payment_Options",
                        column: x => x.PaymentOptionID,
                        principalTable: "Payment_Options",
                        principalColumn: "PaymentOptionID");
                    table.ForeignKey(
                        name: "FK_Assessment_Rules_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileAttribute",
                columns: table => new
                {
                    ProfileAttributeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    AttributeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileAttribute", x => x.ProfileAttributeID);
                    table.ForeignKey(
                        name: "FK_ProfileAttribute_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileGroup",
                columns: table => new
                {
                    ProfileGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    GroupID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileGroup", x => x.ProfileGroupID);
                    table.ForeignKey(
                        name: "FK_ProfileGroup_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileSector",
                columns: table => new
                {
                    ProfileSectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    SectorID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSector", x => x.ProfileSectorID);
                    table.ForeignKey(
                        name: "FK_ProfileSector_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileSectorElement",
                columns: table => new
                {
                    ProfileSectorElementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    SectorElementID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSectorElement", x => x.ProfileSectorElementID);
                    table.ForeignKey(
                        name: "FK_ProfileSectorElement_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileSectorSubElement",
                columns: table => new
                {
                    ProfileSectorSubElementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    SectorSubElementID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSectorSubElement", x => x.ProfileSectorSubElementID);
                    table.ForeignKey(
                        name: "FK_ProfileSectorSubElement_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileSubAttribute",
                columns: table => new
                {
                    ProfileSubAttributeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    SubAttributeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSubAttribute", x => x.ProfileSubAttributeID);
                    table.ForeignKey(
                        name: "FK_ProfileSubAttribute_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileSubGroup",
                columns: table => new
                {
                    ProfileSubGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    SubGroupID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSubGroup", x => x.ProfileSubGroupID);
                    table.ForeignKey(
                        name: "FK_ProfileSubGroup_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileSubSector",
                columns: table => new
                {
                    ProfileSubSectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    SubSectorID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSubSector", x => x.ProfileSubSectorID);
                    table.ForeignKey(
                        name: "FK_ProfileSubSector_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileTaxPayerRole",
                columns: table => new
                {
                    ProfileTaxPayerRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerRoleID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileTaxPayerRole", x => x.ProfileTaxPayerRoleID);
                    table.ForeignKey(
                        name: "FK_ProfileTaxPayerRole_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "ProfileTaxPayerType",
                columns: table => new
                {
                    ProfileTaxPayerTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileTaxPayerType", x => x.ProfileTaxPayerTypeID);
                    table.ForeignKey(
                        name: "FK_ProfileTaxPayerType_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "Business_Sector",
                columns: table => new
                {
                    BusinessSectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessSectorName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BusinessTypeID = table.Column<int>(type: "int", nullable: true),
                    BusinessCategoryID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Sector", x => x.BusinessSectorID);
                    table.ForeignKey(
                        name: "FK_Business_Sector_Business_Category",
                        column: x => x.BusinessCategoryID,
                        principalTable: "Business_Category",
                        principalColumn: "BusinessCategoryID");
                    table.ForeignKey(
                        name: "FK_Business_Sector_Business_Types",
                        column: x => x.BusinessTypeID,
                        principalTable: "Business_Types",
                        principalColumn: "BusinessTypeID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_Generate",
                columns: table => new
                {
                    CGID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateID = table.Column<long>(type: "bigint", nullable: true),
                    CertificatePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Location = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsExpirable = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_Generate", x => x.CGID);
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_Generate_Certificates",
                        column: x => x.CertificateID,
                        principalTable: "Certificates",
                        principalColumn: "CertificateID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_Issue",
                columns: table => new
                {
                    CIID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_Issue", x => x.CIID);
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_Issue_Certificates",
                        column: x => x.CertificateID,
                        principalTable: "Certificates",
                        principalColumn: "CertificateID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_Revoke",
                columns: table => new
                {
                    CRID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateID = table.Column<long>(type: "bigint", nullable: true),
                    Reason = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_Revoke", x => x.CRID);
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_Revoke_Certificates",
                        column: x => x.CertificateID,
                        principalTable: "Certificates",
                        principalColumn: "CertificateID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_Seal",
                columns: table => new
                {
                    CSID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_Seal", x => x.CSID);
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_Seal_Certificates",
                        column: x => x.CertificateID,
                        principalTable: "Certificates",
                        principalColumn: "CertificateID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_SignDigital",
                columns: table => new
                {
                    CSDID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_SignDigital", x => x.CSDID);
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_SignDigital_Certificates",
                        column: x => x.CertificateID,
                        principalTable: "Certificates",
                        principalColumn: "CertificateID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_Stages",
                columns: table => new
                {
                    CSID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateID = table.Column<long>(type: "bigint", nullable: true),
                    StageID = table.Column<long>(type: "bigint", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_Stages", x => x.CSID);
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_Stages_Certificates",
                        column: x => x.CertificateID,
                        principalTable: "Certificates",
                        principalColumn: "CertificateID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_Validate",
                columns: table => new
                {
                    CVID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateID = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_Validate", x => x.CVID);
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_Validate_Certificates",
                        column: x => x.CertificateID,
                        principalTable: "Certificates",
                        principalColumn: "CertificateID");
                });

            migrationBuilder.CreateTable(
                name: "Town",
                columns: table => new
                {
                    TownID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TownName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LGAID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Town", x => x.TownID);
                    table.ForeignKey(
                        name: "FK_Town_LGA",
                        column: x => x.LGAID,
                        principalTable: "LGA",
                        principalColumn: "LGAID");
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    WardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LGAID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.WardID);
                    table.ForeignKey(
                        name: "FK_Ward_LGA",
                        column: x => x.LGAID,
                        principalTable: "LGA",
                        principalColumn: "LGAID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_CustomField",
                columns: table => new
                {
                    CCFID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CTFID = table.Column<int>(type: "int", nullable: true),
                    CertificateID = table.Column<long>(type: "bigint", nullable: true),
                    FieldValue = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_CustomField", x => x.CCFID);
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_CustomField_Certificates",
                        column: x => x.CertificateID,
                        principalTable: "Certificates",
                        principalColumn: "CertificateID");
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_CustomField_MAP_CertificateType_Field",
                        column: x => x.CTFID,
                        principalTable: "MAP_CertificateType_Field",
                        principalColumn: "CTFID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_MDAService_SettlementMethod",
                columns: table => new
                {
                    ARSMID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MDAServiceID = table.Column<int>(type: "int", nullable: true),
                    SettlementMethodID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_MDAService_SettlementMethod", x => x.ARSMID);
                    table.ForeignKey(
                        name: "FK_MAP_MDAService_SettlementMethod_MDA_Services",
                        column: x => x.MDAServiceID,
                        principalTable: "MDA_Services",
                        principalColumn: "MDAServiceID");
                    table.ForeignKey(
                        name: "FK_MAP_MDAService_SettlementMethod_Settlement_Method",
                        column: x => x.SettlementMethodID,
                        principalTable: "Settlement_Method",
                        principalColumn: "SettlementMethodID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_ServiceBill_MDAService",
                columns: table => new
                {
                    SBSID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceBillID = table.Column<long>(type: "bigint", nullable: true),
                    MDAServiceID = table.Column<int>(type: "int", nullable: true),
                    ServiceBillYear = table.Column<int>(type: "int", nullable: true),
                    ServiceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_ServiceBill_MDAService", x => x.SBSID);
                    table.ForeignKey(
                        name: "FK_MAP_ServiceBill_MDAService_MDA_Services",
                        column: x => x.MDAServiceID,
                        principalTable: "MDA_Services",
                        principalColumn: "MDAServiceID");
                    table.ForeignKey(
                        name: "FK_MAP_ServiceBill_MDAService_ServiceBill",
                        column: x => x.ServiceBillID,
                        principalTable: "ServiceBill",
                        principalColumn: "ServiceBillID");
                });

            migrationBuilder.CreateTable(
                name: "MDA_Service_Items",
                columns: table => new
                {
                    MDAServiceItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MDAServiceItemReferenceNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueSubStreamID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemSubCategoryID = table.Column<int>(type: "int", nullable: true),
                    AgencyID = table.Column<int>(type: "int", nullable: true),
                    MDAServiceItemName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ComputationID = table.Column<int>(type: "int", nullable: false),
                    ServiceBaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ServiceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MDA_Service_Items", x => x.MDAServiceItemID);
                    table.ForeignKey(
                        name: "FK_MDA_Service_Items_Agencies",
                        column: x => x.AgencyID,
                        principalTable: "Agencies",
                        principalColumn: "AgencyID");
                    table.ForeignKey(
                        name: "FK_MDA_Service_Items_Assessment_Item_Category",
                        column: x => x.AssessmentItemCategoryID,
                        principalTable: "Assessment_Item_Category",
                        principalColumn: "AssessmentItemCategoryID");
                    table.ForeignKey(
                        name: "FK_MDA_Service_Items_Assessment_Item_SubCategory",
                        column: x => x.AssessmentItemSubCategoryID,
                        principalTable: "Assessment_Item_SubCategory",
                        principalColumn: "AssessmentItemSubCategoryID");
                    table.ForeignKey(
                        name: "FK_MDA_Service_Items_MST_Computation",
                        column: x => x.ComputationID,
                        principalTable: "MST_Computation",
                        principalColumn: "ComputationID");
                    table.ForeignKey(
                        name: "FK_MDA_Service_Items_Revenue_Stream",
                        column: x => x.RevenueStreamID,
                        principalTable: "Revenue_Stream",
                        principalColumn: "RevenueStreamID");
                    table.ForeignKey(
                        name: "FK_MDA_Service_Items_Revenue_SubStream",
                        column: x => x.RevenueSubStreamID,
                        principalTable: "Revenue_SubStream",
                        principalColumn: "RevenueSubStreamID");
                });

            migrationBuilder.CreateTable(
                name: "Payment_Account",
                columns: table => new
                {
                    PaymentAccountID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueSubStreamID = table.Column<int>(type: "int", nullable: true),
                    AgencyID = table.Column<int>(type: "int", nullable: true),
                    SettlementMethodID = table.Column<int>(type: "int", nullable: true),
                    SettlementStatusID = table.Column<int>(type: "int", nullable: true),
                    TransactionRefNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    isManualEntry = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Account", x => x.PaymentAccountID);
                    table.ForeignKey(
                        name: "FK_Payment_Account_Revenue_Stream",
                        column: x => x.RevenueStreamID,
                        principalTable: "Revenue_Stream",
                        principalColumn: "RevenueStreamID");
                    table.ForeignKey(
                        name: "FK_Payment_Account_Revenue_SubStream",
                        column: x => x.RevenueSubStreamID,
                        principalTable: "Revenue_SubStream",
                        principalColumn: "RevenueSubStreamID");
                    table.ForeignKey(
                        name: "FK_Payment_Account_Settlement_Method",
                        column: x => x.SettlementMethodID,
                        principalTable: "Settlement_Method",
                        principalColumn: "SettlementMethodID");
                    table.ForeignKey(
                        name: "FK_Payment_Account_Settlement_Status",
                        column: x => x.SettlementStatusID,
                        principalTable: "Settlement_Status",
                        principalColumn: "SettlementStatusID");
                    table.ForeignKey(
                        name: "FK_Payment_Account_TaxPayer_Types",
                        column: x => x.TaxPayerTypeID,
                        principalTable: "TaxPayer_Types",
                        principalColumn: "TaxPayerTypeID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TreasuryReceipt_Settlement",
                columns: table => new
                {
                    RSID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettlementID = table.Column<int>(type: "int", nullable: true),
                    ReceiptID = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TreasuryReceipt_Settlement", x => x.RSID);
                    table.ForeignKey(
                        name: "FK_MAP_TreasuryReceipt_Settlement_Settlement",
                        column: x => x.SettlementID,
                        principalTable: "Settlement",
                        principalColumn: "SettlementID");
                    table.ForeignKey(
                        name: "FK_MAP_TreasuryReceipt_Settlement_Treasury_Receipt",
                        column: x => x.ReceiptID,
                        principalTable: "Treasury_Receipt",
                        principalColumn: "ReceiptID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TaxPayer_Asset",
                columns: table => new
                {
                    TPAID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerRoleID = table.Column<int>(type: "int", nullable: true),
                    AssetID = table.Column<int>(type: "int", nullable: true),
                    BuildingUnitID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TaxPayer_Asset", x => x.TPAID);
                    table.ForeignKey(
                        name: "FK_MAP_TaxPayer_Asset_Asset_Types",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                    table.ForeignKey(
                        name: "FK_MAP_TaxPayer_Asset_TaxPayer_Roles",
                        column: x => x.TaxPayerRoleID,
                        principalTable: "TaxPayer_Roles",
                        principalColumn: "TaxPayerRoleID");
                    table.ForeignKey(
                        name: "FK_MAP_TaxPayer_Asset_TaxPayer_Types",
                        column: x => x.TaxPayerID,
                        principalTable: "TaxPayer_Types",
                        principalColumn: "TaxPayerTypeID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TCCRequest_Generate_Field",
                columns: table => new
                {
                    RGFID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PFID = table.Column<int>(type: "int", nullable: true),
                    RGID = table.Column<long>(type: "bigint", nullable: true),
                    FieldID = table.Column<int>(type: "int", nullable: true),
                    FieldValue = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TCCRequest_Generate_Field", x => x.RGFID);
                    table.ForeignKey(
                        name: "FK_MAP_TCCRequest_Generate_Field_MAP_TCCRequest_Generate",
                        column: x => x.RGID,
                        principalTable: "MAP_TCCRequest_Generate",
                        principalColumn: "RGID");
                });

            migrationBuilder.CreateTable(
                name: "Building_Unit",
                columns: table => new
                {
                    BuildingUnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingUnitRIN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    UnitNumber = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    UnitPurposeID = table.Column<int>(type: "int", nullable: true),
                    UnitFunctionID = table.Column<int>(type: "int", nullable: true),
                    UnitOccupancyID = table.Column<int>(type: "int", nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building_Unit", x => x.BuildingUnitID);
                    table.ForeignKey(
                        name: "FK_Building_Unit_Sizes",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "SizeID");
                    table.ForeignKey(
                        name: "FK_Building_Unit_Unit_Function",
                        column: x => x.UnitFunctionID,
                        principalTable: "Unit_Function",
                        principalColumn: "UnitFunctionID");
                    table.ForeignKey(
                        name: "FK_Building_Unit_Unit_Occupancy",
                        column: x => x.UnitOccupancyID,
                        principalTable: "Unit_Occupancy",
                        principalColumn: "UnitOccupancyID");
                    table.ForeignKey(
                        name: "FK_Building_Unit_Unit_Purpose",
                        column: x => x.UnitPurposeID,
                        principalTable: "Unit_Purpose",
                        principalColumn: "UnitPurposeID");
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleRIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VehicleRegNumber = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    VehicleTypeID = table.Column<int>(type: "int", nullable: true),
                    VehicleSubTypeID = table.Column<int>(type: "int", nullable: true),
                    LGAID = table.Column<int>(type: "int", nullable: true),
                    VehiclePurposeID = table.Column<int>(type: "int", nullable: true),
                    VehicleFunctionID = table.Column<int>(type: "int", nullable: true),
                    VehicleOwnershipID = table.Column<int>(type: "int", nullable: true),
                    VehicleDescription = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleID);
                    table.ForeignKey(
                        name: "FK_Vehicle_Asset_Types",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                    table.ForeignKey(
                        name: "FK_Vehicle_LGA",
                        column: x => x.LGAID,
                        principalTable: "LGA",
                        principalColumn: "LGAID");
                    table.ForeignKey(
                        name: "FK_Vehicle_Vehicle_Function",
                        column: x => x.VehicleFunctionID,
                        principalTable: "Vehicle_Function",
                        principalColumn: "VehicleFunctionID");
                    table.ForeignKey(
                        name: "FK_Vehicle_Vehicle_Ownership",
                        column: x => x.VehicleOwnershipID,
                        principalTable: "Vehicle_Ownership",
                        principalColumn: "VehicleOwnershipID");
                    table.ForeignKey(
                        name: "FK_Vehicle_Vehicle_Purpose",
                        column: x => x.VehiclePurposeID,
                        principalTable: "Vehicle_Purpose",
                        principalColumn: "VehiclePurposeID");
                    table.ForeignKey(
                        name: "FK_Vehicle_Vehicle_SubTypes",
                        column: x => x.VehicleSubTypeID,
                        principalTable: "Vehicle_SubTypes",
                        principalColumn: "VehicleSubTypeID");
                    table.ForeignKey(
                        name: "FK_Vehicle_Vehicle_Types",
                        column: x => x.VehicleTypeID,
                        principalTable: "Vehicle_Types",
                        principalColumn: "VehicleTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Assessment_Items",
                columns: table => new
                {
                    AssessmentItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentItemReferenceNo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    AssessmentGroupID = table.Column<int>(type: "int", nullable: true),
                    AssessmentSubGroupID = table.Column<int>(type: "int", nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    RevenueSubStreamID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemSubCategoryID = table.Column<int>(type: "int", nullable: true),
                    AgencyID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ComputationID = table.Column<int>(type: "int", nullable: true),
                    TaxBaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment_Items", x => x.AssessmentItemID);
                    table.ForeignKey(
                        name: "FK_Assessment_Items_Agencies",
                        column: x => x.AgencyID,
                        principalTable: "Agencies",
                        principalColumn: "AgencyID");
                    table.ForeignKey(
                        name: "FK_Assessment_Items_Assessment_Group",
                        column: x => x.AssessmentGroupID,
                        principalTable: "Assessment_Group",
                        principalColumn: "AssessmentGroupID");
                    table.ForeignKey(
                        name: "FK_Assessment_Items_Assessment_Item_Category",
                        column: x => x.AssessmentItemCategoryID,
                        principalTable: "Assessment_Item_Category",
                        principalColumn: "AssessmentItemCategoryID");
                    table.ForeignKey(
                        name: "FK_Assessment_Items_Assessment_Item_SubCategory",
                        column: x => x.AssessmentItemSubCategoryID,
                        principalTable: "Assessment_Item_SubCategory",
                        principalColumn: "AssessmentItemSubCategoryID");
                    table.ForeignKey(
                        name: "FK_Assessment_Items_Assessment_SubGroup",
                        column: x => x.AssessmentSubGroupID,
                        principalTable: "Assessment_SubGroup",
                        principalColumn: "AssessmentSubGroupID");
                    table.ForeignKey(
                        name: "FK_Assessment_Items_Asset_Types",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                    table.ForeignKey(
                        name: "FK_Assessment_Items_MST_Computation",
                        column: x => x.ComputationID,
                        principalTable: "MST_Computation",
                        principalColumn: "ComputationID");
                    table.ForeignKey(
                        name: "FK_Assessment_Items_Revenue_Stream",
                        column: x => x.RevenueStreamID,
                        principalTable: "Revenue_Stream",
                        principalColumn: "RevenueStreamID");
                    table.ForeignKey(
                        name: "FK_Assessment_Items_Revenue_SubStream",
                        column: x => x.RevenueSubStreamID,
                        principalTable: "Revenue_SubStream",
                        principalColumn: "RevenueSubStreamID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_AssessmentRule_SettlementMethod",
                columns: table => new
                {
                    ARSMID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentRuleID = table.Column<int>(type: "int", nullable: true),
                    SettlementMethodID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_AssessmentRule_SettlementMethod", x => x.ARSMID);
                    table.ForeignKey(
                        name: "FK_MAP_AssessmentRule_SettlementMethod_Assessment_Rules",
                        column: x => x.AssessmentRuleID,
                        principalTable: "Assessment_Rules",
                        principalColumn: "AssessmentRuleID");
                    table.ForeignKey(
                        name: "FK_MAP_AssessmentRule_SettlementMethod_Settlement_Method",
                        column: x => x.SettlementMethodID,
                        principalTable: "Settlement_Method",
                        principalColumn: "SettlementMethodID");
                });

            migrationBuilder.CreateTable(
                name: "Business_SubSector",
                columns: table => new
                {
                    BusinessSubSectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessSubSectorName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BusinessSectorID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_SubSector", x => x.BusinessSubSectorID);
                    table.ForeignKey(
                        name: "FK_Business_SubSector_Business_Sector",
                        column: x => x.BusinessSectorID,
                        principalTable: "Business_Sector",
                        principalColumn: "BusinessSectorID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Certificate_Generate_Field",
                columns: table => new
                {
                    CGFID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PFID = table.Column<int>(type: "int", nullable: true),
                    CGID = table.Column<long>(type: "bigint", nullable: true),
                    FieldID = table.Column<int>(type: "int", nullable: true),
                    FieldValue = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Certificate_Generate_Field", x => x.CGFID);
                    table.ForeignKey(
                        name: "FK_MAP_Certificate_Generate_Field_MAP_Certificate_Generate",
                        column: x => x.CGID,
                        principalTable: "MAP_Certificate_Generate",
                        principalColumn: "CGID");
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    BuildingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingRIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BuildingTagNumber = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BuildingName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BuildingNumber = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    StreetName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    OffStreetName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TownID = table.Column<int>(type: "int", nullable: true),
                    LGAID = table.Column<int>(type: "int", nullable: true),
                    WardID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    BuildingTypeID = table.Column<int>(type: "int", nullable: true),
                    BuildingCompletionID = table.Column<int>(type: "int", nullable: true),
                    BuildingPurposeID = table.Column<int>(type: "int", nullable: true),
                    BuildingOwnershipID = table.Column<int>(type: "int", nullable: true),
                    NoOfUnits = table.Column<int>(type: "int", nullable: true),
                    Latitude = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Longitude = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BuildingSize_Length = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BuildingSize_Width = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BuildingID);
                    table.ForeignKey(
                        name: "FK_Building_Asset_Types",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                    table.ForeignKey(
                        name: "FK_Building_Building_Completion",
                        column: x => x.BuildingCompletionID,
                        principalTable: "Building_Completion",
                        principalColumn: "BuildingCompletionID");
                    table.ForeignKey(
                        name: "FK_Building_Building_Ownership",
                        column: x => x.BuildingOwnershipID,
                        principalTable: "Building_Ownership",
                        principalColumn: "BuildingOwnershipID");
                    table.ForeignKey(
                        name: "FK_Building_Building_Purpose",
                        column: x => x.BuildingPurposeID,
                        principalTable: "Building_Purpose",
                        principalColumn: "BuildingPurposeID");
                    table.ForeignKey(
                        name: "FK_Building_Building_Types",
                        column: x => x.BuildingTypeID,
                        principalTable: "Building_Types",
                        principalColumn: "BuildingTypeID");
                    table.ForeignKey(
                        name: "FK_Building_LGA",
                        column: x => x.LGAID,
                        principalTable: "LGA",
                        principalColumn: "LGAID");
                    table.ForeignKey(
                        name: "FK_Building_Town",
                        column: x => x.TownID,
                        principalTable: "Town",
                        principalColumn: "TownID");
                    table.ForeignKey(
                        name: "FK_Building_Ward",
                        column: x => x.WardID,
                        principalTable: "Ward",
                        principalColumn: "WardID");
                });

            migrationBuilder.CreateTable(
                name: "Land",
                columns: table => new
                {
                    LandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandRIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    PlotNumber = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    StreetName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TownID = table.Column<int>(type: "int", nullable: true),
                    LGAID = table.Column<int>(type: "int", nullable: true),
                    WardID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    LandSize_Length = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LandSize_Width = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    C_OF_O_Ref = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    LandDevelopmentID = table.Column<int>(type: "int", nullable: true),
                    LandPurposeID = table.Column<int>(type: "int", nullable: true),
                    LandFunctionID = table.Column<int>(type: "int", nullable: true),
                    LandOwnershipID = table.Column<int>(type: "int", nullable: true),
                    Latitude = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Longitude = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ValueOfLand = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LandStreetConditionID = table.Column<int>(type: "int", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LandOccupier = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Land", x => x.LandID);
                    table.ForeignKey(
                        name: "FK_Land_Asset_Types",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                    table.ForeignKey(
                        name: "FK_Land_LGA",
                        column: x => x.LGAID,
                        principalTable: "LGA",
                        principalColumn: "LGAID");
                    table.ForeignKey(
                        name: "FK_Land_Land_Development",
                        column: x => x.LandDevelopmentID,
                        principalTable: "Land_Development",
                        principalColumn: "LandDevelopmentID");
                    table.ForeignKey(
                        name: "FK_Land_Land_Function",
                        column: x => x.LandFunctionID,
                        principalTable: "Land_Function",
                        principalColumn: "LandFunctionID");
                    table.ForeignKey(
                        name: "FK_Land_Land_Ownership",
                        column: x => x.LandOwnershipID,
                        principalTable: "Land_Ownership",
                        principalColumn: "LandOwnershipID");
                    table.ForeignKey(
                        name: "FK_Land_Land_Purpose",
                        column: x => x.LandPurposeID,
                        principalTable: "Land_Purpose",
                        principalColumn: "LandPurposeID");
                    table.ForeignKey(
                        name: "FK_Land_Land_StreetCondition",
                        column: x => x.LandStreetConditionID,
                        principalTable: "Land_StreetCondition",
                        principalColumn: "LandStreetConditionID");
                    table.ForeignKey(
                        name: "FK_Land_Town",
                        column: x => x.TownID,
                        principalTable: "Town",
                        principalColumn: "TownID");
                    table.ForeignKey(
                        name: "FK_Land_Ward",
                        column: x => x.WardID,
                        principalTable: "Ward",
                        principalColumn: "WardID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_MDAService_MDAServiceItem",
                columns: table => new
                {
                    MSMSIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MDAServiceID = table.Column<int>(type: "int", nullable: true),
                    MDAServiceItemID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_MDAService_MDAServiceItem", x => x.MSMSIID);
                    table.ForeignKey(
                        name: "FK_MAP_MDAService_MDAServiceItem_MDAService_Items",
                        column: x => x.MDAServiceItemID,
                        principalTable: "MDA_Service_Items",
                        principalColumn: "MDAServiceItemID");
                    table.ForeignKey(
                        name: "FK_MAP_MDAService_MDAServiceItem_MDA_Services",
                        column: x => x.MDAServiceID,
                        principalTable: "MDA_Services",
                        principalColumn: "MDAServiceID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_ServiceBill_MDAServiceItem",
                columns: table => new
                {
                    SBSIID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SBSID = table.Column<long>(type: "bigint", nullable: true),
                    MDAServiceItemID = table.Column<int>(type: "int", nullable: true),
                    ServiceBaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ServiceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentStatusID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_ServiceBill_MDAServiceItem", x => x.SBSIID);
                    table.ForeignKey(
                        name: "FK_MAP_ServiceBill_MDAServiceItem_MAP_ServiceBill_MDAService",
                        column: x => x.SBSID,
                        principalTable: "MAP_ServiceBill_MDAService",
                        principalColumn: "SBSID");
                    table.ForeignKey(
                        name: "FK_MAP_ServiceBill_MDAServiceItem_MDA_Service_Items",
                        column: x => x.MDAServiceItemID,
                        principalTable: "MDA_Service_Items",
                        principalColumn: "MDAServiceItemID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TaxPayer_Asset_Profile",
                columns: table => new
                {
                    TPAPID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TPAID = table.Column<long>(type: "bigint", nullable: true),
                    ProfileID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TaxPayer_Asset_Profile", x => x.TPAPID);
                    table.ForeignKey(
                        name: "FK_MAP_TaxPayer_Asset_Profile_MAP_TaxPayer_Asset",
                        column: x => x.TPAID,
                        principalTable: "MAP_TaxPayer_Asset",
                        principalColumn: "TPAID");
                    table.ForeignKey(
                        name: "FK_MAP_TaxPayer_Asset_Profile_Profiles",
                        column: x => x.ProfileID,
                        principalTable: "Profiles_BKP",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_Insurance",
                columns: table => new
                {
                    VehicleInsuranceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(type: "int", nullable: true),
                    InsuranceCertificateNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CoverTypeID = table.Column<int>(type: "int", nullable: true),
                    InsuranceStatusID = table.Column<int>(type: "int", nullable: true),
                    PremiumAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VerificationAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrokerAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Insurance", x => x.VehicleInsuranceID);
                    table.ForeignKey(
                        name: "FK_Vehicle_Insurance_Vehicle",
                        column: x => x.VehicleID,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Assessment_AssessmentItem",
                columns: table => new
                {
                    AAIID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AARID = table.Column<long>(type: "bigint", nullable: true),
                    AssessmentItemID = table.Column<int>(type: "int", nullable: true),
                    TaxBaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentStatusID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Assessment_AssessmentItem", x => x.AAIID);
                    table.ForeignKey(
                        name: "FK_MAP_Assessment_AssessmentItem_Assessment_Items",
                        column: x => x.AssessmentItemID,
                        principalTable: "Assessment_Items",
                        principalColumn: "AssessmentItemID");
                    table.ForeignKey(
                        name: "FK_MAP_Assessment_AssessmentItem_MAP_Assessment_AssessmentRule",
                        column: x => x.AARID,
                        principalTable: "MAP_Assessment_AssessmentRule",
                        principalColumn: "AARID");
                    table.ForeignKey(
                        name: "FK_MAP_Assessment_AssessmentItem_MST_PaymentStatus",
                        column: x => x.PaymentStatusID,
                        principalTable: "MST_PaymentStatus",
                        principalColumn: "PaymentStatusID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_AssessmentRule_AssessmentItem",
                columns: table => new
                {
                    ARAIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentRuleID = table.Column<int>(type: "int", nullable: true),
                    AssessmentItemID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_AssessmentRule_AssessmentItem", x => x.ARAIID);
                    table.ForeignKey(
                        name: "FK_MAP_AssessmentRule_AssessmentItem_Assessment_Items",
                        column: x => x.AssessmentItemID,
                        principalTable: "Assessment_Items",
                        principalColumn: "AssessmentItemID");
                    table.ForeignKey(
                        name: "FK_MAP_AssessmentRule_AssessmentItem_Assessment_Rules",
                        column: x => x.AssessmentRuleID,
                        principalTable: "Assessment_Rules",
                        principalColumn: "AssessmentRuleID");
                });

            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    BusinessID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTypeID = table.Column<int>(type: "int", nullable: true),
                    BusinessRIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BusinessName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LGAID = table.Column<int>(type: "int", nullable: true),
                    AssetTypeID = table.Column<int>(type: "int", nullable: true),
                    BusinessCategoryID = table.Column<int>(type: "int", nullable: true),
                    BusinessSectorID = table.Column<int>(type: "int", nullable: true),
                    BusinessSubSectorID = table.Column<int>(type: "int", nullable: true),
                    BusinessStructureID = table.Column<int>(type: "int", nullable: true),
                    BusinessOperationID = table.Column<int>(type: "int", nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: true),
                    ContactName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BusinessNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BusinessAddress = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true),
                    ZoneId = table.Column<int>(type: "int", nullable: true),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.BusinessID);
                    table.ForeignKey(
                        name: "FK_Business_Asset_Types",
                        column: x => x.AssetTypeID,
                        principalTable: "Asset_Types",
                        principalColumn: "AssetTypeID");
                    table.ForeignKey(
                        name: "FK_Business_Business_Category",
                        column: x => x.BusinessCategoryID,
                        principalTable: "Business_Category",
                        principalColumn: "BusinessCategoryID");
                    table.ForeignKey(
                        name: "FK_Business_Business_Operation",
                        column: x => x.BusinessOperationID,
                        principalTable: "Business_Operation",
                        principalColumn: "BusinessOperationID");
                    table.ForeignKey(
                        name: "FK_Business_Business_Sector",
                        column: x => x.BusinessSectorID,
                        principalTable: "Business_Sector",
                        principalColumn: "BusinessSectorID");
                    table.ForeignKey(
                        name: "FK_Business_Business_Structure",
                        column: x => x.BusinessStructureID,
                        principalTable: "Business_Structure",
                        principalColumn: "BusinessStructureID");
                    table.ForeignKey(
                        name: "FK_Business_Business_SubSector",
                        column: x => x.BusinessSubSectorID,
                        principalTable: "Business_SubSector",
                        principalColumn: "BusinessSubSectorID");
                    table.ForeignKey(
                        name: "FK_Business_Business_Types",
                        column: x => x.BusinessTypeID,
                        principalTable: "Business_Types",
                        principalColumn: "BusinessTypeID");
                    table.ForeignKey(
                        name: "FK_Business_LGA",
                        column: x => x.LGAID,
                        principalTable: "LGA",
                        principalColumn: "LGAID");
                    table.ForeignKey(
                        name: "FK_Business_Sizes",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "SizeID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Building_BuildingUnit",
                columns: table => new
                {
                    BBUID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingID = table.Column<int>(type: "int", nullable: true),
                    BuildingUnitID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Building_BuildingUnit", x => x.BBUID);
                    table.ForeignKey(
                        name: "FK_MAP_Building_BuildingUnit_Building",
                        column: x => x.BuildingID,
                        principalTable: "Building",
                        principalColumn: "BuildingID");
                    table.ForeignKey(
                        name: "FK_MAP_Building_BuildingUnit_Building_Unit",
                        column: x => x.BuildingUnitID,
                        principalTable: "Building_Unit",
                        principalColumn: "BuildingUnitID");
                });

            migrationBuilder.CreateTable(
                name: "Tax_Offices",
                columns: table => new
                {
                    TaxOfficeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxOfficeName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    AddressTypeID = table.Column<int>(type: "int", nullable: true),
                    BuildingID = table.Column<int>(type: "int", nullable: true),
                    Approver1 = table.Column<int>(type: "int", nullable: true),
                    Approver2 = table.Column<int>(type: "int", nullable: true),
                    Approver3 = table.Column<int>(type: "int", nullable: true),
                    ZoneId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax_Offices", x => x.TaxOfficeID);
                    table.ForeignKey(
                        name: "FK_Tax_Offices_Address_Types",
                        column: x => x.AddressTypeID,
                        principalTable: "Address_Types",
                        principalColumn: "AddressTypeID");
                    table.ForeignKey(
                        name: "FK_Tax_Offices_Building",
                        column: x => x.BuildingID,
                        principalTable: "Building",
                        principalColumn: "BuildingID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Building_Land",
                columns: table => new
                {
                    BLID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingID = table.Column<int>(type: "int", nullable: true),
                    LandID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Building_Land", x => x.BLID);
                    table.ForeignKey(
                        name: "FK_MAP_Building_Land_Building",
                        column: x => x.BuildingID,
                        principalTable: "Building",
                        principalColumn: "BuildingID");
                    table.ForeignKey(
                        name: "FK_MAP_Building_Land_Land",
                        column: x => x.LandID,
                        principalTable: "Land",
                        principalColumn: "LandID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_ServiceBill_Adjustment",
                columns: table => new
                {
                    SADID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SBSIID = table.Column<long>(type: "bigint", nullable: true),
                    AdjustmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdjustmentTypeID = table.Column<int>(type: "int", nullable: true),
                    AdjustmentLine = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_ServiceBill_Adjustment", x => x.SADID);
                    table.ForeignKey(
                        name: "FK_MAP_ServiceBill_Adjustment_MAP_ServiceBill_MDAServiceItem",
                        column: x => x.SBSIID,
                        principalTable: "MAP_ServiceBill_MDAServiceItem",
                        principalColumn: "SBSIID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_ServiceBill_LateCharge",
                columns: table => new
                {
                    SLCID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SBSIID = table.Column<long>(type: "bigint", nullable: true),
                    ChargeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Penalty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Interest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_ServiceBill_LateCharge", x => x.SLCID);
                    table.ForeignKey(
                        name: "FK_MAP_ServiceBill_LateCharge_MAP_ServiceBill_MDAServiceItem",
                        column: x => x.SBSIID,
                        principalTable: "MAP_ServiceBill_MDAServiceItem",
                        principalColumn: "SBSIID");
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_Licenses",
                columns: table => new
                {
                    VehicleLicenseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(type: "int", nullable: true),
                    LicenseNumber = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VehicleInsuranceID = table.Column<int>(type: "int", nullable: true),
                    LicenseStatusID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Licenses", x => x.VehicleLicenseID);
                    table.ForeignKey(
                        name: "FK_Vehicle_Licenses_Vehicle",
                        column: x => x.VehicleID,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleID");
                    table.ForeignKey(
                        name: "FK_Vehicle_Licenses_Vehicle_Insurance",
                        column: x => x.VehicleInsuranceID,
                        principalTable: "Vehicle_Insurance",
                        principalColumn: "VehicleInsuranceID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Assessment_Adjustment",
                columns: table => new
                {
                    AADID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AAIID = table.Column<long>(type: "bigint", nullable: true),
                    AdjustmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AdjustmentTypeID = table.Column<int>(type: "int", nullable: true),
                    AdjustmentLine = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Assessment_Adjustment", x => x.AADID);
                    table.ForeignKey(
                        name: "FK_MAP_Assessment_Adjustment_MAP_Assessment_AssessmentItem",
                        column: x => x.AAIID,
                        principalTable: "MAP_Assessment_AssessmentItem",
                        principalColumn: "AAIID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Settlement_SettlementItem",
                columns: table => new
                {
                    SIID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettlementID = table.Column<int>(type: "int", nullable: true),
                    AAIID = table.Column<long>(type: "bigint", nullable: true),
                    SBSIID = table.Column<long>(type: "bigint", nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SettlementAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Settlement_SettlementItem", x => x.SIID);
                    table.ForeignKey(
                        name: "FK_MAP_Settlement_SettlementItem_MAP_Assessment_AssessmentItem",
                        column: x => x.AAIID,
                        principalTable: "MAP_Assessment_AssessmentItem",
                        principalColumn: "AAIID");
                    table.ForeignKey(
                        name: "FK_MAP_Settlement_SettlementItem_MAP_ServiceBill_MDAServiceItem",
                        column: x => x.SBSIID,
                        principalTable: "MAP_ServiceBill_MDAServiceItem",
                        principalColumn: "SBSIID");
                    table.ForeignKey(
                        name: "FK_MAP_Settlement_SettlementItem_Settlement",
                        column: x => x.SettlementID,
                        principalTable: "Settlement",
                        principalColumn: "SettlementID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Business_Building",
                columns: table => new
                {
                    BBID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingID = table.Column<int>(type: "int", nullable: true),
                    BusinessID = table.Column<int>(type: "int", nullable: true),
                    BuildingUnitID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Business_Building", x => x.BBID);
                    table.ForeignKey(
                        name: "FK_MAP_Business_Building_Building",
                        column: x => x.BuildingID,
                        principalTable: "Building",
                        principalColumn: "BuildingID");
                    table.ForeignKey(
                        name: "FK_MAP_Business_Building_Business",
                        column: x => x.BusinessID,
                        principalTable: "Business",
                        principalColumn: "BusinessID");
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyRIN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Password = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MobileNumber1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MobileNumber2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    EmailAddress1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    EmailAddress2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    EconomicActivitiesID = table.Column<int>(type: "int", nullable: true),
                    NotificationMethodID = table.Column<int>(type: "int", nullable: true),
                    ContactAddress = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    RegisterationStatusID = table.Column<int>(type: "int", nullable: true),
                    RegisterationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VerificationOTP = table.Column<int>(type: "int", nullable: true),
                    TaxOfficerID = table.Column<int>(type: "int", nullable: true),
                    CACRegistrationNumber = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true),
                    CAC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Company_Economic_Activities",
                        column: x => x.EconomicActivitiesID,
                        principalTable: "Economic_Activities",
                        principalColumn: "EconomicActivitiesID");
                    table.ForeignKey(
                        name: "FK_Company_MST_RegisterationStatus",
                        column: x => x.RegisterationStatusID,
                        principalTable: "MST_RegisterationStatus",
                        principalColumn: "RegisterationStatusID");
                    table.ForeignKey(
                        name: "FK_Company_Notification_Method",
                        column: x => x.NotificationMethodID,
                        principalTable: "Notification_Method",
                        principalColumn: "NotificationMethodID");
                    table.ForeignKey(
                        name: "FK_Company_TaxPayer_Types",
                        column: x => x.TaxPayerTypeID,
                        principalTable: "TaxPayer_Types",
                        principalColumn: "TaxPayerTypeID");
                    table.ForeignKey(
                        name: "FK_Company_Tax_Offices",
                        column: x => x.TaxOfficeID,
                        principalTable: "Tax_Offices",
                        principalColumn: "TaxOfficeID");
                });

            migrationBuilder.CreateTable(
                name: "Government",
                columns: table => new
                {
                    GovernmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernmentRIN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Password = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    GovernmentName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    GovernmentTypeID = table.Column<int>(type: "int", nullable: true),
                    TIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    ContactNumber = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ContactEmail = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ContactName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    NotificationMethodID = table.Column<int>(type: "int", nullable: true),
                    ContactAddress = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    RegisterationStatusID = table.Column<int>(type: "int", nullable: true),
                    RegisterationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VerificationOTP = table.Column<int>(type: "int", nullable: true),
                    TaxOfficerID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Government", x => x.GovernmentID);
                    table.ForeignKey(
                        name: "FK_Government_Government_Types",
                        column: x => x.GovernmentTypeID,
                        principalTable: "Government_Types",
                        principalColumn: "GovernmentTypeID");
                    table.ForeignKey(
                        name: "FK_Government_MST_RegisterationStatus",
                        column: x => x.RegisterationStatusID,
                        principalTable: "MST_RegisterationStatus",
                        principalColumn: "RegisterationStatusID");
                    table.ForeignKey(
                        name: "FK_Government_Notification_Method",
                        column: x => x.NotificationMethodID,
                        principalTable: "Notification_Method",
                        principalColumn: "NotificationMethodID");
                    table.ForeignKey(
                        name: "FK_Government_TaxPayer_Types",
                        column: x => x.TaxPayerTypeID,
                        principalTable: "TaxPayer_Types",
                        principalColumn: "TaxPayerTypeID");
                    table.ForeignKey(
                        name: "FK_Government_Tax_Offices",
                        column: x => x.TaxOfficeID,
                        principalTable: "Tax_Offices",
                        principalColumn: "TaxOfficeID");
                });

            migrationBuilder.CreateTable(
                name: "Individual",
                columns: table => new
                {
                    IndividualID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndividualRIN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Password = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    GenderID = table.Column<int>(type: "int", nullable: true),
                    TitleID = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    LastName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MiddleName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true),
                    TIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MobileNumber1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MobileNumber2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    EmailAddress1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    EmailAddress2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BiometricDetails = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true),
                    MaritalStatusID = table.Column<int>(type: "int", nullable: true),
                    NationalityID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    EconomicActivitiesID = table.Column<int>(type: "int", nullable: true),
                    NotificationMethodID = table.Column<int>(type: "int", nullable: true),
                    ContactAddress = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    RegisterationStatusID = table.Column<int>(type: "int", nullable: true),
                    RegisterationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VerificationOTP = table.Column<int>(type: "int", nullable: true),
                    TaxOfficerID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataSourceID = table.Column<int>(type: "int", nullable: true),
                    DSRefID = table.Column<long>(type: "bigint", nullable: true),
                    NIN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individual", x => x.IndividualID);
                    table.ForeignKey(
                        name: "FK_Individual_Economic_Activities",
                        column: x => x.EconomicActivitiesID,
                        principalTable: "Economic_Activities",
                        principalColumn: "EconomicActivitiesID");
                    table.ForeignKey(
                        name: "FK_Individual_Gender",
                        column: x => x.GenderID,
                        principalTable: "Gender",
                        principalColumn: "GenderID");
                    table.ForeignKey(
                        name: "FK_Individual_MST_RegisterationStatus",
                        column: x => x.RegisterationStatusID,
                        principalTable: "MST_RegisterationStatus",
                        principalColumn: "RegisterationStatusID");
                    table.ForeignKey(
                        name: "FK_Individual_MaritalStatus",
                        column: x => x.MaritalStatusID,
                        principalTable: "MaritalStatus",
                        principalColumn: "MaritalStatusID");
                    table.ForeignKey(
                        name: "FK_Individual_Nationality",
                        column: x => x.NationalityID,
                        principalTable: "Nationality",
                        principalColumn: "NationalityID");
                    table.ForeignKey(
                        name: "FK_Individual_Notification_Method",
                        column: x => x.NotificationMethodID,
                        principalTable: "Notification_Method",
                        principalColumn: "NotificationMethodID");
                    table.ForeignKey(
                        name: "FK_Individual_TaxPayer_Types",
                        column: x => x.TaxPayerTypeID,
                        principalTable: "TaxPayer_Types",
                        principalColumn: "TaxPayerTypeID");
                    table.ForeignKey(
                        name: "FK_Individual_Tax_Offices",
                        column: x => x.TaxOfficeID,
                        principalTable: "Tax_Offices",
                        principalColumn: "TaxOfficeID");
                    table.ForeignKey(
                        name: "FK_Individual_Titles",
                        column: x => x.TitleID,
                        principalTable: "Titles",
                        principalColumn: "TitleID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TaxOffice_Target",
                columns: table => new
                {
                    TOTID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    TargetAmount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TaxOffice_Target", x => x.TOTID);
                    table.ForeignKey(
                        name: "FK_MAP_TaxOffice_Target_Revenue_Stream",
                        column: x => x.RevenueStreamID,
                        principalTable: "Revenue_Stream",
                        principalColumn: "RevenueStreamID");
                    table.ForeignKey(
                        name: "FK_MAP_TaxOffice_Target_Tax_Offices",
                        column: x => x.TaxOfficeID,
                        principalTable: "Tax_Offices",
                        principalColumn: "TaxOfficeID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_TaxOfficer_Target",
                columns: table => new
                {
                    TOTID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true),
                    TaxOfficerID = table.Column<int>(type: "int", nullable: true),
                    TaxYear = table.Column<int>(type: "int", nullable: true),
                    RevenueStreamID = table.Column<int>(type: "int", nullable: true),
                    TargetAmount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_TaxOfficer_Target", x => x.TOTID);
                    table.ForeignKey(
                        name: "FK_MAP_TaxOfficer_Target_Revenue_Stream",
                        column: x => x.RevenueStreamID,
                        principalTable: "Revenue_Stream",
                        principalColumn: "RevenueStreamID");
                    table.ForeignKey(
                        name: "FK_MAP_TaxOfficer_Target_Tax_Offices",
                        column: x => x.TaxOfficeID,
                        principalTable: "Tax_Offices",
                        principalColumn: "TaxOfficeID");
                });

            migrationBuilder.CreateTable(
                name: "Special",
                columns: table => new
                {
                    SpecialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialRIN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SpecialTaxPayerName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TaxOfficeID = table.Column<int>(type: "int", nullable: true),
                    TaxPayerTypeID = table.Column<int>(type: "int", nullable: true),
                    ContactNumber = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ContactEmail = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ContactName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    NotificationMethodID = table.Column<int>(type: "int", nullable: true),
                    TaxOfficerID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special", x => x.SpecialID);
                    table.ForeignKey(
                        name: "FK_Special_Notification_Method",
                        column: x => x.NotificationMethodID,
                        principalTable: "Notification_Method",
                        principalColumn: "NotificationMethodID");
                    table.ForeignKey(
                        name: "FK_Special_TaxPayer_Types",
                        column: x => x.TaxPayerTypeID,
                        principalTable: "TaxPayer_Types",
                        principalColumn: "TaxPayerTypeID");
                    table.ForeignKey(
                        name: "FK_Special_Tax_Offices",
                        column: x => x.TaxOfficeID,
                        principalTable: "Tax_Offices",
                        principalColumn: "TaxOfficeID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Company_AddressInformation",
                columns: table => new
                {
                    CAIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    AddressTypeID = table.Column<int>(type: "int", nullable: true),
                    BuildingID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Company_AddressInformation", x => x.CAIID);
                    table.ForeignKey(
                        name: "FK_MAP_Company_AddressInformation_Address_Types",
                        column: x => x.AddressTypeID,
                        principalTable: "Address_Types",
                        principalColumn: "AddressTypeID");
                    table.ForeignKey(
                        name: "FK_MAP_Company_AddressInformation_Building",
                        column: x => x.BuildingID,
                        principalTable: "Building",
                        principalColumn: "BuildingID");
                    table.ForeignKey(
                        name: "FK_MAP_Company_AddressInformation_Company",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Government_AddressInformation",
                columns: table => new
                {
                    GAIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernmentID = table.Column<int>(type: "int", nullable: true),
                    AddressTypeID = table.Column<int>(type: "int", nullable: true),
                    BuildingID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Government_AddressInformation", x => x.GAIID);
                    table.ForeignKey(
                        name: "FK_MAP_Government_AddressInformation_Address_Types",
                        column: x => x.AddressTypeID,
                        principalTable: "Address_Types",
                        principalColumn: "AddressTypeID");
                    table.ForeignKey(
                        name: "FK_MAP_Government_AddressInformation_Building",
                        column: x => x.BuildingID,
                        principalTable: "Building",
                        principalColumn: "BuildingID");
                    table.ForeignKey(
                        name: "FK_MAP_Government_AddressInformation_Government",
                        column: x => x.GovernmentID,
                        principalTable: "Government",
                        principalColumn: "GovernmentID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Individual_AddressInformation",
                columns: table => new
                {
                    IAIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndividualID = table.Column<int>(type: "int", nullable: true),
                    AddressTypeID = table.Column<int>(type: "int", nullable: true),
                    BuildingID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Individual_AddressInformation", x => x.IAIID);
                    table.ForeignKey(
                        name: "FK_MAP_Individual_AddressInformation_Address_Types",
                        column: x => x.AddressTypeID,
                        principalTable: "Address_Types",
                        principalColumn: "AddressTypeID");
                    table.ForeignKey(
                        name: "FK_MAP_Individual_AddressInformation_Building",
                        column: x => x.BuildingID,
                        principalTable: "Building",
                        principalColumn: "BuildingID");
                    table.ForeignKey(
                        name: "FK_MAP_Individual_AddressInformation_Individual",
                        column: x => x.IndividualID,
                        principalTable: "Individual",
                        principalColumn: "IndividualID");
                });

            migrationBuilder.CreateTable(
                name: "MAP_Special_AddressInformation",
                columns: table => new
                {
                    SAIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialID = table.Column<int>(type: "int", nullable: true),
                    AddressTypeID = table.Column<int>(type: "int", nullable: true),
                    BuildingID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAP_Special_AddressInformation", x => x.SAIID);
                    table.ForeignKey(
                        name: "FK_MAP_Special_AddressInformation_Address_Types",
                        column: x => x.AddressTypeID,
                        principalTable: "Address_Types",
                        principalColumn: "AddressTypeID");
                    table.ForeignKey(
                        name: "FK_MAP_Special_AddressInformation_Building",
                        column: x => x.BuildingID,
                        principalTable: "Building",
                        principalColumn: "BuildingID");
                    table.ForeignKey(
                        name: "FK_MAP_Special_AddressInformation_Special",
                        column: x => x.SpecialID,
                        principalTable: "Special",
                        principalColumn: "SpecialID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agencies_AgencyTypeID",
                table: "Agencies",
                column: "AgencyTypeID");

            migrationBuilder.CreateIndex(
                name: "IDX_ASS_TPTID",
                table: "Assessment",
                column: "TaxPayerTypeID");

            migrationBuilder.CreateIndex(
                name: "IDX_AST_IA_IAD",
                table: "Assessment",
                columns: new[] { "Active", "AssessmentDate" });

            migrationBuilder.CreateIndex(
                name: "IDX_AST_SDD_SSID",
                table: "Assessment",
                columns: new[] { "SettlementDueDate", "SettlementStatusID" });

            migrationBuilder.CreateIndex(
                name: "IDX_AST_SSID",
                table: "Assessment",
                column: "SettlementStatusID");

            migrationBuilder.CreateIndex(
                name: "IDX_AST_SSID_AD",
                table: "Assessment",
                columns: new[] { "SettlementStatusID", "AssessmentDate" });

            migrationBuilder.CreateIndex(
                name: "IDX_AST_TPTID_SDD_SSID",
                table: "Assessment",
                columns: new[] { "TaxPayerTypeID", "SettlementDueDate", "SettlementStatusID" });

            migrationBuilder.CreateIndex(
                name: "IDX_AST_TPTID_TID",
                table: "Assessment",
                columns: new[] { "TaxPayerTypeID", "TaxPayerID" });

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Group_AssetTypeID",
                table: "Assessment_Group",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Item_SubCategory_AssessmentItemCategoryID",
                table: "Assessment_Item_SubCategory",
                column: "AssessmentItemCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Items_AgencyID",
                table: "Assessment_Items",
                column: "AgencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Items_AssessmentGroupID",
                table: "Assessment_Items",
                column: "AssessmentGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Items_AssessmentItemCategoryID",
                table: "Assessment_Items",
                column: "AssessmentItemCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Items_AssessmentItemSubCategoryID",
                table: "Assessment_Items",
                column: "AssessmentItemSubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Items_AssessmentSubGroupID",
                table: "Assessment_Items",
                column: "AssessmentSubGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Items_AssetTypeID",
                table: "Assessment_Items",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Items_ComputationID",
                table: "Assessment_Items",
                column: "ComputationID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Items_RevenueStreamID",
                table: "Assessment_Items",
                column: "RevenueStreamID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Items_RevenueSubStreamID",
                table: "Assessment_Items",
                column: "RevenueSubStreamID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Rules_PaymentFrequencyID",
                table: "Assessment_Rules",
                column: "PaymentFrequencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Rules_PaymentOptionID",
                table: "Assessment_Rules",
                column: "PaymentOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Rules_ProfileID",
                table: "Assessment_Rules",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Rules_RuleRunID",
                table: "Assessment_Rules",
                column: "RuleRunID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_SubGroup_AssessmentGroupID",
                table: "Assessment_SubGroup",
                column: "AssessmentGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Audit_Log_ASLID",
                table: "Audit_Log",
                column: "ASLID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_AssetTypeID",
                table: "Building",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_BuildingCompletionID",
                table: "Building",
                column: "BuildingCompletionID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_BuildingOwnershipID",
                table: "Building",
                column: "BuildingOwnershipID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_BuildingPurposeID",
                table: "Building",
                column: "BuildingPurposeID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_BuildingTypeID",
                table: "Building",
                column: "BuildingTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_LGAID",
                table: "Building",
                column: "LGAID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_TownID",
                table: "Building",
                column: "TownID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_WardID",
                table: "Building",
                column: "WardID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_Unit_SizeID",
                table: "Building_Unit",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_Unit_UnitFunctionID",
                table: "Building_Unit",
                column: "UnitFunctionID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_Unit_UnitOccupancyID",
                table: "Building_Unit",
                column: "UnitOccupancyID");

            migrationBuilder.CreateIndex(
                name: "IX_Building_Unit_UnitPurposeID",
                table: "Building_Unit",
                column: "UnitPurposeID");

            migrationBuilder.CreateIndex(
                name: "IDX_BA",
                table: "Business",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessCategoryID",
                table: "Business",
                column: "BusinessCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessOperationID",
                table: "Business",
                column: "BusinessOperationID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessSectorID",
                table: "Business",
                column: "BusinessSectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessStructureID",
                table: "Business",
                column: "BusinessStructureID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessSubSectorID",
                table: "Business",
                column: "BusinessSubSectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessTypeID",
                table: "Business",
                column: "BusinessTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_LGAID",
                table: "Business",
                column: "LGAID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_SizeID",
                table: "Business",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_Category_BusinessTypeID",
                table: "Business_Category",
                column: "BusinessTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_Operation_BusinessTypeID",
                table: "Business_Operation",
                column: "BusinessTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_Sector_BusinessCategoryID",
                table: "Business_Sector",
                column: "BusinessCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_Sector_BusinessTypeID",
                table: "Business_Sector",
                column: "BusinessTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_Structure_BusinessTypeID",
                table: "Business_Structure",
                column: "BusinessTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_SubSector_BusinessSectorID",
                table: "Business_SubSector",
                column: "BusinessSectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_CertificateTypeID",
                table: "Certificates",
                column: "CertificateTypeID");

            migrationBuilder.CreateIndex(
                name: "IDX_COMP_TOID",
                table: "Company",
                column: "TaxOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_EconomicActivitiesID",
                table: "Company",
                column: "EconomicActivitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_NotificationMethodID",
                table: "Company",
                column: "NotificationMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_RegisterationStatusID",
                table: "Company",
                column: "RegisterationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_TaxPayerTypeID",
                table: "Company",
                column: "TaxPayerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Economic_Activities_TaxPayerTypeID",
                table: "Economic_Activities",
                column: "TaxPayerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ELMAH_Error_App_Time_Seq",
                table: "ELMAH_Error",
                columns: new[] { "Application", "TimeUtc", "Sequence" },
                descending: new[] { false, true, true });

            migrationBuilder.CreateIndex(
                name: "IX_EM_RevenueHead_CategoryID",
                table: "EM_RevenueHead",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Government_GovernmentTypeID",
                table: "Government",
                column: "GovernmentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Government_NotificationMethodID",
                table: "Government",
                column: "NotificationMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Government_RegisterationStatusID",
                table: "Government",
                column: "RegisterationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Government_TaxOfficeID",
                table: "Government",
                column: "TaxOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_Government_TaxPayerTypeID",
                table: "Government",
                column: "TaxPayerTypeID");

            migrationBuilder.CreateIndex(
                name: "IDX_IN_TOF",
                table: "Individual",
                column: "TaxOfficeID");

            migrationBuilder.CreateIndex(
                name: "IDX_IND_RIN_FL",
                table: "Individual",
                column: "TaxOfficeID");

            migrationBuilder.CreateIndex(
                name: "IDX_IND_TITLE",
                table: "Individual",
                column: "TitleID");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_EconomicActivitiesID",
                table: "Individual",
                column: "EconomicActivitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_GenderID",
                table: "Individual",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_MaritalStatusID",
                table: "Individual",
                column: "MaritalStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_NationalityID",
                table: "Individual",
                column: "NationalityID");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_NotificationMethodID",
                table: "Individual",
                column: "NotificationMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_RegisterationStatusID",
                table: "Individual",
                column: "RegisterationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_TaxPayerTypeID",
                table: "Individual",
                column: "TaxPayerTypeID");

            migrationBuilder.CreateIndex(
                name: "IDX_LA",
                table: "Land",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Land_LandDevelopmentID",
                table: "Land",
                column: "LandDevelopmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Land_LandFunctionID",
                table: "Land",
                column: "LandFunctionID");

            migrationBuilder.CreateIndex(
                name: "IX_Land_LandOwnershipID",
                table: "Land",
                column: "LandOwnershipID");

            migrationBuilder.CreateIndex(
                name: "IX_Land_LandPurposeID",
                table: "Land",
                column: "LandPurposeID");

            migrationBuilder.CreateIndex(
                name: "IX_Land_LandStreetConditionID",
                table: "Land",
                column: "LandStreetConditionID");

            migrationBuilder.CreateIndex(
                name: "IX_Land_LGAID",
                table: "Land",
                column: "LGAID");

            migrationBuilder.CreateIndex(
                name: "IX_Land_TownID",
                table: "Land",
                column: "TownID");

            migrationBuilder.CreateIndex(
                name: "IX_Land_WardID",
                table: "Land",
                column: "WardID");

            migrationBuilder.CreateIndex(
                name: "IX_Land_Function_LandPurposeID",
                table: "Land_Function",
                column: "LandPurposeID");

            migrationBuilder.CreateIndex(
                name: "IX_LGA_LGAClassID",
                table: "LGA",
                column: "LGAClassID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Assessment_Adjustment_AAIID",
                table: "MAP_Assessment_Adjustment",
                column: "AAIID");

            migrationBuilder.CreateIndex(
                name: "IDX_AAI_AID",
                table: "MAP_Assessment_AssessmentItem",
                column: "AssessmentItemID");

            migrationBuilder.CreateIndex(
                name: "IDX_MAAI_AARID_AIID_TA",
                table: "MAP_Assessment_AssessmentItem",
                column: "AARID");

            migrationBuilder.CreateIndex(
                name: "IDX_MAAI_AIID_AARID",
                table: "MAP_Assessment_AssessmentItem",
                column: "AssessmentItemID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Assessment_AssessmentItem_PaymentStatusID",
                table: "MAP_Assessment_AssessmentItem",
                column: "PaymentStatusID");

            migrationBuilder.CreateIndex(
                name: "IDX_AAR_AID",
                table: "MAP_Assessment_AssessmentRule",
                column: "AssessmentID");

            migrationBuilder.CreateIndex(
                name: "IDX_AAR_AY_AID",
                table: "MAP_Assessment_AssessmentRule",
                column: "AssessmentYear");

            migrationBuilder.CreateIndex(
                name: "IDX_MAAR_ATID_AID_AID",
                table: "MAP_Assessment_AssessmentRule",
                columns: new[] { "AssetTypeID", "AssetID" });

            migrationBuilder.CreateIndex(
                name: "IX_MAP_AssessmentRule_AssessmentItem_AssessmentItemID",
                table: "MAP_AssessmentRule_AssessmentItem",
                column: "AssessmentItemID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_AssessmentRule_AssessmentItem_AssessmentRuleID",
                table: "MAP_AssessmentRule_AssessmentItem",
                column: "AssessmentRuleID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_AssessmentRule_SettlementMethod_AssessmentRuleID",
                table: "MAP_AssessmentRule_SettlementMethod",
                column: "AssessmentRuleID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_AssessmentRule_SettlementMethod_SettlementMethodID",
                table: "MAP_AssessmentRule_SettlementMethod",
                column: "SettlementMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Building_BuildingUnit_BuildingID",
                table: "MAP_Building_BuildingUnit",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Building_BuildingUnit_BuildingUnitID",
                table: "MAP_Building_BuildingUnit",
                column: "BuildingUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Building_Land_BuildingID",
                table: "MAP_Building_Land",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Building_Land_LandID",
                table: "MAP_Building_Land",
                column: "LandID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Business_Building_BuildingID",
                table: "MAP_Business_Building",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Business_Building_BusinessID",
                table: "MAP_Business_Building",
                column: "BusinessID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_CustomField_CertificateID",
                table: "MAP_Certificate_CustomField",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_CustomField_CTFID",
                table: "MAP_Certificate_CustomField",
                column: "CTFID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_Generate_CertificateID",
                table: "MAP_Certificate_Generate",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_Generate_Field_CGID",
                table: "MAP_Certificate_Generate_Field",
                column: "CGID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_Issue_CertificateID",
                table: "MAP_Certificate_Issue",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_Revoke_CertificateID",
                table: "MAP_Certificate_Revoke",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_Seal_CertificateID",
                table: "MAP_Certificate_Seal",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_SignDigital_CertificateID",
                table: "MAP_Certificate_SignDigital",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_Stages_CertificateID",
                table: "MAP_Certificate_Stages",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Certificate_Validate_CertificateID",
                table: "MAP_Certificate_Validate",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_CertificateType_Field_CertificateTypeID",
                table: "MAP_CertificateType_Field",
                column: "CertificateTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_CertificateType_Field_FieldTypeID",
                table: "MAP_CertificateType_Field",
                column: "FieldTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Company_AddressInformation_AddressTypeID",
                table: "MAP_Company_AddressInformation",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Company_AddressInformation_BuildingID",
                table: "MAP_Company_AddressInformation",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Company_AddressInformation_CompanyID",
                table: "MAP_Company_AddressInformation",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Directorates_RevenueStream_DirectorateID",
                table: "MAP_Directorates_RevenueStream",
                column: "DirectorateID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Directorates_RevenueStream_RevenueStreamID",
                table: "MAP_Directorates_RevenueStream",
                column: "RevenueStreamID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Government_AddressInformation_AddressTypeID",
                table: "MAP_Government_AddressInformation",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Government_AddressInformation_BuildingID",
                table: "MAP_Government_AddressInformation",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Government_AddressInformation_GovernmentID",
                table: "MAP_Government_AddressInformation",
                column: "GovernmentID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Individual_AddressInformation_AddressTypeID",
                table: "MAP_Individual_AddressInformation",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Individual_AddressInformation_BuildingID",
                table: "MAP_Individual_AddressInformation",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Individual_AddressInformation_IndividualID",
                table: "MAP_Individual_AddressInformation",
                column: "IndividualID");

            migrationBuilder.CreateIndex(
                name: "IDX_MDAServiceItem_mdaservice",
                table: "MAP_MDAService_MDAServiceItem",
                column: "MDAServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_MDAService_MDAServiceItem_MDAServiceItemID",
                table: "MAP_MDAService_MDAServiceItem",
                column: "MDAServiceItemID");

            migrationBuilder.CreateIndex(
                name: "IDX_MDA_SMTHD",
                table: "MAP_MDAService_SettlementMethod",
                column: "MDAServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_MDAService_SettlementMethod_SettlementMethodID",
                table: "MAP_MDAService_SettlementMethod",
                column: "SettlementMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_ServiceBill_Adjustment_SBSIID",
                table: "MAP_ServiceBill_Adjustment",
                column: "SBSIID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_ServiceBill_LateCharge_SBSIID",
                table: "MAP_ServiceBill_LateCharge",
                column: "SBSIID");

            migrationBuilder.CreateIndex(
                name: "IDX_SMS_SBID",
                table: "MAP_ServiceBill_MDAService",
                column: "ServiceBillID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_ServiceBill_MDAService_MDAServiceID",
                table: "MAP_ServiceBill_MDAService",
                column: "MDAServiceID");

            migrationBuilder.CreateIndex(
                name: "IDX_SB_MSI_SBSID",
                table: "MAP_ServiceBill_MDAServiceItem",
                column: "SBSID");

            migrationBuilder.CreateIndex(
                name: "IDX_SB_MSI_SIID",
                table: "MAP_ServiceBill_MDAServiceItem",
                column: "MDAServiceItemID");

            migrationBuilder.CreateIndex(
                name: "IDX_SSI_AAIID_iSID_iSAMT",
                table: "MAP_Settlement_SettlementItem",
                column: "AAIID");

            migrationBuilder.CreateIndex(
                name: "IDX_SSI_SBSIID_SID_SA",
                table: "MAP_Settlement_SettlementItem",
                column: "SBSIID");

            migrationBuilder.CreateIndex(
                name: "IDX_SSI_SID_AID_SA",
                table: "MAP_Settlement_SettlementItem",
                column: "SettlementID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Special_AddressInformation_AddressTypeID",
                table: "MAP_Special_AddressInformation",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Special_AddressInformation_BuildingID",
                table: "MAP_Special_AddressInformation",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_Special_AddressInformation_SpecialID",
                table: "MAP_Special_AddressInformation",
                column: "SpecialID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TaxOffice_Target_RevenueStreamID",
                table: "MAP_TaxOffice_Target",
                column: "RevenueStreamID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TaxOffice_Target_TaxOfficeID",
                table: "MAP_TaxOffice_Target",
                column: "TaxOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TaxOfficer_Target_RevenueStreamID",
                table: "MAP_TaxOfficer_Target",
                column: "RevenueStreamID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TaxOfficer_Target_TaxOfficeID",
                table: "MAP_TaxOfficer_Target",
                column: "TaxOfficeID");

            migrationBuilder.CreateIndex(
                name: "IDX_ATA",
                table: "MAP_TaxPayer_Asset",
                columns: new[] { "AssetTypeID", "AssetID" });

            migrationBuilder.CreateIndex(
                name: "IDX_MTPA_A_TPTID_TPID_ATID_AID",
                table: "MAP_TaxPayer_Asset",
                column: "Active");

            migrationBuilder.CreateIndex(
                name: "IDX_MTPA_AID_A_TPTID_TPID_ATID",
                table: "MAP_TaxPayer_Asset",
                columns: new[] { "AssetID", "Active" });

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TaxPayer_Asset_TaxPayerID",
                table: "MAP_TaxPayer_Asset",
                column: "TaxPayerID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TaxPayer_Asset_TaxPayerRoleID",
                table: "MAP_TaxPayer_Asset",
                column: "TaxPayerRoleID");

            migrationBuilder.CreateIndex(
                name: "IDX_TPA_Profile",
                table: "MAP_TaxPayer_Asset_Profile",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IDX_TPAP_PROF",
                table: "MAP_TaxPayer_Asset_Profile",
                column: "TPAID");

            migrationBuilder.CreateIndex(
                name: "IDX_A_P_PT",
                table: "MAP_TaxPayer_Asset_Profile_PT",
                column: "TPAID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TaxPayer_Message_Document_TPMID",
                table: "MAP_TaxPayer_Message_Document",
                column: "TPMID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_Generate_RequestID",
                table: "MAP_TCCRequest_Generate",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_Generate_Field_RGID",
                table: "MAP_TCCRequest_Generate_Field",
                column: "RGID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_GenerateTCCDetail_RequestID",
                table: "MAP_TCCRequest_GenerateTCCDetail",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_Issue_RequestID",
                table: "MAP_TCCRequest_Issue",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_Notes_Document_RNID",
                table: "MAP_TCCRequest_Notes_Document",
                column: "RNID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_PrepareTCCDraft_RequestID",
                table: "MAP_TCCRequest_PrepareTCCDraft",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_Revoke_RequestID",
                table: "MAP_TCCRequest_Revoke",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_Seal_RequestID",
                table: "MAP_TCCRequest_Seal",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_SignDigital_RequestID",
                table: "MAP_TCCRequest_SignDigital",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_Validate_RequestID",
                table: "MAP_TCCRequest_Validate",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_ValidateTaxPayerIncome_RequestID",
                table: "MAP_TCCRequest_ValidateTaxPayerIncome",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TCCRequest_ValidateTaxPayerInformation_RequestID",
                table: "MAP_TCCRequest_ValidateTaxPayerInformation",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TreasuryReceipt_Settlement_ReceiptID",
                table: "MAP_TreasuryReceipt_Settlement",
                column: "ReceiptID");

            migrationBuilder.CreateIndex(
                name: "IX_MAP_TreasuryReceipt_Settlement_SettlementID",
                table: "MAP_TreasuryReceipt_Settlement",
                column: "SettlementID");

            migrationBuilder.CreateIndex(
                name: "IX_MDA_Service_Items_AgencyID",
                table: "MDA_Service_Items",
                column: "AgencyID");

            migrationBuilder.CreateIndex(
                name: "IX_MDA_Service_Items_AssessmentItemCategoryID",
                table: "MDA_Service_Items",
                column: "AssessmentItemCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_MDA_Service_Items_AssessmentItemSubCategoryID",
                table: "MDA_Service_Items",
                column: "AssessmentItemSubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_MDA_Service_Items_ComputationID",
                table: "MDA_Service_Items",
                column: "ComputationID");

            migrationBuilder.CreateIndex(
                name: "IX_MDA_Service_Items_RevenueStreamID",
                table: "MDA_Service_Items",
                column: "RevenueStreamID");

            migrationBuilder.CreateIndex(
                name: "IX_MDA_Service_Items_RevenueSubStreamID",
                table: "MDA_Service_Items",
                column: "RevenueSubStreamID");

            migrationBuilder.CreateIndex(
                name: "IX_MDA_Services_PaymentFrequencyID",
                table: "MDA_Services",
                column: "PaymentFrequencyID");

            migrationBuilder.CreateIndex(
                name: "IX_MDA_Services_PaymentOptionID",
                table: "MDA_Services",
                column: "PaymentOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_MDA_Services_RuleRunID",
                table: "MDA_Services",
                column: "RuleRunID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationMethodID",
                table: "Notifications",
                column: "NotificationMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationModeID",
                table: "Notifications",
                column: "NotificationModeID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationTypeID",
                table: "Notifications",
                column: "NotificationTypeID");

            migrationBuilder.CreateIndex(
                name: "IDX_POA_RSID_TPTID_TPID_A_SMID_PD",
                table: "Payment_Account",
                column: "RevenueStreamID");

            migrationBuilder.CreateIndex(
                name: "IDX_PoA_SMID",
                table: "Payment_Account",
                column: "SettlementMethodID");

            migrationBuilder.CreateIndex(
                name: "IDX_PoA_TPTID_TPID",
                table: "Payment_Account",
                columns: new[] { "TaxPayerTypeID", "TaxPayerID" });

            migrationBuilder.CreateIndex(
                name: "IX_PA_RSID_PD",
                table: "Payment_Account",
                columns: new[] { "RevenueStreamID", "PaymentDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Account_RevenueSubStreamID",
                table: "Payment_Account",
                column: "RevenueSubStreamID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Account_SettlementStatusID",
                table: "Payment_Account",
                column: "SettlementStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileAttribute_ProfileID",
                table: "ProfileAttribute",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileGroup_ProfileID",
                table: "ProfileGroup",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_AssetTypeID",
                table: "Profiles",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_BKP_AssetTypeID",
                table: "Profiles_BKP",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSector_ProfileID",
                table: "ProfileSector",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSectorElement_ProfileID",
                table: "ProfileSectorElement",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSectorSubElement_ProfileID",
                table: "ProfileSectorSubElement",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSubAttribute_ProfileID",
                table: "ProfileSubAttribute",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSubGroup_ProfileID",
                table: "ProfileSubGroup",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IDX_ProfileSubSector",
                table: "ProfileSubSector",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IDX_ProfileTaxPayerRole",
                table: "ProfileTaxPayerRole",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileTaxPayerType_ProfileID",
                table: "ProfileTaxPayerType",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Revenue_SubStream_RevenueStreamID",
                table: "Revenue_SubStream",
                column: "RevenueStreamID");

            migrationBuilder.CreateIndex(
                name: "IDX_SB_TPTID",
                table: "ServiceBill",
                column: "TaxPayerTypeID");

            migrationBuilder.CreateIndex(
                name: "IDX_SB_TPTID_TPID",
                table: "ServiceBill",
                columns: new[] { "TaxPayerTypeID", "TaxPayerID" });

            migrationBuilder.CreateIndex(
                name: "IDX_Settlement_cActive",
                table: "Settlement",
                column: "Active");

            migrationBuilder.CreateIndex(
                name: "IDX_Settlment_Assessment",
                table: "Settlement",
                column: "AssessmentID");

            migrationBuilder.CreateIndex(
                name: "IDX_Settlment_ServiceBill",
                table: "Settlement",
                column: "ServiceBillID");

            migrationBuilder.CreateIndex(
                name: "IDX_SMT_SMID_SD_AID_SAMT",
                table: "Settlement",
                columns: new[] { "SettlementMethodID", "SettlementDate" });

            migrationBuilder.CreateIndex(
                name: "IDX_SMT_SMID_SD_ISBID_ISAMT",
                table: "Settlement",
                columns: new[] { "SettlementMethodID", "SettlementDate" });

            migrationBuilder.CreateIndex(
                name: "IDX_ST_SMD_SD",
                table: "Settlement",
                columns: new[] { "SettlementMethodID", "SettlementDate" });

            migrationBuilder.CreateIndex(
                name: "IX_SFTP_DataSubmission_DataSubmissionTypeID",
                table: "SFTP_DataSubmission",
                column: "DataSubmissionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SFTP_DataSubmission_DataSubmitterID",
                table: "SFTP_DataSubmission",
                column: "DataSubmitterID");

            migrationBuilder.CreateIndex(
                name: "IX_SFTP_MAP_DataSubmitter_DataSubmissionType_DataSubmissionTypeID",
                table: "SFTP_MAP_DataSubmitter_DataSubmissionType",
                column: "DataSubmissionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SFTP_MAP_DataSubmitter_DataSubmissionType_DataSubmitterID",
                table: "SFTP_MAP_DataSubmitter_DataSubmissionType",
                column: "DataSubmitterID");

            migrationBuilder.CreateIndex(
                name: "IX_Special_NotificationMethodID",
                table: "Special",
                column: "NotificationMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Special_TaxOfficeID",
                table: "Special",
                column: "TaxOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_Special_TaxPayerTypeID",
                table: "Special",
                column: "TaxPayerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUser_SystemRoleID",
                table: "SystemUser",
                column: "SystemRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_Offices_AddressTypeID",
                table: "Tax_Offices",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_Offices_BuildingID",
                table: "Tax_Offices",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayer_Roles_AssetTypeID",
                table: "TaxPayer_Roles",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayer_Roles_TaxPayerTypeID",
                table: "TaxPayer_Roles",
                column: "TaxPayerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Town_LGAID",
                table: "Town",
                column: "LGAID");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_Function_UnitPurposeID",
                table: "Unit_Function",
                column: "UnitPurposeID");

            migrationBuilder.CreateIndex(
                name: "IDX_VA",
                table: "Vehicle",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IDX_VH_VP",
                table: "Vehicle",
                column: "VehiclePurposeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_LGAID",
                table: "Vehicle",
                column: "LGAID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleFunctionID",
                table: "Vehicle",
                column: "VehicleFunctionID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleOwnershipID",
                table: "Vehicle",
                column: "VehicleOwnershipID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleSubTypeID",
                table: "Vehicle",
                column: "VehicleSubTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleTypeID",
                table: "Vehicle",
                column: "VehicleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Function_VehiclePurposeID",
                table: "Vehicle_Function",
                column: "VehiclePurposeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Insurance_VehicleID",
                table: "Vehicle_Insurance",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Licenses_VehicleID",
                table: "Vehicle_Licenses",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Licenses_VehicleInsuranceID",
                table: "Vehicle_Licenses",
                column: "VehicleInsuranceID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_SubTypes_VehicleTypeID",
                table: "Vehicle_SubTypes",
                column: "VehicleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Ward_LGAID",
                table: "Ward",
                column: "LGAID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit_Log");

            migrationBuilder.DropTable(
                name: "Dealer_Types");

            migrationBuilder.DropTable(
                name: "DI_EdoGIS_MDA_Service_Items_2_2021");

            migrationBuilder.DropTable(
                name: "DI_EdoGIS_MDA_Service_Items_2021");

            migrationBuilder.DropTable(
                name: "DI_EdoGIS_MDA_Services_2_2021");

            migrationBuilder.DropTable(
                name: "DI_EdoGIS_MDA_Services_2021");

            migrationBuilder.DropTable(
                name: "DI_MDA_Service_2021");

            migrationBuilder.DropTable(
                name: "DI_MDA_Service_Items_2021");

            migrationBuilder.DropTable(
                name: "EED_Individual");

            migrationBuilder.DropTable(
                name: "EGA");

            migrationBuilder.DropTable(
                name: "ELMAH_Error");

            migrationBuilder.DropTable(
                name: "EM_Bank");

            migrationBuilder.DropTable(
                name: "EM_BankStatement");

            migrationBuilder.DropTable(
                name: "EM_DataSource");

            migrationBuilder.DropTable(
                name: "EM_IGRClassification");

            migrationBuilder.DropTable(
                name: "EM_ImportLog");

            migrationBuilder.DropTable(
                name: "EM_MAP_IGRClassification_Entry");

            migrationBuilder.DropTable(
                name: "EM_PD_Main_Authorized");

            migrationBuilder.DropTable(
                name: "EM_PD_Main_Pending");

            migrationBuilder.DropTable(
                name: "EM_PD_MVA_Authorized");

            migrationBuilder.DropTable(
                name: "EM_PD_MVA_Pending");

            migrationBuilder.DropTable(
                name: "EM_RevenueHead");

            migrationBuilder.DropTable(
                name: "EPLD_Business");

            migrationBuilder.DropTable(
                name: "EPLD_Individual");

            migrationBuilder.DropTable(
                name: "ESD_Business");

            migrationBuilder.DropTable(
                name: "ESD_Individual");

            migrationBuilder.DropTable(
                name: "Exception_Type");

            migrationBuilder.DropTable(
                name: "External_DataSource");

            migrationBuilder.DropTable(
                name: "GISFileAssessment");

            migrationBuilder.DropTable(
                name: "GISFileAssessmentItem");

            migrationBuilder.DropTable(
                name: "GISFileAsset");

            migrationBuilder.DropTable(
                name: "GISFileHolder");

            migrationBuilder.DropTable(
                name: "GISFileInvoice");

            migrationBuilder.DropTable(
                name: "GISFileInvoiceItem");

            migrationBuilder.DropTable(
                name: "GISFileParty");

            migrationBuilder.DropTable(
                name: "GISTesting");

            migrationBuilder.DropTable(
                name: "JTB_Individual");

            migrationBuilder.DropTable(
                name: "JTB_Individual_Old");

            migrationBuilder.DropTable(
                name: "JTB_NonIndividual");

            migrationBuilder.DropTable(
                name: "Late_Charges");

            migrationBuilder.DropTable(
                name: "MAP_Assessment_Adjustment");

            migrationBuilder.DropTable(
                name: "MAP_Assessment_LateCharge");

            migrationBuilder.DropTable(
                name: "MAP_AssessmentRule_AssessmentItem");

            migrationBuilder.DropTable(
                name: "MAP_AssessmentRule_SettlementMethod");

            migrationBuilder.DropTable(
                name: "MAP_Building_BuildingUnit");

            migrationBuilder.DropTable(
                name: "MAP_Building_Land");

            migrationBuilder.DropTable(
                name: "MAP_Business_Building");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_CustomField");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_Generate_Field");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_Issue");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_Revoke");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_Seal");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_SignDigital");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_SignVisible");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_Stages");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_Validate");

            migrationBuilder.DropTable(
                name: "MAP_CertificateType_Items");

            migrationBuilder.DropTable(
                name: "MAP_Company_AddressInformation");

            migrationBuilder.DropTable(
                name: "MAP_Directorates_RevenueStream");

            migrationBuilder.DropTable(
                name: "MAP_Government_AddressInformation");

            migrationBuilder.DropTable(
                name: "MAP_Individual_AddressInformation");

            migrationBuilder.DropTable(
                name: "MAP_MDAService_MDAServiceItem");

            migrationBuilder.DropTable(
                name: "MAP_MDAService_SettlementMethod");

            migrationBuilder.DropTable(
                name: "MAP_PaymentAccount_Operation");

            migrationBuilder.DropTable(
                name: "MAP_ServiceBill_Adjustment");

            migrationBuilder.DropTable(
                name: "MAP_ServiceBill_LateCharge");

            migrationBuilder.DropTable(
                name: "MAP_Settlement_SettlementItem");

            migrationBuilder.DropTable(
                name: "MAP_Special_AddressInformation");

            migrationBuilder.DropTable(
                name: "MAP_TaxOffice_Target");

            migrationBuilder.DropTable(
                name: "MAP_TaxOfficer_Target");

            migrationBuilder.DropTable(
                name: "MAP_TaxPayer_Asset_Profile");

            migrationBuilder.DropTable(
                name: "MAP_TaxPayer_Asset_Profile_PT");

            migrationBuilder.DropTable(
                name: "MAP_TaxPayer_Document");

            migrationBuilder.DropTable(
                name: "MAP_TaxPayer_Message_Document");

            migrationBuilder.DropTable(
                name: "MAP_TaxPayer_Review");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_Generate_Field");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_GenerateTCCDetail");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_IncomeStream");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_Issue");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_Notes_Document");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_PrepareTCCDraft");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_Revoke");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_Seal");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_SignDigital");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_SignVisible");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_Stages");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_Validate");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_ValidateTaxPayerIncome");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_ValidateTaxPayerInformation");

            migrationBuilder.DropTable(
                name: "MAP_TreasuryReceipt_Settlement");

            migrationBuilder.DropTable(
                name: "MST_CertificateStage");

            migrationBuilder.DropTable(
                name: "MST_CertificateStatus");

            migrationBuilder.DropTable(
                name: "MST_EmailStack");

            migrationBuilder.DropTable(
                name: "MST_LastNumber");

            migrationBuilder.DropTable(
                name: "MST_TCCRequestStatus");

            migrationBuilder.DropTable(
                name: "MST_TCCStage");

            migrationBuilder.DropTable(
                name: "MST_TCCStatus");

            migrationBuilder.DropTable(
                name: "NewERASTccHolder");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Operation_Types");

            migrationBuilder.DropTable(
                name: "PayDirect_Notifications");

            migrationBuilder.DropTable(
                name: "PayeTccHolder");

            migrationBuilder.DropTable(
                name: "Payment_Account");

            migrationBuilder.DropTable(
                name: "Profile_Types");

            migrationBuilder.DropTable(
                name: "ProfileAttribute");

            migrationBuilder.DropTable(
                name: "ProfileGroup");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "ProfileSector");

            migrationBuilder.DropTable(
                name: "ProfileSectorElement");

            migrationBuilder.DropTable(
                name: "ProfileSectorSubElement");

            migrationBuilder.DropTable(
                name: "ProfileSubAttribute");

            migrationBuilder.DropTable(
                name: "ProfileSubGroup");

            migrationBuilder.DropTable(
                name: "ProfileSubSector");

            migrationBuilder.DropTable(
                name: "ProfileTaxPayerRole");

            migrationBuilder.DropTable(
                name: "ProfileTaxPayerType");

            migrationBuilder.DropTable(
                name: "Receipt_Status");

            migrationBuilder.DropTable(
                name: "Review_Status");

            migrationBuilder.DropTable(
                name: "RIN_Check");

            migrationBuilder.DropTable(
                name: "Scratch_Card_Dealers");

            migrationBuilder.DropTable(
                name: "Scratch_Card_Printer");

            migrationBuilder.DropTable(
                name: "ScratchCard_PurchaseRequest");

            migrationBuilder.DropTable(
                name: "SFTP_DataSubmission");

            migrationBuilder.DropTable(
                name: "SFTP_MAP_DataSubmitter_DataSubmissionType");

            migrationBuilder.DropTable(
                name: "SystemUser");

            migrationBuilder.DropTable(
                name: "Tax_Credit");

            migrationBuilder.DropTable(
                name: "TaxClearanceCertificate");

            migrationBuilder.DropTable(
                name: "TaxOffice");

            migrationBuilder.DropTable(
                name: "TaxPayerPayment");

            migrationBuilder.DropTable(
                name: "TCCDetails");

            migrationBuilder.DropTable(
                name: "TccRefHolder");

            migrationBuilder.DropTable(
                name: "upload");

            migrationBuilder.DropTable(
                name: "Vehicle_Licenses");

            migrationBuilder.DropTable(
                name: "Zone");

            migrationBuilder.DropTable(
                name: "ZoneLGA");

            migrationBuilder.DropTable(
                name: "AL_Screen");

            migrationBuilder.DropTable(
                name: "EM_Category");

            migrationBuilder.DropTable(
                name: "Assessment_Rules");

            migrationBuilder.DropTable(
                name: "Building_Unit");

            migrationBuilder.DropTable(
                name: "Land");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "MAP_CertificateType_Field");

            migrationBuilder.DropTable(
                name: "MAP_Certificate_Generate");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Directorates");

            migrationBuilder.DropTable(
                name: "Government");

            migrationBuilder.DropTable(
                name: "Individual");

            migrationBuilder.DropTable(
                name: "MAP_Assessment_AssessmentItem");

            migrationBuilder.DropTable(
                name: "MAP_ServiceBill_MDAServiceItem");

            migrationBuilder.DropTable(
                name: "Special");

            migrationBuilder.DropTable(
                name: "MAP_TaxPayer_Asset");

            migrationBuilder.DropTable(
                name: "MAP_TaxPayer_Message");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_Generate");

            migrationBuilder.DropTable(
                name: "MAP_TCCRequest_Notes");

            migrationBuilder.DropTable(
                name: "Settlement");

            migrationBuilder.DropTable(
                name: "Treasury_Receipt");

            migrationBuilder.DropTable(
                name: "Notification_Mode");

            migrationBuilder.DropTable(
                name: "Notification_Type");

            migrationBuilder.DropTable(
                name: "Settlement_Status");

            migrationBuilder.DropTable(
                name: "SFTP_DataSubmissionType");

            migrationBuilder.DropTable(
                name: "SFTP_DataSubmitter");

            migrationBuilder.DropTable(
                name: "SystemRole");

            migrationBuilder.DropTable(
                name: "Vehicle_Insurance");

            migrationBuilder.DropTable(
                name: "Profiles_BKP");

            migrationBuilder.DropTable(
                name: "Unit_Function");

            migrationBuilder.DropTable(
                name: "Unit_Occupancy");

            migrationBuilder.DropTable(
                name: "Land_Development");

            migrationBuilder.DropTable(
                name: "Land_Function");

            migrationBuilder.DropTable(
                name: "Land_Ownership");

            migrationBuilder.DropTable(
                name: "Land_StreetCondition");

            migrationBuilder.DropTable(
                name: "Business_Operation");

            migrationBuilder.DropTable(
                name: "Business_Structure");

            migrationBuilder.DropTable(
                name: "Business_SubSector");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "MST_FieldType");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Government_Types");

            migrationBuilder.DropTable(
                name: "Economic_Activities");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "MST_RegisterationStatus");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Assessment_Items");

            migrationBuilder.DropTable(
                name: "MAP_Assessment_AssessmentRule");

            migrationBuilder.DropTable(
                name: "MST_PaymentStatus");

            migrationBuilder.DropTable(
                name: "MAP_ServiceBill_MDAService");

            migrationBuilder.DropTable(
                name: "MDA_Service_Items");

            migrationBuilder.DropTable(
                name: "Notification_Method");

            migrationBuilder.DropTable(
                name: "Tax_Offices");

            migrationBuilder.DropTable(
                name: "TaxPayer_Roles");

            migrationBuilder.DropTable(
                name: "TCC_Request");

            migrationBuilder.DropTable(
                name: "Settlement_Method");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Unit_Purpose");

            migrationBuilder.DropTable(
                name: "Land_Purpose");

            migrationBuilder.DropTable(
                name: "Business_Sector");

            migrationBuilder.DropTable(
                name: "Certificate_Types");

            migrationBuilder.DropTable(
                name: "Assessment_SubGroup");

            migrationBuilder.DropTable(
                name: "Assessment");

            migrationBuilder.DropTable(
                name: "MDA_Services");

            migrationBuilder.DropTable(
                name: "ServiceBill");

            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropTable(
                name: "Assessment_Item_SubCategory");

            migrationBuilder.DropTable(
                name: "MST_Computation");

            migrationBuilder.DropTable(
                name: "Revenue_SubStream");

            migrationBuilder.DropTable(
                name: "Address_Types");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "TaxPayer_Types");

            migrationBuilder.DropTable(
                name: "Vehicle_Function");

            migrationBuilder.DropTable(
                name: "Vehicle_Ownership");

            migrationBuilder.DropTable(
                name: "Vehicle_SubTypes");

            migrationBuilder.DropTable(
                name: "Business_Category");

            migrationBuilder.DropTable(
                name: "Assessment_Group");

            migrationBuilder.DropTable(
                name: "MST_RuleRun");

            migrationBuilder.DropTable(
                name: "Payment_Frequency");

            migrationBuilder.DropTable(
                name: "Payment_Options");

            migrationBuilder.DropTable(
                name: "Agency_Types");

            migrationBuilder.DropTable(
                name: "Assessment_Item_Category");

            migrationBuilder.DropTable(
                name: "Revenue_Stream");

            migrationBuilder.DropTable(
                name: "Building_Completion");

            migrationBuilder.DropTable(
                name: "Building_Ownership");

            migrationBuilder.DropTable(
                name: "Building_Purpose");

            migrationBuilder.DropTable(
                name: "Building_Types");

            migrationBuilder.DropTable(
                name: "Town");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "Vehicle_Purpose");

            migrationBuilder.DropTable(
                name: "Vehicle_Types");

            migrationBuilder.DropTable(
                name: "Business_Types");

            migrationBuilder.DropTable(
                name: "Asset_Types");

            migrationBuilder.DropTable(
                name: "LGA");

            migrationBuilder.DropTable(
                name: "LGAClass");
        }
    }
}

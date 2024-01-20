using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SelfPortalAPi.NewModel;

public partial class PinscherSpikeContext : DbContext
{
    public PinscherSpikeContext()
    {
    }

    public PinscherSpikeContext(DbContextOptions<PinscherSpikeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddPayeInputFile> AddPayeInputFiles { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<Agency> Agencies { get; set; }

    public virtual DbSet<AgencyType> AgencyTypes { get; set; }

    public virtual DbSet<AnnualReturn> AnnualReturns { get; set; }

    public virtual DbSet<ApiJsonStr> ApiJsonStrs { get; set; }

    public virtual DbSet<Assessment> Assessments { get; set; }

    public virtual DbSet<AssessmentChild> AssessmentChildren { get; set; }

    public virtual DbSet<AssessmentGroup> AssessmentGroups { get; set; }

    public virtual DbSet<AssessmentItem> AssessmentItems { get; set; }

    public virtual DbSet<AssessmentItemApi> AssessmentItemApis { get; set; }

    public virtual DbSet<AssessmentItemCategory> AssessmentItemCategories { get; set; }

    public virtual DbSet<AssessmentItemSubCategory> AssessmentItemSubCategories { get; set; }

    public virtual DbSet<AssessmentRule> AssessmentRules { get; set; }

    public virtual DbSet<AssessmentRule1> AssessmentRules1 { get; set; }

    public virtual DbSet<AssessmentRuleMasterApi> AssessmentRuleMasterApis { get; set; }

    public virtual DbSet<AssessmentRulesApi> AssessmentRulesApis { get; set; }

    public virtual DbSet<AssessmentStatus> AssessmentStatuses { get; set; }

    public virtual DbSet<AssessmentSubGroup> AssessmentSubGroups { get; set; }

    public virtual DbSet<AssessmentsApi> AssessmentsApis { get; set; }

    public virtual DbSet<AssetTaxPayerDetailsApi> AssetTaxPayerDetailsApis { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<Business> Businesses { get; set; }

    public virtual DbSet<BusinessCategory> BusinessCategories { get; set; }

    public virtual DbSet<BusinessEmployee> BusinessEmployees { get; set; }

    public virtual DbSet<BusinessEmployee1> BusinessEmployees1 { get; set; }

    public virtual DbSet<BusinessEmployee2> BusinessEmployees2 { get; set; }

    public virtual DbSet<BusinessOperation> BusinessOperations { get; set; }

    public virtual DbSet<BusinessSector> BusinessSectors { get; set; }

    public virtual DbSet<BusinessStructure> BusinessStructures { get; set; }

    public virtual DbSet<BusinessSubSector> BusinessSubSectors { get; set; }

    public virtual DbSet<BusinessType> BusinessTypes { get; set; }

    public virtual DbSet<BusinessesApi> BusinessesApis { get; set; }

    public virtual DbSet<BusinessesApiMain> BusinessesApiMains { get; set; }

    public virtual DbSet<BusinessesFullApi> BusinessesFullApis { get; set; }

    public virtual DbSet<ClearanceCertificate> ClearanceCertificates { get; set; }

    public virtual DbSet<CompanyListApi> CompanyListApis { get; set; }

    public virtual DbSet<Cooperate> Cooperates { get; set; }

    public virtual DbSet<Directorate> Directorates { get; set; }

    public virtual DbSet<EconomicActivity> EconomicActivities { get; set; }

    public virtual DbSet<EirsUser> EirsUsers { get; set; }

    public virtual DbSet<employee> Employees { get; set; }

    public virtual DbSet<EmployeeAnnualTax> EmployeeAnnualTaxes { get; set; }

    public virtual DbSet<EmployeeContributionOutputFile> EmployeeContributionOutputFiles { get; set; }

    public virtual DbSet<EmployeesMonthlyIncome> EmployeesMonthlyIncomes { get; set; }

    public virtual DbSet<EmployeesMonthlySchedule> EmployeesMonthlySchedules { get; set; }

    public virtual DbSet<EmployerAssessmentOutputFile> EmployerAssessmentOutputFiles { get; set; }

    public virtual DbSet<Exception> Exceptions { get; set; }

    public virtual DbSet<ExceptionType> ExceptionTypes { get; set; }

    public virtual DbSet<FileStatus> FileStatuses { get; set; }

    public virtual DbSet<FiledFormH> FiledFormHs { get; set; }

    public virtual DbSet<FormEmployee> FormEmployees { get; set; }

    public virtual DbSet<FormH1> FormH1s { get; set; }

    public virtual DbSet<FormH3> FormH3s { get; set; }

    public virtual DbSet<FormMaster> FormMasters { get; set; }

    public virtual DbSet<GroupFormRelation> GroupFormRelations { get; set; }

    public virtual DbSet<GroupMaster> GroupMasters { get; set; }

    public virtual DbSet<Individual> Individuals { get; set; }

    public virtual DbSet<IndividualsApi> IndividualsApis { get; set; }

    public virtual DbSet<IndividualsApiInput> IndividualsApiInputs { get; set; }

    public virtual DbSet<LegacySubmissionsPaye> LegacySubmissionsPayes { get; set; }

    public virtual DbSet<LocalGovernment> LocalGovernments { get; set; }

    public virtual DbSet<LocalGovernmentArea> LocalGovernmentAreas { get; set; }

    public virtual DbSet<LocalGovtPostalCodee> LocalGovtPostalCodees { get; set; }

    public virtual DbSet<MyView> MyViews { get; set; }

    public virtual DbSet<MyView1> MyView1s { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationMethod> NotificationMethods { get; set; }

    public virtual DbSet<NotificationType> NotificationTypes { get; set; }

    public virtual DbSet<PayeInputFile> PayeInputFiles { get; set; }

    public virtual DbSet<PayeOuputFile> PayeOuputFiles { get; set; }

    public virtual DbSet<PayeRole> PayeRoles { get; set; }

    public virtual DbSet<PayeUserType> PayeUserTypes { get; set; }

    public virtual DbSet<PayesubmissionAbhayLive> PayesubmissionAbhayLives { get; set; }

    public virtual DbSet<PaymentFrequency> PaymentFrequencies { get; set; }

    public virtual DbSet<PaymentOption> PaymentOptions { get; set; }

    public virtual DbSet<PreAsessmentTemp> PreAsessmentTemps { get; set; }

    public virtual DbSet<PreAssessment> PreAssessments { get; set; }

    public virtual DbSet<PreAssessment1> PreAssessments1 { get; set; }

    public virtual DbSet<PreAssessmentRdm> PreAssessmentRdms { get; set; }

    public virtual DbSet<PreAssessmentRdmBkp2> PreAssessmentRdmBkp2s { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProfilesApi> ProfilesApis { get; set; }

    public virtual DbSet<Projection> Projections { get; set; }

    public virtual DbSet<RecordLink> RecordLinks { get; set; }

    public virtual DbSet<RefNoPopulate> RefNoPopulates { get; set; }

    public virtual DbSet<RevenueStream> RevenueStreams { get; set; }

    public virtual DbSet<RevenueSubStream> RevenueSubStreams { get; set; }

    public virtual DbSet<RuleEngine> RuleEngines { get; set; }

    public virtual DbSet<SalaryBreakup> SalaryBreakups { get; set; }

    public virtual DbSet<SalaryTypeMaster> SalaryTypeMasters { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleComment> ScheduleComments { get; set; }

    public virtual DbSet<ScheduleRecord> ScheduleRecords { get; set; }

    public virtual DbSet<ScheduleStatus> ScheduleStatuses { get; set; }

    public virtual DbSet<Settlement> Settlements { get; set; }

    public virtual DbSet<SettlementMethod> SettlementMethods { get; set; }

    public virtual DbSet<SettlementStatus> SettlementStatuses { get; set; }

    public virtual DbSet<SspfiledFormH1> SspfiledFormH1s { get; set; }
    public virtual DbSet<SspfiledFormH1ForSP> SspfiledFormH1ForSPs { get; set; }

    public virtual DbSet<SspfiledFormH3> SspfiledFormH3s { get; set; }

    public virtual DbSet<SspformH1> SspformH1s { get; set; }

    public virtual DbSet<SspformH3> SspformH3s { get; set; }

    public virtual DbSet<Sspindividual> Sspindividual { get; set; }

    public virtual DbSet<StateMaster> StateMasters { get; set; }

    public virtual DbSet<Submission> Submissions { get; set; }

    public virtual DbSet<SubmissionsBkpaa> SubmissionsBkpaas { get; set; }

    public virtual DbSet<SubmissionsDefault> SubmissionsDefaults { get; set; }

    public virtual DbSet<TablesApiUpdated> TablesApiUpdateds { get; set; }

    public virtual DbSet<TaxNewYear> TaxNewYears { get; set; }

    public virtual DbSet<TaxOffice> TaxOffices { get; set; }

    public virtual DbSet<TaxPayerRole> TaxPayerRoles { get; set; }

    public virtual DbSet<TaxPayerType> TaxPayerTypes { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    public virtual DbSet<TokenManagement> TokenManagements { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    public virtual DbSet<UserManagement> UserManagements { get; set; }

    public virtual DbSet<VwAssessIndSal> VwAssessIndSals { get; set; }

    public virtual DbSet<VwAssessIndSalRefund> VwAssessIndSalRefunds { get; set; }

    public virtual DbSet<VwAssessmentRule> VwAssessmentRules { get; set; }

    public virtual DbSet<VwAssessmentSearch> VwAssessmentSearches { get; set; }

    public virtual DbSet<VwBusinessCompRelation> VwBusinessCompRelations { get; set; }

    public virtual DbSet<VwBusinessDetail> VwBusinessDetails { get; set; }

    public virtual DbSet<VwClearanceCertReq> VwClearanceCertReqs { get; set; }

    public virtual DbSet<VwCompIndSal> VwCompIndSals { get; set; }

    public virtual DbSet<VwCompany> VwCompanies { get; set; }

    public virtual DbSet<VwCorporatesAsset> VwCorporatesAssets { get; set; }

    public virtual DbSet<VwDistinctIndividual> VwDistinctIndividuals { get; set; }

    public virtual DbSet<VwEmployeeContributionOutputFile> VwEmployeeContributionOutputFiles { get; set; }
    public virtual DbSet<WinastAutoEmailDetail> WinastAutoEmailDetails { get; set; }

    public virtual DbSet<WinastAutoSmsDetail> WinastAutoSmsDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=92.205.57.77;Initial Catalog=pinscher_spike;user id=Admin;password=K5?wh7l4##;MultipleActiveResultSets=True;TrustServerCertificate=True");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddPayeInputFile>(entity =>
        {
            entity.HasKey(e => new { e.CompanyRin, e.BusinessRin, e.TaxYear }).HasName("Input_pk");

            entity.ToTable("AddPayeInputFile");

            entity.Property(e => e.CompanyRin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CompanyRIN");
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.TaxYear)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.ToTable("AdminUser");

            entity.Property(e => e.AdminUserTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue((byte)1);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Agency>(entity =>
        {
            entity.Property(e => e.AgencyId).HasColumnName("agency_id");
            entity.Property(e => e.AgencyCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("agency_create_at");
            entity.Property(e => e.AgencyCreateBy).HasColumnName("agency_create_by");
            entity.Property(e => e.AgencyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agency_name");
            entity.Property(e => e.AgencyStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("agency_status");
            entity.Property(e => e.AgencyType).HasColumnName("agency_type");
        });

        modelBuilder.Entity<AgencyType>(entity =>
        {
            entity.HasKey(e => e.AgencyId);

            entity.ToTable("Agency_Type");

            entity.Property(e => e.AgencyId).HasColumnName("agency_id");
            entity.Property(e => e.AgencyCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("agency_create_at");
            entity.Property(e => e.AgencyCreateBy).HasColumnName("agency_create_by");
            entity.Property(e => e.AgencyStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("agency_status");
            entity.Property(e => e.AgencyType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agency_type");
        });

        modelBuilder.Entity<AnnualReturn>(entity =>
        {
            entity.Property(e => e.business_address).HasColumnName("business_address");
            entity.Property(e => e.business_id).HasColumnName("business_id");
            entity.Property(e => e.business_name).HasColumnName("business_name");
            entity.Property(e => e.company_name).HasColumnName("company_name");
            entity.Property(e => e.corporate_id).HasColumnName("corporate_id");
            entity.Property(e => e.created_at).HasColumnName("created_at");
            entity.Property(e => e.employees_count).HasColumnName("employees_count");
            entity.Property(e => e.industry_sector_name).HasColumnName("industry_sector_name");
            entity.Property(e => e.industry_subsector_name).HasColumnName("industry_subsector_name");
            entity.Property(e => e.lga_name).HasColumnName("lga_name");
            entity.Property(e => e.link_status).HasColumnName("link_status");
            entity.Property(e => e.taxpayer_id).HasColumnName("taxpayer_id");
            entity.Property(e => e.taxpayer_role).HasColumnName("taxpayer_role");
            entity.Property(e => e.town_name).HasColumnName("town_name");
            entity.Property(e => e.ward_name).HasColumnName("ward_name");
        });

        modelBuilder.Entity<ApiJsonStr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("API_JsonStr");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Json).HasColumnType("text");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Assessment>(entity =>
        {
            entity.HasKey(e => e.AssessId);

            entity.Property(e => e.AssessId).HasColumnName("assess_id");
            entity.Property(e => e.AssessCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("assess_create_at");
            entity.Property(e => e.AssessCreateBy).HasColumnName("assess_create_by");
            entity.Property(e => e.AssessmentAmount).HasColumnName("assessment_amount");
            entity.Property(e => e.AssessmentDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("assessment_date");
            entity.Property(e => e.AssessmentRef)
                .IsUnicode(false)
                .HasColumnName("assessment_ref");
            entity.Property(e => e.AssessmentRule)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assessment_rule");
            entity.Property(e => e.AssetRin).HasColumnName("asset_rin");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
            entity.Property(e => e.CompanyRin)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.CompanyTin)
                .IsUnicode(false)
                .HasColumnName("company_tin");
            entity.Property(e => e.ProfileRef).HasColumnName("profile_ref");
            entity.Property(e => e.RuleCode).HasColumnName("rule_code");
            entity.Property(e => e.SettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("settlement_date");
            entity.Property(e => e.SettlementDueDate)
                .HasColumnType("datetime")
                .HasColumnName("settlement_due_date");
            entity.Property(e => e.SettlementStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("DUE")
                .HasColumnName("settlement_status");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tax_payer_name");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tax_payer_rin");
            entity.Property(e => e.TaxPayerType).HasColumnName("tax_payer_type");
            entity.Property(e => e.TaxYear).HasColumnName("tax_year");
        });

        modelBuilder.Entity<AssessmentChild>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AssessmentChild");

            entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AssessmentChildRef)
                .IsUnicode(false)
                .HasColumnName("assessment_child_ref");
            entity.Property(e => e.AssessmentRef)
                .IsUnicode(false)
                .HasColumnName("assessment_ref");
            entity.Property(e => e.Datecreated).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsPaid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MonthTax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NotificationDate).HasColumnType("datetime");
            entity.Property(e => e.PaidOn).HasColumnType("datetime");
            entity.Property(e => e.YearTax)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AssessmentGroup>(entity =>
        {
            entity.HasKey(e => e.AssessId);

            entity.ToTable("Assessment_Groups");

            entity.Property(e => e.AssessId).HasColumnName("assess_id");
            entity.Property(e => e.AssessCreateAt).HasColumnName("assess_create_at");
            entity.Property(e => e.AssessCreateBy)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("assess_create_by");
            entity.Property(e => e.AssessStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("assess_status");
            entity.Property(e => e.AssessmentGroup1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assessment_group");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
        });

        modelBuilder.Entity<AssessmentItem>(entity =>
        {
            entity.HasKey(e => e.AssessItemId);

            entity.ToTable("Assessment_Items");

            entity.Property(e => e.AssessItemId).HasColumnName("assess_item_id");
            entity.Property(e => e.AssessItemCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("assess_item_create_at");
            entity.Property(e => e.AssessItemCreateBy).HasColumnName("assess_item_create_by");
            entity.Property(e => e.AssessmentGroup).HasColumnName("assessment_group");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assessment_item_name");
            entity.Property(e => e.AssessmentSubGroup).HasColumnName("assessment_sub_group");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
            entity.Property(e => e.Computation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("computation");
            entity.Property(e => e.EarlyAmount).HasColumnName("early_amount");
            entity.Property(e => e.ItemCategory).HasColumnName("item_category");
            entity.Property(e => e.ItemRef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("item_ref");
            entity.Property(e => e.ItemSubCategory).HasColumnName("item_sub_category");
            entity.Property(e => e.LateAmount).HasColumnName("late_amount");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.RevenueAgency).HasColumnName("revenue_agency");
            entity.Property(e => e.RevenueStream).HasColumnName("revenue_stream");
            entity.Property(e => e.RevenueSubStream).HasColumnName("revenue_sub_stream");
            entity.Property(e => e.TaxAmount).HasColumnName("tax_amount");
            entity.Property(e => e.TaxBaseAmount).HasColumnName("tax_base_amount");
        });

        modelBuilder.Entity<AssessmentItemApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Assessment_Item_API");

            entity.HasIndex(e => new { e.AssetRin, e.AssessmentRuleCode }, "Ind_Assessment_Item_API");

            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.AgencyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentGroupId).HasColumnName("AssessmentGroupID");
            entity.Property(e => e.AssessmentGroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentItemCategoryId).HasColumnName("AssessmentItemCategoryID");
            entity.Property(e => e.AssessmentItemCategoryName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentItemReferenceNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentItemSubCategoryId).HasColumnName("AssessmentItemSubCategoryID");
            entity.Property(e => e.AssessmentItemSubCategoryName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentSubGroupId).HasColumnName("AssessmentSubGroupID");
            entity.Property(e => e.AssessmentSubGroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ComputationId).HasColumnName("ComputationID");
            entity.Property(e => e.ComputationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Percentage)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProfileDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.ProfileReferenceNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.RevenueStreamName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RevenueSubStreamId).HasColumnName("RevenueSubStreamID");
            entity.Property(e => e.RevenueSubStreamName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TaxAmount)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaxBaseAmount)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AssessmentItemCategory>(entity =>
        {
            entity.HasKey(e => e.AssitemId);

            entity.ToTable("Assessment_Item_Categories");

            entity.Property(e => e.AssitemId).HasColumnName("assitem_id");
            entity.Property(e => e.AssitemCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("assitem_create_at");
            entity.Property(e => e.AssitemCreateBy).HasColumnName("assitem_create_by");
            entity.Property(e => e.AssitemStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("assitem_status");
            entity.Property(e => e.ItemCategory)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("item_category");
        });

        modelBuilder.Entity<AssessmentItemSubCategory>(entity =>
        {
            entity.HasKey(e => e.ItemCategoryId);

            entity.ToTable("Assessment_Item_Sub_Category");

            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.ItemCategory).HasColumnName("item_category");
            entity.Property(e => e.ItemCategoryCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("item_category_create_at");
            entity.Property(e => e.ItemCategoryCreateBy).HasColumnName("item_category_create_by");
            entity.Property(e => e.ItemCategoryStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("item_category_status");
            entity.Property(e => e.ItemSubCategory)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("item_sub_category");
        });

        modelBuilder.Entity<AssessmentRule>(entity =>
        {
            entity.HasKey(e => e.AssessRulesId);

            entity.ToTable("Assessment_Rules");

            entity.Property(e => e.AssessRulesId).HasColumnName("assess_rules_id");
            entity.Property(e => e.AssessRulesCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("assess_rules_create_at");
            entity.Property(e => e.AssessRulesCreateBy).HasColumnName("assess_rules_create_by");
            entity.Property(e => e.AssessmentAmount).HasColumnName("assessment_amount");
            entity.Property(e => e.AssessmentItems)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("assessment_items");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("assessment_rule_name");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Frequency).HasColumnName("frequency");
            entity.Property(e => e.PaymentOptions).HasColumnName("payment_options");
            entity.Property(e => e.Profile).HasColumnName("profile");
            entity.Property(e => e.RuleCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rule_code");
            entity.Property(e => e.RuleRun).HasColumnName("rule_run");
            entity.Property(e => e.SettlementMethods)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("settlement_methods");
            entity.Property(e => e.TaxYear).HasColumnName("tax_year");
        });

        modelBuilder.Entity<AssessmentRule1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AssessmentRules");

            entity.Property(e => e.AssessmentRuleCode).HasMaxLength(255);
            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName).HasMaxLength(255);
            entity.Property(e => e.PaymentFrequencyId).HasColumnName("PaymentFrequencyID");
            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.RuleRunId).HasColumnName("RuleRunID");
        });

        modelBuilder.Entity<AssessmentRuleMasterApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Assessment_rule_master_api", "spike");

            entity.Property(e => e.AssessmentRuleCode)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.AssessmentRuleId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PaymentFrequencyId).HasColumnName("PaymentFrequencyID");
            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.ProfileId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ProfileID");
            entity.Property(e => e.RuleRunId).HasColumnName("RuleRunID");
            entity.Property(e => e.TaxMonth)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<AssessmentRulesApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Assessment_Rules_API");

            entity.HasIndex(e => e.TaxPayerRin, "Ind_Assessment_Rules_API");

            entity.Property(e => e.AssessmentRuleCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PaymentFrequencyId).HasColumnName("PaymentFrequencyID");
            entity.Property(e => e.PaymentFrequencyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.PaymentOptionName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProfileDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.ProfileReferenceNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RuleRunId).HasColumnName("RuleRunID");
            entity.Property(e => e.RuleRunName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaxMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaxYear)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AssessmentStatus>(entity =>
        {
            entity.HasKey(e => e.AssStId);

            entity.ToTable("Assessment_Status");

            entity.Property(e => e.AssStId)
                .ValueGeneratedNever()
                .HasColumnName("Ass_st_id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.AssNextStId).HasColumnName("ass_next_st_id");
            entity.Property(e => e.AssStCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Ass_st_create_at");
            entity.Property(e => e.AssStCreateBy)
                .HasMaxLength(50)
                .HasColumnName("Ass_st_create_by");
            entity.Property(e => e.AssessmentStatus1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assessment_status");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("status_description");
        });

        modelBuilder.Entity<AssessmentSubGroup>(entity =>
        {
            entity.HasKey(e => e.AssessId);

            entity.ToTable("Assessment_Sub_Groups");

            entity.Property(e => e.AssessId).HasColumnName("assess_id");
            entity.Property(e => e.AssessCreateAt).HasColumnName("assess_create_at");
            entity.Property(e => e.AssessCreateBy)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("assess_create_by");
            entity.Property(e => e.AssessStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("assess_status");
            entity.Property(e => e.AssessmentGroup).HasColumnName("assessment_group");
            entity.Property(e => e.AssessmentSubGroup1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assessment_sub_group");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
        });

        modelBuilder.Entity<AssessmentsApi>(entity =>
        {
            entity.HasKey(e => e.AssessmentId);

            entity.ToTable("Assessments_API");

            entity.Property(e => e.AssessmentId)
                .ValueGeneratedNever()
                .HasColumnName("AssessmentID");
            entity.Property(e => e.AssessmentDate).HasColumnType("datetime");
            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentItemReferenceNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentNotes)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRefNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProfileDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProfileId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProfileID");
            entity.Property(e => e.ProfileReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SettlementDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementDueDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementStatusId).HasColumnName("SettlementStatusID");
            entity.Property(e => e.SettlementStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AssetTaxPayerDetailsApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AssetTaxPayerDetails_API");

            entity.Property(e => e.Active)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ActiveText).IsUnicode(false);
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetLga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetLGA");
            entity.Property(e => e.AssetName).IsUnicode(false);
            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName).IsUnicode(false);
            entity.Property(e => e.BuildingUnitId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BuildingUnitID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TaxPayerEmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerMobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerName).IsUnicode(false);
            entity.Property(e => e.TaxPayerRinnumber)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRINNumber");
            entity.Property(e => e.TaxPayerRoleId).HasColumnName("TaxPayerRoleID");
            entity.Property(e => e.TaxPayerRoleName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName).IsUnicode(false);
            entity.Property(e => e.Tpaid).HasColumnName("TPAID");
            entity.Property(e => e.UnitNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.HasKey(e => e.AssetId);

            entity.ToTable("Asset_Type");

            entity.Property(e => e.AssetId).HasColumnName("asset_id");
            entity.Property(e => e.AssetCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("asset_create_at");
            entity.Property(e => e.AssetCreateBy).HasColumnName("asset_create_by");
            entity.Property(e => e.AssetStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("asset_status");
            entity.Property(e => e.AssetType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asset_type");
        });

        modelBuilder.Entity<Building>(entity =>
        {
            entity.Property(e => e.BuildingId)
                .ValueGeneratedNever()
                .HasColumnName("building_id");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
            entity.Property(e => e.BuildingAccupancy).HasColumnName("building_accupancy");
            entity.Property(e => e.BuildingAccupancyType).HasColumnName("building_accupancy_type");
            entity.Property(e => e.BuildingCompletion).HasColumnName("building_completion");
            entity.Property(e => e.BuildingCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("building_create_at");
            entity.Property(e => e.BuildingCreateBy).HasColumnName("building_create_by");
            entity.Property(e => e.BuildingFunction)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("building_function");
            entity.Property(e => e.BuildingName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("building_name");
            entity.Property(e => e.BuildingNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("building_number");
            entity.Property(e => e.BuildingOwnership).HasColumnName("building_ownership");
            entity.Property(e => e.BuildingPurpose).HasColumnName("building_purpose");
            entity.Property(e => e.BuildingRin)
                .ValueGeneratedOnAdd()
                .HasColumnName("building_rin");
            entity.Property(e => e.BuildingTagNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("building_tag_number");
            entity.Property(e => e.BuildingType).HasColumnName("building_type");
            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("latitude");
            entity.Property(e => e.Lga).HasColumnName("lga");
            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("longitude");
            entity.Property(e => e.OffStreetName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("off_street_name");
            entity.Property(e => e.Profile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profile");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.StreetName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("street_name");
            entity.Property(e => e.Town).HasColumnName("town");
            entity.Property(e => e.Ward).HasColumnName("ward");
        });

        modelBuilder.Entity<Business>(entity =>
        {
            entity.Property(e => e.BusinessAddress).HasColumnName("business_address");
            entity.Property(e => e.BusinessId).HasColumnName("business_id");
            entity.Property(e => e.BusinessName).HasColumnName("business_name");
            entity.Property(e => e.CompanyId)
                .HasDefaultValue("")
                .HasColumnName("company_id");
            entity.Property(e => e.CooperateId).HasColumnName("cooperate_Id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.EmployeesCount).HasColumnName("employees_count");
            entity.Property(e => e.IndustrySectorName).HasColumnName("industry_sector_name");
            entity.Property(e => e.IndustrySubsectorName).HasColumnName("industry_subsector_name");
            entity.Property(e => e.LgaName).HasColumnName("lga_name");
            entity.Property(e => e.LinkStatus).HasColumnName("link_status");
            entity.Property(e => e.TaxpayerRole).HasColumnName("taxpayer_role");
            entity.Property(e => e.TaxpayerRoleId).HasColumnName("taxpayer_role_id");
            entity.Property(e => e.TownName).HasColumnName("town_name");
            entity.Property(e => e.WardName).HasColumnName("ward_name");
        });

        modelBuilder.Entity<BusinessCategory>(entity =>
        {
            entity.HasKey(e => e.BsCtId).HasName("PK_business_category");

            entity.ToTable("Business_Category");

            entity.Property(e => e.BsCtId).HasColumnName("bs_ct_id");
            entity.Property(e => e.BsCtCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("bs_ct_create_at");
            entity.Property(e => e.BsCtCreateBy).HasColumnName("bs_ct_create_by");
            entity.Property(e => e.BsCtStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bs_ct_status");
            entity.Property(e => e.BusinessCategory1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("business_category");
            entity.Property(e => e.BusinessType).HasColumnName("business_type");
        });

        modelBuilder.Entity<BusinessEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Business_Employee");

            entity.Property(e => e.AssetRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeStatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OtherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BusinessEmployee1>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("BusinessEmployee");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.EmpployeeStatus).HasColumnName("Empployee_Status");
            entity.Property(e => e.StartDate).HasColumnName("Start_Date");
        });

        modelBuilder.Entity<BusinessEmployee2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Business_Employee");

            entity.ToTable("BusinessEmployees");

            entity.Property(e => e.AssetRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeStatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BusinessOperation>(entity =>
        {
            entity.HasKey(e => e.BsOpId).HasName("PK_business_operations");

            entity.ToTable("Business_Operations");

            entity.Property(e => e.BsOpId).HasColumnName("bs_op_id");
            entity.Property(e => e.BsOpCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("bs_op_create_at");
            entity.Property(e => e.BsOpCreateBy).HasColumnName("bs_op_create_by");
            entity.Property(e => e.BsOpStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bs_op_status");
            entity.Property(e => e.BusinessOperations)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("business_operations");
            entity.Property(e => e.BusinessType).HasColumnName("business_type");
        });

        modelBuilder.Entity<BusinessSector>(entity =>
        {
            entity.HasKey(e => e.BsScId).HasName("PK_business_sectors");

            entity.ToTable("Business_Sectors");

            entity.Property(e => e.BsScId)
                .ValueGeneratedNever()
                .HasColumnName("bs_sc_id");
            entity.Property(e => e.BsScCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("bs_sc_create_at");
            entity.Property(e => e.BsScCreateBy).HasColumnName("bs_sc_create_by");
            entity.Property(e => e.BsScStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bs_sc_status");
            entity.Property(e => e.BusinessCategory).HasColumnName("business_category");
            entity.Property(e => e.BusinessSector1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("business_sector");
            entity.Property(e => e.BusinessType).HasColumnName("business_type");
        });

        modelBuilder.Entity<BusinessStructure>(entity =>
        {
            entity.HasKey(e => e.BsStId).HasName("PK_business_structure");

            entity.ToTable("Business_Structure");

            entity.Property(e => e.BsStId)
                .ValueGeneratedNever()
                .HasColumnName("bs_st_id");
            entity.Property(e => e.BsCtStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bs_ct_status");
            entity.Property(e => e.BsStCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("bs_st_create_at");
            entity.Property(e => e.BsStCreateBy).HasColumnName("bs_st_create_by");
            entity.Property(e => e.BusinessStructure1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("business_structure");
            entity.Property(e => e.BusinessType).HasColumnName("business_type");
        });

        modelBuilder.Entity<BusinessSubSector>(entity =>
        {
            entity.HasKey(e => e.BsSbId).HasName("PK_business_sub_sectors1");

            entity.ToTable("Business_Sub_Sectors");

            entity.Property(e => e.BsSbId)
                .ValueGeneratedNever()
                .HasColumnName("bs_sb_id");
            entity.Property(e => e.BsSbCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("bs_sb_create_at");
            entity.Property(e => e.BsSbCreateBy).HasColumnName("bs_sb_create_by");
            entity.Property(e => e.BsSbStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bs_sb_status");
            entity.Property(e => e.BusinessCategory).HasColumnName("business_category");
            entity.Property(e => e.BusinessSector).HasColumnName("business_sector");
            entity.Property(e => e.BusinessSubSector1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("business_sub_sector");
            entity.Property(e => e.BusinessType).HasColumnName("business_type");
        });

        modelBuilder.Entity<BusinessType>(entity =>
        {
            entity.HasKey(e => e.BusinessTypeId).HasName("PK_Business_Type_Type");

            entity.ToTable("Business_Type");

            entity.Property(e => e.BusinessTypeId).HasColumnName("Business_Type_id");
            entity.Property(e => e.BusinessType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Business_Type");
            entity.Property(e => e.BusinessTypeCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Business_Type_create_at");
            entity.Property(e => e.BusinessTypeCreateBy).HasColumnName("Business_Type_create_by");
            entity.Property(e => e.BusinessTypeStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Business_Type_status");
        });

        modelBuilder.Entity<BusinessesApi>(entity =>
        {
            entity.HasKey(e => e.BusinessId);

            entity.ToTable("Businesses_API");

            entity.HasIndex(e => e.BusinessRin, "Ind_Businesses_API");

            entity.Property(e => e.BusinessId)
                .ValueGeneratedNever()
                .HasColumnName("BusinessID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BusinessCategoryId).HasColumnName("BusinessCategoryID");
            entity.Property(e => e.BusinessCategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BusinessNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessOperationId).HasColumnName("BusinessOperationID");
            entity.Property(e => e.BusinessOperationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.BusinessSectorId).HasColumnName("BusinessSectorID");
            entity.Property(e => e.BusinessSectorName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessStructureId).HasColumnName("BusinessStructureID");
            entity.Property(e => e.BusinessStructureName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessSubSectorId).HasColumnName("BusinessSubSectorID");
            entity.Property(e => e.BusinessSubSectorName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.BusinessTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.Lganame)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.SizeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BusinessesApiMain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Business__3214EC072C465F80");

            entity.ToTable("Businesses_API_Main");

            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BusinessCategoryId).HasColumnName("BusinessCategoryID");
            entity.Property(e => e.BusinessCategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BusinessNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessOperationId).HasColumnName("BusinessOperationID");
            entity.Property(e => e.BusinessOperationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.BusinessSectorId).HasColumnName("BusinessSectorID");
            entity.Property(e => e.BusinessSectorName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessStructureId).HasColumnName("BusinessStructureID");
            entity.Property(e => e.BusinessStructureName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessSubSectorId).HasColumnName("BusinessSubSectorID");
            entity.Property(e => e.BusinessSubSectorName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.BusinessTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.Lganame)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.SizeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BusinessesFullApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Businesses_Full_API");

            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BusinessCategoryId).HasColumnName("BusinessCategoryID");
            entity.Property(e => e.BusinessCategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BusinessNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessOperationId).HasColumnName("BusinessOperationID");
            entity.Property(e => e.BusinessOperationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.BusinessSectorId).HasColumnName("BusinessSectorID");
            entity.Property(e => e.BusinessSectorName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessStructureId).HasColumnName("BusinessStructureID");
            entity.Property(e => e.BusinessStructureName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessSubSectorId).HasColumnName("BusinessSubSectorID");
            entity.Property(e => e.BusinessSubSectorName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.BusinessTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.Lganame)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.SizeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClearanceCertificate>(entity =>
        {
            entity.HasKey(e => e.CcId);

            entity.ToTable("Clearance_Certificates");

            entity.Property(e => e.CcId).HasColumnName("cc_id");
            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asset_rin");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
            entity.Property(e => e.CcCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("cc_create_at");
            entity.Property(e => e.CcCreateBy).HasColumnName("cc_create_by");
            entity.Property(e => e.CertificateNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("certificate_number");
            entity.Property(e => e.CertificateRef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("certificate_ref");
            entity.Property(e => e.CertificateStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("certificate_status");
            entity.Property(e => e.CompanyRin)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.CompanyTin)
                .IsUnicode(false)
                .HasColumnName("CompanyTIN");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiry_date");
            entity.Property(e => e.FinancialYear).HasColumnName("financial_year");
            entity.Property(e => e.IssueDate)
                .HasColumnType("datetime")
                .HasColumnName("issue_date");
            entity.Property(e => e.MonthCertificate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("month_certificate");
            entity.Property(e => e.RevenueStream).HasColumnName("revenue_stream");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tax_payer_name");
            entity.Property(e => e.TaxPayerRin).HasColumnName("tax_payer_rin");
            entity.Property(e => e.TaxPayerType).HasColumnName("tax_payer_type");
        });

        modelBuilder.Entity<CompanyListApi>(entity =>
        {
            entity.HasKey(e => e.CompanyListId).IsClustered(false);

            entity.ToTable("CompanyList_API");

            entity.HasIndex(e => e.TaxPayerId, "ClusteredIndex-20190508-102124").IsClustered();

            entity.HasIndex(e => e.TaxPayerRin, "Ind_CompanyList_API");

            entity.Property(e => e.CompanyListId).HasColumnName("CompanyListID");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<Cooperate>(entity =>
        {
            entity.Property(e => e.active_status).HasColumnName("active_status");
            entity.Property(e => e.cac_number).HasColumnName("cac_number");
            entity.Property(e => e.company_name).HasColumnName("company_name");
            entity.Property(e => e.company_type_id).HasColumnName("company_type_id");
            entity.Property(e => e.contact_address).HasColumnName("contact_address");
            entity.Property(e => e.corporate_logo).HasColumnName("corporate_logo");
            entity.Property(e => e.created_at).HasColumnName("created_at");
            entity.Property(e => e.created_by_app_id).HasColumnName("created_by_app_id");
            entity.Property(e => e.economic_activity_id).HasColumnName("economic_activity_id");
            entity.Property(e => e.email).HasColumnName("email");
            entity.Property(e => e.email_2).HasColumnName("email_2");
            entity.Property(e => e.has_valid_email).HasColumnName("has_valid_email");
            entity.Property(e => e.industry_sector_id).HasColumnName("industry_sector_id");
            entity.Property(e => e.lga_code).HasColumnName("lga_code");
            entity.Property(e => e.normalized_state_tin).HasColumnName("normalized_state_tin");
            entity.Property(e => e.parent_taxpayer_id).HasColumnName("parent_taxpayer_id");
            entity.Property(e => e.phone).HasColumnName("phone");
            entity.Property(e => e.phone_2).HasColumnName("phone_2");
            entity.Property(e => e.reminder_annual_projection_sent_at).HasColumnName("reminder_annual_projection_sent_at");
            entity.Property(e => e.reminder_annual_return_sent_at).HasColumnName("reminder_annual_return_sent_at");
            entity.Property(e => e.reminder_sent_at).HasColumnName("reminder_sent_at");
            entity.Property(e => e.state_code).HasColumnName("state_code");
            entity.Property(e => e.state_tin).HasColumnName("state_tin");
            entity.Property(e => e.status).HasColumnName("status");
            entity.Property(e => e.tax_office_id).HasColumnName("tax_office_id");
            entity.Property(e => e.taxpayer_id).HasColumnName("taxpayer_id");
            entity.Property(e => e.tin).HasColumnName("tin");
            entity.Property(e => e.updated_at).HasColumnName("updated_at");
        });

        modelBuilder.Entity<Directorate>(entity =>
        {
            entity.HasKey(e => e.DirectoratesId);

            entity.Property(e => e.DirectoratesId).HasColumnName("directorates_id");
            entity.Property(e => e.Directorate1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("directorate");
            entity.Property(e => e.DirectoratesCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("directorates_create_at");
            entity.Property(e => e.DirectoratesCreateBy).HasColumnName("directorates_create_by");
            entity.Property(e => e.RevenueStream).HasColumnName("revenue_stream");
        });

        modelBuilder.Entity<EconomicActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_economic_activities");

            entity.ToTable("Economic_Activities");

            entity.Property(e => e.Activity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Create_at");
            entity.Property(e => e.CreateBy).HasColumnName("Create_by");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerType).HasColumnName("Tax_payer_type");
        });

        modelBuilder.Entity<EirsUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("Eirs_User");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("created_on");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mobile_no");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_by");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("modified_on");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<employee>(entity =>
        {
            entity.ToTable("employees");

            entity.Property(e => e.asset_id).HasColumnName("asset_id");
            entity.Property(e => e.basic).HasColumnName("basic");
            entity.Property(e => e.business_id).HasColumnName("business_id");
            entity.Property(e => e.bvn).HasColumnName("bvn");
            entity.Property(e => e.corporate_id).HasColumnName("corporate_id");
            entity.Property(e => e.cra).HasColumnName("cra");
            entity.Property(e => e.created_at).HasColumnName("created_at");
            entity.Property(e => e.deleted_at).HasColumnName("deleted_at");
            entity.Property(e => e.designation).HasColumnName("designation");
            entity.Property(e => e.email).HasColumnName("email");
            entity.Property(e => e.first_name).HasColumnName("first_name");
            entity.Property(e => e.gross_income).HasColumnName("gross_income");
            entity.Property(e => e.home_address).HasColumnName("home_address");
            entity.Property(e => e.last_name).HasColumnName("last_name");
            entity.Property(e => e.lga_code).HasColumnName("lga_code");
            entity.Property(e => e.life_assurance).HasColumnName("life_assurance");
            entity.Property(e => e.nationality).HasColumnName("nationality");
            entity.Property(e => e.nhf).HasColumnName("nhf");
            entity.Property(e => e.nhis).HasColumnName("nhis");
            entity.Property(e => e.nin).HasColumnName("nin");
            entity.Property(e => e.normalized_state_tin).HasColumnName("normalized_state_tin");
            entity.Property(e => e.other_income).HasColumnName("other_income");
            entity.Property(e => e.other_name).HasColumnName("other_name");
            entity.Property(e => e.pension).HasColumnName("pension");
            entity.Property(e => e.phone).HasColumnName("phone");
            entity.Property(e => e.rent).HasColumnName("rent");
            entity.Property(e => e.start_month).HasColumnName("start_month");
            entity.Property(e => e.state_code).HasColumnName("state_code");
            entity.Property(e => e.state_tin).HasColumnName("state_tin");
            entity.Property(e => e.status).HasColumnName("status");
            entity.Property(e => e.taxpayer_id).HasColumnName("taxpayer_id");
            entity.Property(e => e.tin).HasColumnName("tin");
            entity.Property(e => e.title).HasColumnName("title");
            entity.Property(e => e.total_income).HasColumnName("total_income");
            entity.Property(e => e.transport).HasColumnName("transport");
            entity.Property(e => e.updated_at).HasColumnName("updated_at");
            entity.Property(e => e.zip_code).HasColumnName("zip_code");
        });

        modelBuilder.Entity<EmployeeAnnualTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EmployeeAnnualTax");

            entity.Property(e => e.AnnualTax).HasColumnType("numeric(29, 2)");
            entity.Property(e => e.AssessmentYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Assessment_Year");
            entity.Property(e => e.EmployeeRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeRIN");
        });

        modelBuilder.Entity<EmployeeContributionOutputFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeContributionOutputFile");

            entity.Property(e => e.AprilContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AugustContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DecemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EmployeRin)
                .IsUnicode(false)
                .HasColumnName("EmployeRIN");
            entity.Property(e => e.FebruaryContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.JanuaryContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JulyContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JuneContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MarchContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MayContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NovemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OctoberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SpetemberContributions).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<EmployeesMonthlyIncome>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("EmployeesMonthlyIncome");

            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.BusinessId)
                .HasMaxLength(50)
                .HasColumnName("BusinessID");
            entity.Property(e => e.LifeAssurance).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Ltg).HasColumnName("LTG");
            entity.Property(e => e.Meal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Nhf).HasColumnName("NHF");
            entity.Property(e => e.Nhis).HasColumnName("NHIS");
            entity.Property(e => e.Pension)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("pension");
            entity.Property(e => e.Rent).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Utility).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<EmployeesMonthlySchedule>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("EmployeesMonthlySchedule");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.ChargableIncome).HasColumnName("Chargable_Income");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CompanyID");
            entity.Property(e => e.Cra).HasColumnName("CRA");
            entity.Property(e => e.GrossIncome).HasColumnName("Gross_Income");
            entity.Property(e => e.Ltg).HasColumnName("LTG");
            entity.Property(e => e.Nhf).HasColumnName("NHF");
            entity.Property(e => e.Nhis).HasColumnName("NHIS");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TaxFreePay).HasColumnName("Tax_Free_Pay");
            entity.Property(e => e.TotalIncome).HasColumnName("Total_Income");
        });

        modelBuilder.Entity<EmployerAssessmentOutputFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployerAssessmentOutputFile");

            entity.Property(e => e.AprilCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AugustCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DecemberCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EmployerRin)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.FebruaryCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.JanuaryCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JulyCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JuneCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MarchCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MayCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NovemberCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OctoberCollections).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SpetemberCollections).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<Exception>(entity =>
        {
            entity.HasKey(e => e.ExceptionsId);

            entity.Property(e => e.ExceptionsId).HasColumnName("exceptions_id");
            entity.Property(e => e.AssessmentAmount).HasColumnName("assessment_amount");
            entity.Property(e => e.AssessmentRef).HasColumnName("assessment_ref");
            entity.Property(e => e.ExceptionsAmount).HasColumnName("exceptions_amount");
            entity.Property(e => e.ExceptionsCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("exceptions_create_at");
            entity.Property(e => e.ExceptionsCreateBy).HasColumnName("exceptions_create_by");
            entity.Property(e => e.ExceptionsRef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("exceptions_ref");
            entity.Property(e => e.ExceptionsType).HasColumnName("exceptions_type");
            entity.Property(e => e.SettlementAmount).HasColumnName("settlement_amount");
            entity.Property(e => e.SettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("settlement_date");
            entity.Property(e => e.SettlementRef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("settlement_ref");
            entity.Property(e => e.SettlementStatus).HasColumnName("settlement_status");
        });

        modelBuilder.Entity<ExceptionType>(entity =>
        {
            entity.ToTable("Exception_Types");

            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Create_at");
            entity.Property(e => e.CreateBy).HasColumnName("Create_by");
            entity.Property(e => e.ExceptionTypes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Exception_types");
        });

        modelBuilder.Entity<FileStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileStatus");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.StatusName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FiledFormH>(entity =>
        {
            entity.ToTable("FiledFormH");

            entity.Property(e => e.AnnualTaxPaid).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<FormEmployee>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("FormEmployee");

            entity.Property(e => e.BusinessId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("businessID");
            entity.Property(e => e.ChargableIncome).HasColumnName("Chargable_Income");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.Cra).HasColumnName("CRA");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.GrossIncome).HasColumnName("Gross_Income");
            entity.Property(e => e.Ltg).HasColumnName("LTG");
            entity.Property(e => e.Nhf).HasColumnName("NHF");
            entity.Property(e => e.Nhis).HasColumnName("NHIS");
            entity.Property(e => e.Rent).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.StatusId)
                .HasMaxLength(1)
                .HasColumnName("StatusID");
            entity.Property(e => e.TaxFreePay).HasColumnName("Tax_Free_Pay");
            entity.Property(e => e.TotalIncome).HasColumnName("Total_Income");
        });

        modelBuilder.Entity<FormH1>(entity =>
        {
            entity.Property(e => e.ANNUALTAXPAID).HasColumnName("ANNUALTAXPAID");
            entity.Property(e => e.CONSOLIDATEDRELIEFALLOWANCECRA).HasColumnName("CONSOLIDATEDRELIEFALLOWANCECRA");
            entity.Property(e => e.FIRSTNAME).HasColumnName("FIRSTNAME");
            entity.Property(e => e.HOMEADDRESS).HasColumnName("HOMEADDRESS");
            entity.Property(e => e.JTBTIN).HasColumnName("JTBTIN");
            entity.Property(e => e.LIFEASSURANCE).HasColumnName("LIFEASSURANCE");
            entity.Property(e => e.NATIONALITY).HasColumnName("NATIONALITY");
            entity.Property(e => e.NHF).HasColumnName("NHF");
            entity.Property(e => e.NHIS).HasColumnName("NHIS");
            entity.Property(e => e.NIN).HasColumnName("NIN");
            entity.Property(e => e.OTHERNAME).HasColumnName("OTHERNAME");
            entity.Property(e => e.PENSION).HasColumnName("PENSION");
            entity.Property(e => e.PHONENUMBER).HasColumnName("PHONENUMBER");
            entity.Property(e => e.RIN).HasColumnName("RIN");
            entity.Property(e => e.SURNAME).HasColumnName("SURNAME");
            entity.Property(e => e.TOTALMONTHSPAID).HasColumnName("TOTALMONTHSPAID");
        });

        modelBuilder.Entity<FormH3>(entity =>
        {
            entity.Property(e => e.FIRSTNAME).HasColumnName("FIRSTNAME");
            entity.Property(e => e.HOMEADDRESS).HasColumnName("HOMEADDRESS");
            entity.Property(e => e.JTBTIN).HasColumnName("JTBTIN");
            entity.Property(e => e.LIFEASSURANCE).HasColumnName("LIFEASSURANCE");
            entity.Property(e => e.NATIONALITY).HasColumnName("NATIONALITY");
            entity.Property(e => e.NHF).HasColumnName("NHF");
            entity.Property(e => e.NHIS).HasColumnName("NHIS");
            entity.Property(e => e.NIN).HasColumnName("NIN");
            entity.Property(e => e.OTHERNAME).HasColumnName("OTHERNAME");
            entity.Property(e => e.PENSION).HasColumnName("PENSION");
            entity.Property(e => e.PHONENUMBER).HasColumnName("PHONENUMBER");
            entity.Property(e => e.RIN).HasColumnName("RIN");
            entity.Property(e => e.STARTMONTH).HasColumnName("STARTMONTH");
            entity.Property(e => e.SURNAME).HasColumnName("SURNAME");
        });

        modelBuilder.Entity<FormMaster>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("FormMaster");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FormAppType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormPath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<GroupFormRelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupFormRelation");

            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedOn).HasColumnName("created_on");
            entity.Property(e => e.FormId).HasColumnName("form_id");
            entity.Property(e => e.GroupFormId)
                .ValueGeneratedOnAdd()
                .HasColumnName("group_form_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
        });

        modelBuilder.Entity<GroupMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupMaster");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("created_on");
            entity.Property(e => e.GroupId)
                .ValueGeneratedOnAdd()
                .HasColumnName("group_id");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("group_name");
            entity.Property(e => e.GroupStatusAI)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("group_status_A_I");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_by");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("modified_on");
        });

        modelBuilder.Entity<Individual>(entity =>
        {
            entity.HasKey(e => e.IndId);

            entity.Property(e => e.IndId).HasColumnName("ind_id");
            entity.Property(e => e.AccountBalance)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("account_balance");
            entity.Property(e => e.BioMetricDetails)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("bio_metric_details");
            entity.Property(e => e.BusinessRin)
                .IsUnicode(false)
                .HasColumnName("business_rin");
            entity.Property(e => e.CompanyRin)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.CompanyTin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("company_tin");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("date_of_birth");
            entity.Property(e => e.EconomicActivity).HasColumnName("economic_activity");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_address_1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_address_2");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.IndCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ind_create_at");
            entity.Property(e => e.IndCreateBy).HasColumnName("ind_create_by");
            entity.Property(e => e.IsValidated)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.MaritalStatus).HasColumnName("marital_status");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.MobileNumber1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mobile_number_1");
            entity.Property(e => e.MobileNumber2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mobile_number_2");
            entity.Property(e => e.Nationality).HasColumnName("nationality");
            entity.Property(e => e.PrefferedNotificationMethod).HasColumnName("preffered_notification_method");
            entity.Property(e => e.TaxOffice).HasColumnName("tax_office");
            entity.Property(e => e.TaxPayerStatus).HasColumnName("tax_payer_status");
            entity.Property(e => e.TaxPayerType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tax_payer_type");
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tin");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UserRin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("user_rin");
        });

        modelBuilder.Entity<IndividualsApi>(entity =>
        {
            entity.HasKey(e => e.TaxPayerId);

            entity.ToTable("Individuals_API");

            entity.Property(e => e.TaxPayerId)
                .ValueGeneratedNever()
                .HasColumnName("TaxPayerID");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<IndividualsApiInput>(entity =>
        {
            entity.HasKey(e => e.TaxPayerId);

            entity.ToTable("Individuals_API_Input");

            entity.Property(e => e.TaxPayerId)
                .ValueGeneratedNever()
                .HasColumnName("TaxPayerID");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<LegacySubmissionsPaye>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LegacySubmissionsPAYE");

            entity.HasIndex(e => new { e.TpTin, e.TaxYear, e.BusinessRin }, "NonClusteredIndex-20190503-063606");

            entity.Property(e => e.BusinessRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.Lsid).HasColumnName("LSID");
            entity.Property(e => e.Ltg).HasColumnName("LTG");
            entity.Property(e => e.Nhf).HasColumnName("NHF");
            entity.Property(e => e.Nhis).HasColumnName("NHIS");
            entity.Property(e => e.TaxYear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tax_year");
            entity.Property(e => e.TpTin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Tp_TIN");
        });

        modelBuilder.Entity<LocalGovernment>(entity =>
        {
            entity.Property(e => e.active).HasColumnName("active");
            entity.Property(e => e.created_at).HasColumnName("created_at");
            entity.Property(e => e.lga_code).HasColumnName("lga_code");
            entity.Property(e => e.name).HasColumnName("name");
            entity.Property(e => e.updated_at).HasColumnName("updated_at");
        });

        modelBuilder.Entity<LocalGovernmentArea>(entity =>
        {
            entity.HasKey(e => e.LgaId);

            entity.ToTable("Local_Government_Areas");

            entity.Property(e => e.LgaId).HasColumnName("lga_id");
            entity.Property(e => e.Lga)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lga");
            entity.Property(e => e.LgaClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lga_class");
            entity.Property(e => e.LgaCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("lga_create_at");
            entity.Property(e => e.LgaCreateBy).HasColumnName("lga_create_by");
            entity.Property(e => e.LgaStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("lga_status");
        });

        modelBuilder.Entity<LocalGovtPostalCodee>(entity =>
        {
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Postalcode).HasColumnName("postalcode");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<MyView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MyView", "spike");

            entity.Property(e => e.AssessmentItemId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetRin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.MonthlyTax).HasColumnName("monthlyTax");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.TaxMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxYear)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MyView1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MyView_1", "spike");

            entity.Property(e => e.AprilContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AssessmentYear1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Assessment_Year");
            entity.Property(e => e.AugustContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DecemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EmployeRin)
                .IsUnicode(false)
                .HasColumnName("EmployeRIN");
            entity.Property(e => e.EmployeeRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeRIN");
            entity.Property(e => e.EmployerAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.FebruaryContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JanuaryContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JulyContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JuneContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MarchContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MayContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NovemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OctoberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SpetemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nationality");

            entity.Property(e => e.Adjective)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("adjective");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country_code");
            entity.Property(e => e.NationalityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("nationality_id");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.Property(e => e.EventRef)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("event_ref");
            entity.Property(e => e.NotCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("not_create_at");
            entity.Property(e => e.NotCreateBy).HasColumnName("not_create_by");
            entity.Property(e => e.NotificationsDate)
                .HasColumnType("datetime")
                .HasColumnName("notifications_date");
            entity.Property(e => e.NotificationsMethod).HasColumnName("notifications_method");
            entity.Property(e => e.NotificationsRef)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("notifications_ref");
            entity.Property(e => e.NotificationsStatus)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("notifications_status");
            entity.Property(e => e.NotificationsType).HasColumnName("notifications_type");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("tax_payer_rin");
        });

        modelBuilder.Entity<NotificationMethod>(entity =>
        {
            entity.HasKey(e => e.NotemId);

            entity.ToTable("Notification_Method");

            entity.Property(e => e.NotemId).HasColumnName("notem_id");
            entity.Property(e => e.NotemCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("notem_create_at");
            entity.Property(e => e.NotemCreateBy).HasColumnName("notem_create_by");
            entity.Property(e => e.NotificationMethod1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("notification_method");
        });

        modelBuilder.Entity<NotificationType>(entity =>
        {
            entity.ToTable("Notification_Types");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NotificationTypes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("notification_types");
            entity.Property(e => e.NottCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("nott_create_at");
            entity.Property(e => e.NottCreateBy).HasColumnName("nott_create_by");
            entity.Property(e => e.TypeDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("type_description");
        });

        modelBuilder.Entity<PayeInputFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PayeInputFile");

            entity.Property(e => e.AssessmentYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Assessment_Year");
            entity.Property(e => e.AssetRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.EmployeeRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeRIN");
            entity.Property(e => e.EmployeeTin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeTIN");
            entity.Property(e => e.EmployerAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.EndMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LeaveTransportAnnual).HasColumnName("LeaveTransport_Annual");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nhf).HasColumnName("NHF");
            entity.Property(e => e.Nhis).HasColumnName("NHIS");
            entity.Property(e => e.OtherAllowancesAnnual).HasColumnName("OtherAllowances_Annual");
            entity.Property(e => e.StartMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayeOuputFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PayeOuputFile");

            entity.HasIndex(e => e.Status, "Ind_PayeOuputFile");

            entity.HasIndex(e => new { e.EmployerRin, e.EmployeeRin, e.AssessmentYear }, "NonClusteredIndex-20190508-102920");

            entity.Property(e => e.AssessmentYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Assessment_Year");
            entity.Property(e => e.AssetRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Cra).HasColumnName("CRA");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.EmployeeRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeRIN");
            entity.Property(e => e.EmployeeTin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeTIN");
            entity.Property(e => e.EmployerAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.EndMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ValidatedNhf).HasColumnName("ValidatedNHF");
            entity.Property(e => e.ValidatedNhis).HasColumnName("ValidatedNHIS");
        });

        modelBuilder.Entity<PayeRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("PayeRole");

            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayeUserType>(entity =>
        {
            entity.HasKey(e => e.UserTypeId);

            entity.ToTable("PayeUserType");

            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayesubmissionAbhayLive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PAYESUBMISSION_ABHAY_LIVE");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(255)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.EstName)
                .HasMaxLength(255)
                .HasColumnName("est_name");
            entity.Property(e => e.EstTin).HasColumnName("est_tin");
            entity.Property(e => e.MaySubmission).HasColumnName("MAY SUBMISSION");
        });

        modelBuilder.Entity<PaymentFrequency>(entity =>
        {
            entity.HasKey(e => e.PayfId);

            entity.ToTable("Payment_Frequency");

            entity.Property(e => e.PayfId).HasColumnName("payf_id");
            entity.Property(e => e.PayfCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("payf_create_at");
            entity.Property(e => e.PayfCreateBy).HasColumnName("payf_create_by");
            entity.Property(e => e.PayfStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("payf_status");
            entity.Property(e => e.PaymentFrequency1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payment_frequency");
        });

        modelBuilder.Entity<PaymentOption>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("Payment_Options");

            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.PaymentCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("payment_create_at");
            entity.Property(e => e.PaymentCreateBy).HasColumnName("payment_create_by");
            entity.Property(e => e.PaymentOption1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payment_option");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("payment_status");
        });

        modelBuilder.Entity<PreAsessmentTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pre_Asessment_Temp", "spike");

            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TaxMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxYear)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PreAssessment>(entity =>
        {
            entity.HasKey(e => e.AssessId);

            entity.ToTable("Pre_Assessment");

            entity.Property(e => e.AssessId).HasColumnName("assess_id");
            entity.Property(e => e.AssessCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("assess_create_at");
            entity.Property(e => e.AssessCreateBy).HasColumnName("assess_create_by");
            entity.Property(e => e.AssessmentAmount).HasColumnName("assessment_amount");
            entity.Property(e => e.AssessmentDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("assessment_date");
            entity.Property(e => e.AssessmentRef)
                .IsUnicode(false)
                .HasColumnName("assessment_ref");
            entity.Property(e => e.AssessmentRule)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assessment_rule");
            entity.Property(e => e.AssetRin).HasColumnName("asset_rin");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
            entity.Property(e => e.CompanyRin)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.CompanyTin)
                .IsUnicode(false)
                .HasColumnName("company_tin");
            entity.Property(e => e.ProfileRef).HasColumnName("profile_ref");
            entity.Property(e => e.RuleCode).HasColumnName("rule_code");
            entity.Property(e => e.SettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("settlement_date");
            entity.Property(e => e.SettlementDueDate)
                .HasColumnType("datetime")
                .HasColumnName("settlement_due_date");
            entity.Property(e => e.SettlementStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("DUE")
                .HasColumnName("settlement_status");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tax_payer_name");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tax_payer_rin");
            entity.Property(e => e.TaxPayerType).HasColumnName("tax_payer_type");
            entity.Property(e => e.TaxYear).HasColumnName("tax_year");
        });

        modelBuilder.Entity<PreAssessment1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PreAssessment");

            entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AssessmentMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentYear)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
        });

        modelBuilder.Entity<PreAssessmentRdm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PreAssessmentRDM");

            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRdmId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AssessmentRDM_Id");
            entity.Property(e => e.AssessmentRefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assessment_RefNo");
            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxYear)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PreAssessmentRdmBkp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PreAssessmentRDM_BKP2");

            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRdmId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AssessmentRDM_Id");
            entity.Property(e => e.AssessmentRefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assessment_RefNo");
            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxYear)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.Property(e => e.ProfileId).HasColumnName("profile_id");
            entity.Property(e => e.AssetStatus).HasColumnName("asset_status");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
            entity.Property(e => e.Attribute)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attribute");
            entity.Property(e => e.ProfileCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("profile_create_at");
            entity.Property(e => e.ProfileCreateBy).HasColumnName("profile_create_by");
            entity.Property(e => e.ProfileDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("profile_description");
            entity.Property(e => e.ProfileGroup)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("profile_group");
            entity.Property(e => e.ProfileRef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("profile_ref");
            entity.Property(e => e.ProfileSector)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("profile_sector");
            entity.Property(e => e.ProfileStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("profile_status");
            entity.Property(e => e.ProfileSubGroup)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("profile_sub_group");
            entity.Property(e => e.ProfileSubSector)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("profile_sub_sector");
            entity.Property(e => e.SectorElements)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sector_elements");
            entity.Property(e => e.SectorSubElements)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sector_sub_elements");
            entity.Property(e => e.SubAttribute)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sub_attribute");
            entity.Property(e => e.TaxPayerRole).HasColumnName("tax_payer_role");
            entity.Property(e => e.TaxPayerType).HasColumnName("tax_payer_type");
        });

        modelBuilder.Entity<ProfilesApi>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("PK_ProfilesAPI");

            entity.ToTable("Profiles_API");

            entity.Property(e => e.ProfileId)
                .ValueGeneratedNever()
                .HasColumnName("ProfileID");
            entity.Property(e => e.ProfileDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProfileReferenceNo)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Projection>(entity =>
        {
            entity.Property(e => e.annual_projection_id).HasColumnName("annual_projection_id");
            entity.Property(e => e.app_id).HasColumnName("app_id");
            entity.Property(e => e.approval_status).HasColumnName("approval_status");
            entity.Property(e => e.business_id).HasColumnName("business_id");
            entity.Property(e => e.business_name).HasColumnName("business_name");
            entity.Property(e => e.business_primary_id).HasColumnName("business_primary_id");
            entity.Property(e => e.company_name).HasColumnName("company_name");
            entity.Property(e => e.corporate_id).HasColumnName("corporate_id");
            entity.Property(e => e.created_at).HasColumnName("created_at");
            entity.Property(e => e.date_forwarded).HasColumnName("date_forwarded");
            entity.Property(e => e.employees_count).HasColumnName("employees_count");
            entity.Property(e => e.file_projection_status).HasColumnName("file_projection_status");
            entity.Property(e => e.forwarded_to).HasColumnName("forwarded_to");
            entity.Property(e => e.projection_year).HasColumnName("projection_year");
            entity.Property(e => e.status).HasColumnName("status");
            entity.Property(e => e.taxpayer_id).HasColumnName("taxpayer_id");
        });

        modelBuilder.Entity<RecordLink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Record_Links");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LandInformation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("land_information");
            entity.Property(e => e.OccupantsInformation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("occupants_information");
            entity.Property(e => e.TaxPayerInformation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tax_payer_information");
        });

        modelBuilder.Entity<RefNoPopulate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RefNo_Populate");

            entity.Property(e => e.AssessmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Assessmentruleid).HasColumnName("assessmentruleid");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.BusinessAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
        });

        modelBuilder.Entity<RevenueStream>(entity =>
        {
            entity.HasKey(e => e.ReveId);

            entity.ToTable("Revenue_Stream");

            entity.Property(e => e.ReveId).HasColumnName("reve_id");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
            entity.Property(e => e.RevCreateAt)
                .HasColumnType("datetime")
                .HasColumnName("rev_create_at");
            entity.Property(e => e.RevCreateBy).HasColumnName("rev_create_by");
            entity.Property(e => e.RevenueStream1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("revenue_stream");
        });

        modelBuilder.Entity<RevenueSubStream>(entity =>
        {
            entity.HasKey(e => e.RevSsId);

            entity.ToTable("Revenue_Sub_Stream");

            entity.Property(e => e.RevSsId).HasColumnName("rev_ss_id");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
            entity.Property(e => e.RevSsCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("rev_ss_create_at");
            entity.Property(e => e.RevSsCreateBy).HasColumnName("rev_ss_create_by");
            entity.Property(e => e.RevenueStream).HasColumnName("revenue_stream");
            entity.Property(e => e.RevenueSubStream1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("revenue_sub_stream");
        });

        modelBuilder.Entity<RuleEngine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RuleEngine");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RuleDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RuleFormula).IsUnicode(false);
            entity.Property(e => e.RuleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.RuleStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<SalaryBreakup>(entity =>
        {
            entity.HasKey(e => e.SalId);

            entity.ToTable("Salary_Breakup");

            entity.Property(e => e.SalId).HasColumnName("sal_id");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.SalBasic).HasColumnName("sal_basic");
            entity.Property(e => e.SalCalcTax).HasColumnName("sal_calc_tax");
            entity.Property(e => e.SalCalcTaxMonthly).HasColumnName("sal_calc_tax_monthly");
            entity.Property(e => e.SalChIncome).HasColumnName("sal_ch_income");
            entity.Property(e => e.SalCra).HasColumnName("sal_cra");
            entity.Property(e => e.SalCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("sal_create_at");
            entity.Property(e => e.SalCreateBy).HasColumnName("sal_create_by");
            entity.Property(e => e.SalEmployeeId).HasColumnName("sal_employee_id");
            entity.Property(e => e.SalGross).HasColumnName("sal_gross");
            entity.Property(e => e.SalLtg)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("sal_ltg");
            entity.Property(e => e.SalMeal)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("sal_meal");
            entity.Property(e => e.SalNhf).HasColumnName("sal_nhf");
            entity.Property(e => e.SalNhfDeclared).HasColumnName("sal_nhf_declared");
            entity.Property(e => e.SalNhis).HasColumnName("sal_nhis");
            entity.Property(e => e.SalNhisDeclared).HasColumnName("sal_nhis_declared");
            entity.Property(e => e.SalOtherallowances)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("sal_otherallowances");
            entity.Property(e => e.SalPension).HasColumnName("sal_pension");
            entity.Property(e => e.SalPensionDeclared).HasColumnName("sal_pension_declared");
            entity.Property(e => e.SalRent).HasColumnName("sal_rent");
            entity.Property(e => e.SalTaxFreePay).HasColumnName("sal_tax_free_pay");
            entity.Property(e => e.SalTrans).HasColumnName("sal_trans");
            entity.Property(e => e.SalUtility)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("sal_utility");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
        });

        modelBuilder.Entity<SalaryTypeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalaryTypeMaster");

            entity.Property(e => e.SalaryCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SalaryDesc).IsUnicode(false);
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.Property(e => e.assessment_status).HasColumnName("assessment_status");
            entity.Property(e => e.business_id).HasColumnName("business_id");
            entity.Property(e => e.corporate_id).HasColumnName("corporate_id");
            entity.Property(e => e.created_at).HasColumnName("created_at");
            entity.Property(e => e.created_by_app_id).HasColumnName("created_by_app_id");
            entity.Property(e => e.date_forwarded).HasColumnName("date_forwarded");
            entity.Property(e => e.due_date).HasColumnName("due_date");
            entity.Property(e => e.forwarded_to).HasColumnName("forwarded_to");
            entity.Property(e => e.status).HasColumnName("status");
            entity.Property(e => e.updated_at).HasColumnName("updated_at");
            entity.Property(e => e.user_id).HasColumnName("user_id");
        });

        modelBuilder.Entity<ScheduleComment>(entity =>
        {
            entity.ToTable("ScheduleComment");

            entity.Property(e => e.BusinessId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BusinessID");
            entity.Property(e => e.Commenter).HasMaxLength(50);
            entity.Property(e => e.CommenterId).HasColumnName("Commenter_ID");
            entity.Property(e => e.CommenterType)
                .HasMaxLength(50)
                .HasColumnName("Commenter_Type");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CompanyID");
        });

        modelBuilder.Entity<ScheduleRecord>(entity =>
        {
            entity.ToTable("Schedule_Records");

            entity.Property(e => e.Cra).HasColumnName("cra");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.GrossIncome).HasColumnName("gross_income");
            entity.Property(e => e.LifeAssurance).HasColumnName("life_assurance");
            entity.Property(e => e.Nhf).HasColumnName("nhf");
            entity.Property(e => e.Nhis).HasColumnName("nhis");
            entity.Property(e => e.Pension).HasColumnName("pension");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.TotalIncome).HasColumnName("total_income");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<ScheduleStatus>(entity =>
        {
            entity.ToTable("ScheduleStatus");

            entity.Property(e => e.ForwardedToHeadOfStation).HasColumnName("Forwarded_To_Head_Of_Station");
        });

        modelBuilder.Entity<Settlement>(entity =>
        {
            entity.HasKey(e => e.SettleId);

            entity.Property(e => e.SettleId).HasColumnName("settle_ID");
            entity.Property(e => e.AssessmentAmount).HasColumnName("assessment_amount");
            entity.Property(e => e.AssessmentRef)
                .IsUnicode(false)
                .HasColumnName("assessment_ref");
            entity.Property(e => e.SettleCreateBy).HasColumnName("settle_create_by");
            entity.Property(e => e.SettleCreateOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("settle_create_on");
            entity.Property(e => e.SettlementAmount).HasColumnName("settlement_amount");
            entity.Property(e => e.SettlementDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("settlement_date");
            entity.Property(e => e.SettlementMethod).HasColumnName("settlement_method");
            entity.Property(e => e.SettlementNotes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("settlement_notes");
            entity.Property(e => e.SettlementRef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("settlement_ref");
            entity.Property(e => e.SettlementStatus).HasColumnName("settlement_status");
        });

        modelBuilder.Entity<SettlementMethod>(entity =>
        {
            entity.HasKey(e => e.SettId);

            entity.ToTable("Settlement_Method");

            entity.Property(e => e.SettId).HasColumnName("sett_id");
            entity.Property(e => e.SettCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("sett_create_at");
            entity.Property(e => e.SettCreateBy).HasColumnName("sett_create_by");
            entity.Property(e => e.SettlementMethod1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("settlement_method");
        });

        modelBuilder.Entity<SettlementStatus>(entity =>
        {
            entity.HasKey(e => e.SettStId);

            entity.ToTable("Settlement_Status");

            entity.Property(e => e.SettStId)
                .ValueGeneratedNever()
                .HasColumnName("sett_st_id");
            entity.Property(e => e.SettStCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("sett_st_create_at");
            entity.Property(e => e.SettStCreateBy).HasColumnName("sett_st_create_by");
            entity.Property(e => e.SettlementStatus1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("settlement_status");
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("status_description");
        });

        modelBuilder.Entity<StateMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StateMaster");

            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("created_on");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("modified_on");
            entity.Property(e => e.StateCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("state_code");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.StateName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("state_name");
        });

        modelBuilder.Entity<Submission>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AssessmentItems)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRule)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Asset)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionNotes).IsUnicode(false);
            entity.Property(e => e.TaxBaseAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayer)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubmissionsBkpaa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SubmissionsBKPAA", "spike");

            entity.Property(e => e.AssessmentItems)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRule)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Asset)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionNotes).IsUnicode(false);
            entity.Property(e => e.TaxBaseAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayer)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubmissionsDefault>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Submissions_default", "spike");

            entity.Property(e => e.AssessmentItems)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRule)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Asset)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionNotes).IsUnicode(false);
            entity.Property(e => e.TaxBaseAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayer)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TablesApiUpdated>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tables_API_Updated");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TaxOffice>(entity =>
        {
            entity.HasKey(e => e.ToId).HasName("PK_tax_office");

            entity.ToTable("Tax_Offices");

            entity.Property(e => e.ToId).HasColumnName("to_id");
            entity.Property(e => e.TaStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ta_status");
            entity.Property(e => e.TaxOffice1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tax_office");
            entity.Property(e => e.ToCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("to_create_at");
            entity.Property(e => e.ToCreateBy).HasColumnName("to_create_by");
        });

        modelBuilder.Entity<TaxPayerRole>(entity =>
        {
            entity.HasKey(e => e.TptId);

            entity.ToTable("Tax_Payer_Roles");

            entity.Property(e => e.TptId).HasColumnName("tpt_id");
            entity.Property(e => e.AssetType).HasColumnName("asset_type");
            entity.Property(e => e.TaxPayerRole1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tax_payer_role");
            entity.Property(e => e.TaxPayerType).HasColumnName("tax_payer_type");
            entity.Property(e => e.TptCreateAt).HasColumnName("tpt_create_at");
            entity.Property(e => e.TptCreateBy)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("tpt_create_by");
            entity.Property(e => e.TptStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tpt_status");
        });

        modelBuilder.Entity<TaxPayerType>(entity =>
        {
            entity.HasKey(e => e.TptypeId);

            entity.ToTable("Tax_Payer_Types");

            entity.Property(e => e.TptypeId).HasColumnName("tptype_id");
            entity.Property(e => e.TaxPayerType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tax_payer_type");
            entity.Property(e => e.TptypeCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("tptype_create_at");
            entity.Property(e => e.TptypeCreateBy).HasColumnName("tptype_create_by");
            entity.Property(e => e.TptypeStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tptype_status");
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.Property(e => e.TitleId).HasColumnName("title_id");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Title1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.TitleCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("title_create_at");
            entity.Property(e => e.TitleCreateBy).HasColumnName("title_create_by");
            entity.Property(e => e.TitleStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("title_status");
        });

        modelBuilder.Entity<TokenManagement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TokenMan__3213E83FA0C45C2C");

            entity.ToTable("TokenManagement", "spike");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("createdAt");
            entity.Property(e => e.Token)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<Town>(entity =>
        {
            entity.Property(e => e.TownId).HasColumnName("town_id");
            entity.Property(e => e.Lga).HasColumnName("lga");
            entity.Property(e => e.TownCreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("town_create_at");
            entity.Property(e => e.TownCreateBy).HasColumnName("town_create_by");
            entity.Property(e => e.TownStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("town_status");
            entity.Property(e => e.Towns)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("towns");
        });

        modelBuilder.Entity<VwAssessIndSal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_assess_ind_sal");

            entity.Property(e => e.AssessmentDate)
                .HasColumnType("datetime")
                .HasColumnName("assessment_date");
            entity.Property(e => e.CompanyRin)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.IndId).HasColumnName("ind_id");
            entity.Property(e => e.SalBasic).HasColumnName("sal_basic");
            entity.Property(e => e.SalCalcTax).HasColumnName("sal_calc_tax");
            entity.Property(e => e.SalCalcTaxMonthly).HasColumnName("sal_calc_tax_monthly");
            entity.Property(e => e.SalEmployeeId).HasColumnName("sal_employee_id");
            entity.Property(e => e.SalGross).HasColumnName("sal_gross");
            entity.Property(e => e.SalPension).HasColumnName("sal_pension");
            entity.Property(e => e.SalPensionDeclared).HasColumnName("sal_pension_declared");
            entity.Property(e => e.SalRent).HasColumnName("sal_rent");
            entity.Property(e => e.SalTrans).HasColumnName("sal_trans");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
        });

        modelBuilder.Entity<VwAssessIndSalRefund>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_assess_ind_sal_refund");

            entity.Property(e => e.AssessmentDate)
                .HasColumnType("datetime")
                .HasColumnName("assessment_date");
            entity.Property(e => e.CompanyRin)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.IndId).HasColumnName("ind_id");
            entity.Property(e => e.SalBasic).HasColumnName("sal_basic");
            entity.Property(e => e.SalCalcTax).HasColumnName("sal_calc_tax");
            entity.Property(e => e.SalCalcTaxMonthly).HasColumnName("sal_calc_tax_monthly");
            entity.Property(e => e.SalGross).HasColumnName("sal_gross");
            entity.Property(e => e.SalPension).HasColumnName("sal_pension");
            entity.Property(e => e.SalPensionDeclared).HasColumnName("sal_pension_declared");
            entity.Property(e => e.SalRent).HasColumnName("sal_rent");
            entity.Property(e => e.SalTrans).HasColumnName("sal_trans");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
        });

        modelBuilder.Entity<VwAssessmentRule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Assessment_Rules", "spike");

            entity.Property(e => e.AssessmentRuleCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentFrequencyId).HasColumnName("PaymentFrequencyID");
            entity.Property(e => e.PaymentFrequencyName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.PaymentOptionName)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ProfileDescription)
                .HasMaxLength(55)
                .IsUnicode(false);
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.ProfileReferenceNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RuleRunId).HasColumnName("RuleRunID");
            entity.Property(e => e.RuleRunName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TaxMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxYear)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAssessmentSearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_assessment_search");

            entity.Property(e => e.AssessmentAmount).HasColumnName("assessment_amount");
            entity.Property(e => e.AssessmentDate)
                .HasColumnType("datetime")
                .HasColumnName("assessment_date");
            entity.Property(e => e.AssessmentRef)
                .IsUnicode(false)
                .HasColumnName("assessment_ref");
            entity.Property(e => e.AssessmentStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Assessment_status");
            entity.Property(e => e.AssessmentStatus1).HasColumnName("AssessmentStatus");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.CompanyRin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.CompanyTin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("company_tin");
            entity.Property(e => e.SStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_Status");
            entity.Property(e => e.SettlementStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("settlement_status");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tax_payer_name");
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tax_payer_rin");
            entity.Property(e => e.TaxPayerType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tax_payer_type");
            entity.Property(e => e.TaxYear).HasColumnName("tax_year");
            entity.Property(e => e.TptypeStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tptype_status");
        });

        modelBuilder.Entity<VwBusinessCompRelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_business_comp_relation");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.CompanyRin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.CompanyTin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("company_tin");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_address_1");
            entity.Property(e => e.MobileNumber1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mobile_number_1");
        });

        modelBuilder.Entity<VwBusinessDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BusinessDetails");

            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerRinB)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN_b");
        });

        modelBuilder.Entity<VwClearanceCertReq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_clearanceCertReq");

            entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AssessmentChildRef)
                .IsUnicode(false)
                .HasColumnName("assessment_child_ref");
            entity.Property(e => e.AssessmentRef)
                .IsUnicode(false)
                .HasColumnName("assessment_ref");
            entity.Property(e => e.CompanyRin)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.IsPaid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MonthTax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tax_payer_name");
            entity.Property(e => e.YearTax)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCompIndSal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_comp_ind_sal");

            entity.Property(e => e.Address)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.CompanyRin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.CompanyRinOk)
                .IsUnicode(false)
                .HasColumnName("company_rin_ok");
            entity.Property(e => e.CompanyTin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("company_tin");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("date_of_birth");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_address_1");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.IndId).HasColumnName("ind_id");
            entity.Property(e => e.IsValidated)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.MobileNumber1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mobile_number_1");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nationality");
            entity.Property(e => e.NationalityId).HasColumnName("nationality_id");
            entity.Property(e => e.SalBasic).HasColumnName("sal_basic");
            entity.Property(e => e.SalCalcTax).HasColumnName("sal_calc_tax");
            entity.Property(e => e.SalCalcTaxMonthly).HasColumnName("sal_calc_tax_monthly");
            entity.Property(e => e.SalChIncome).HasColumnName("sal_ch_income");
            entity.Property(e => e.SalCreateAt)
                .HasColumnType("datetime")
                .HasColumnName("sal_create_at");
            entity.Property(e => e.SalEmployeeId).HasColumnName("sal_employee_id");
            entity.Property(e => e.SalGross).HasColumnName("sal_gross");
            entity.Property(e => e.SalId).HasColumnName("sal_id");
            entity.Property(e => e.SalNhf).HasColumnName("sal_nhf");
            entity.Property(e => e.SalNhis).HasColumnName("sal_nhis");
            entity.Property(e => e.SalPension).HasColumnName("sal_pension");
            entity.Property(e => e.SalRent).HasColumnName("sal_rent");
            entity.Property(e => e.SalTaxFreePay).HasColumnName("sal_tax_free_pay");
            entity.Property(e => e.SalTrans).HasColumnName("sal_trans");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tin");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UserRin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("user_rin");
        });

        modelBuilder.Entity<VwCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_companies");

            entity.Property(e => e.AccountBalance).HasColumnName("account_balance");
            entity.Property(e => e.Add1Hno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Add1_hno");
            entity.Property(e => e.Add2Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Add2_street");
            entity.Property(e => e.Add3OffstreetTown)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Add3_offstreet_town");
            entity.Property(e => e.AssetType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("asset_type");
            entity.Property(e => e.BusinessCategory).HasColumnName("business_category");
            entity.Property(e => e.BusinessCreateBy).HasColumnName("business_create_by");
            entity.Property(e => e.BusinessCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("business_create_date");
            entity.Property(e => e.BusinessId).HasColumnName("business_id");
            entity.Property(e => e.BusinessLga).HasColumnName("business_lga");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("business_name");
            entity.Property(e => e.BusinessOperations).HasColumnName("business_operations");
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("business_rin");
            entity.Property(e => e.BusinessSector).HasColumnName("business_sector");
            entity.Property(e => e.BusinessStructure).HasColumnName("business_structure");
            entity.Property(e => e.BusinessSubSector).HasColumnName("business_sub_sector");
            entity.Property(e => e.BusinessType).HasColumnName("business_type");
            entity.Property(e => e.CompanyCreateAt)
                .HasColumnType("datetime")
                .HasColumnName("company_create_at");
            entity.Property(e => e.CompanyCreateBy).HasColumnName("company_create_by");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.CompanyRin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.CompanyTin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("company_tin");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact_person");
            entity.Property(e => e.EconomicActivity).HasColumnName("economic_activity");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_address_1");
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_address_2");
            entity.Property(e => e.MobileNumber1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mobile_number_1");
            entity.Property(e => e.MobileNumber2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mobile_number_2");
            entity.Property(e => e.PreferredNotificationMethod).HasColumnName("preferred_notification_method");
            entity.Property(e => e.Profile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("profile");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaxOffice).HasColumnName("tax_office");
            entity.Property(e => e.TaxPayerStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tax_payer_status");
            entity.Property(e => e.TaxPayerType).HasColumnName("tax_payer_type");
            entity.Property(e => e.Town).HasColumnName("town");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<VwCorporatesAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Corporates_Assets");

            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BusinessName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BusinessTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerRinB)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN_b");
        });

        modelBuilder.Entity<VwDistinctIndividual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_distinct_Individuals");

            entity.Property(e => e.ContactAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<VwEmployeeContributionOutputFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_EmployeeContributionOutputFile");

            entity.Property(e => e.AprilContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AssessmentYear1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Assessment_Year");
            entity.Property(e => e.AugustContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DecemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EmployeRin)
                .IsUnicode(false)
                .HasColumnName("EmployeRIN");
            entity.Property(e => e.EmployeeRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeRIN");
            entity.Property(e => e.EmployerAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.FebruaryContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JanuaryContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JulyContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JuneContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MarchContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MayContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NovemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OctoberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SpetemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwEmployerContribution>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Employer_Contribution");

            entity.Property(e => e.Apr).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.AssessmentYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Assessment_Year");
            entity.Property(e => e.Aug).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.Dec).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.EmployeeCount).HasColumnName("employeeCount");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.Feb).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Jan).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Jul).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Jun).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Mar).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.May).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Nov).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Oct).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Sep).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwEmployerContributionOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Employer_Contribution_old");

            entity.Property(e => e.Apr).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.AssessmentYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Assessment_Year");
            entity.Property(e => e.Aug).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Dec).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.Employername)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employername");
            entity.Property(e => e.Feb).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Jan).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Jul).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Jun).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Mar).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.May).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Nov).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Oct).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.Sep).HasColumnType("numeric(38, 2)");
        });

        modelBuilder.Entity<VwGetCollectorOutputFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_getCollectorOutputFIle", "spike");

            entity.Property(e => e.AprilContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AssessmentYear1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Assessment_Year");
            entity.Property(e => e.AugustContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DecemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EmployeRin)
                .IsUnicode(false)
                .HasColumnName("EmployeRIN");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(302)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployeeRIN");
            entity.Property(e => e.EmployerAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.FebruaryContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JanuaryContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JulyContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.JuneContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MarchContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MayContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NovemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OctoberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SpetemberContributions).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwGetDistinctInputFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_getDistinct_input_file", "spike");

            entity.Property(e => e.BusinessName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CompanyRin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CompanyRIN");
            entity.Property(e => e.CompanyTin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CompanyTIN");
            entity.Property(e => e.TaxYear)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwGetPreAssessment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GetPreAssessment", "spike");

            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.MonthlyTax).HasColumnName("monthlyTax");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.TaxMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxYear)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwGetPreAssessment31Jan2020>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_GetPreAssessment_31_JAN_2020", "spike");

            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AssetRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmployerRin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EmployerRIN");
            entity.Property(e => e.MonthlyTax).HasColumnName("monthlyTax");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.TaxMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxYear)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwIndDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ind_details");

            entity.Property(e => e.CompanyRin)
                .IsUnicode(false)
                .HasColumnName("company_rin");
            entity.Property(e => e.CompanyTin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("company_tin");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("date_of_birth");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_address_1");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.IndId).HasColumnName("ind_id");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.MobileNumber1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mobile_number_1");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nationality");
            entity.Property(e => e.SalBasic).HasColumnName("sal_basic");
            entity.Property(e => e.SalChIncome).HasColumnName("sal_ch_income");
            entity.Property(e => e.SalGross).HasColumnName("sal_gross");
            entity.Property(e => e.SalNhfDeclared).HasColumnName("sal_nhf_declared");
            entity.Property(e => e.SalNhisDeclared).HasColumnName("sal_nhis_declared");
            entity.Property(e => e.SalPensionDeclared).HasColumnName("sal_pension_declared");
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tin");
            entity.Property(e => e.UserRin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("user_rin");
        });

        modelBuilder.Entity<WinastAutoEmailDetail>(entity =>
        {
            entity.HasKey(e => e.AutoId);

            entity.ToTable("winast_auto_email_detail");

            entity.Property(e => e.AutoId).HasColumnName("auto_id");
            entity.Property(e => e.AutoCallNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("auto_call_number");
            entity.Property(e => e.AutoEmailActualSendTime)
                .HasColumnType("datetime")
                .HasColumnName("auto_email_actual_send_time");
            entity.Property(e => e.AutoEmailAgentId).HasColumnName("auto_email_agent_id");
            entity.Property(e => e.AutoEmailAttachement)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("auto_email_attachement");
            entity.Property(e => e.AutoEmailBody)
                .IsUnicode(false)
                .HasColumnName("auto_email_body");
            entity.Property(e => e.AutoEmailCancelDate)
                .HasColumnType("datetime")
                .HasColumnName("auto_email_cancel_date");
            entity.Property(e => e.AutoEmailCc1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("auto_email_cc1");
            entity.Property(e => e.AutoEmailCc2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("auto_email_cc2");
            entity.Property(e => e.AutoEmailClient)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("auto_email_client");
            entity.Property(e => e.AutoEmailFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("auto_email_from");
            entity.Property(e => e.AutoEmailId).HasColumnName("auto_email_id");
            entity.Property(e => e.AutoEmailImportance)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("auto_email_importance");
            entity.Property(e => e.AutoEmailSendTime)
                .HasColumnType("datetime")
                .HasColumnName("auto_email_send_time");
            entity.Property(e => e.AutoEmailServiceId).HasColumnName("auto_email_service_id");
            entity.Property(e => e.AutoEmailStatus).HasColumnName("auto_email_status");
            entity.Property(e => e.AutoEmailSubject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("auto_email_subject");
            entity.Property(e => e.AutoEmailTo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("auto_email_to");
            entity.Property(e => e.AutoEmailType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("auto_email_type");
        });

        modelBuilder.Entity<WinastAutoSmsDetail>(entity =>
        {
            entity.HasKey(e => e.AutoId);

            entity.ToTable("winast_auto_sms_detail");

            entity.Property(e => e.AutoId).HasColumnName("auto_id");
            entity.Property(e => e.AutoCallNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("auto_call_number");
            entity.Property(e => e.AutoSmsActualSendTime)
                .HasColumnType("datetime")
                .HasColumnName("auto_sms_actual_send_time");
            entity.Property(e => e.AutoSmsAgentId).HasColumnName("auto_sms_agent_id");
            entity.Property(e => e.AutoSmsBody)
                .IsUnicode(false)
                .HasColumnName("auto_sms_body");
            entity.Property(e => e.AutoSmsClient)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("auto_sms_client");
            entity.Property(e => e.AutoSmsFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("auto_sms_from");
            entity.Property(e => e.AutoSmsId).HasColumnName("auto_sms_id");
            entity.Property(e => e.AutoSmsImportance)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("auto_sms_importance");
            entity.Property(e => e.AutoSmsSendTime)
                .HasColumnType("datetime")
                .HasColumnName("auto_sms_send_time");
            entity.Property(e => e.AutoSmsSentRemarks)
                .IsUnicode(false)
                .HasColumnName("auto_sms_sent_remarks");
            entity.Property(e => e.AutoSmsServiceId).HasColumnName("auto_sms_service_id");
            entity.Property(e => e.AutoSmsStatus).HasColumnName("auto_sms_status");
            entity.Property(e => e.AutoSmsSubject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("auto_sms_subject");
            entity.Property(e => e.AutoSmsTo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("auto_sms_to");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

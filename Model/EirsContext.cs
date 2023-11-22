
namespace SelfPortalAPi.Model;

public partial class EirsContext : DbContext
{
    public EirsContext()
    {
    }

    public EirsContext(DbContextOptions<EirsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressType> AddressTypes { get; set; }

    public virtual DbSet<Agency> Agencies { get; set; }

    public virtual DbSet<AgencyType> AgencyTypes { get; set; }

    public virtual DbSet<AlScreen> AlScreens { get; set; }

    public virtual DbSet<Assessment> Assessments { get; set; }

    public virtual DbSet<AssessmentGroup> AssessmentGroups { get; set; }

    public virtual DbSet<AssessmentItem> AssessmentItems { get; set; }

    public virtual DbSet<AssessmentItemCategory> AssessmentItemCategories { get; set; }

    public virtual DbSet<AssessmentItemSubCategory> AssessmentItemSubCategories { get; set; }

    public virtual DbSet<AssessmentRule> AssessmentRules { get; set; }

    public virtual DbSet<AssessmentSubGroup> AssessmentSubGroups { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<BuildingCompletion> BuildingCompletions { get; set; }

    public virtual DbSet<BuildingOwnership> BuildingOwnerships { get; set; }

    public virtual DbSet<BuildingPurpose> BuildingPurposes { get; set; }

    public virtual DbSet<BuildingType> BuildingTypes { get; set; }

    public virtual DbSet<BuildingUnit> BuildingUnits { get; set; }

    public virtual DbSet<Business> Businesses { get; set; }

    public virtual DbSet<BusinessCategory> BusinessCategories { get; set; }

    public virtual DbSet<BusinessOperation> BusinessOperations { get; set; }

    public virtual DbSet<BusinessSector> BusinessSectors { get; set; }

    public virtual DbSet<BusinessStructure> BusinessStructures { get; set; }

    public virtual DbSet<BusinessSubSector> BusinessSubSectors { get; set; }

    public virtual DbSet<BusinessType> BusinessTypes { get; set; }

    public virtual DbSet<Certificate> Certificates { get; set; }

    public virtual DbSet<CertificateType> CertificateTypes { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<DealerType> DealerTypes { get; set; }

    public virtual DbSet<DiEdoGisMdaServiceItems2021> DiEdoGisMdaServiceItems2021s { get; set; }

    public virtual DbSet<DiEdoGisMdaServiceItems22021> DiEdoGisMdaServiceItems22021s { get; set; }

    public virtual DbSet<DiEdoGisMdaServices2021> DiEdoGisMdaServices2021s { get; set; }

    public virtual DbSet<DiEdoGisMdaServices22021> DiEdoGisMdaServices22021s { get; set; }

    public virtual DbSet<DiMdaService2021> DiMdaService2021s { get; set; }

    public virtual DbSet<DiMdaServiceItems2021> DiMdaServiceItems2021s { get; set; }

    public virtual DbSet<Directorate> Directorates { get; set; }

    public virtual DbSet<EconomicActivity> EconomicActivities { get; set; }

    public virtual DbSet<EedIndividual> EedIndividuals { get; set; }

    public virtual DbSet<Ega> Egas { get; set; }

    public virtual DbSet<ElmahError> ElmahErrors { get; set; }

    public virtual DbSet<EmBank> EmBanks { get; set; }

    public virtual DbSet<EmBankStatement> EmBankStatements { get; set; }

    public virtual DbSet<EmCategory> EmCategories { get; set; }

    public virtual DbSet<EmDataSource> EmDataSources { get; set; }

    public virtual DbSet<EmIgrclassification> EmIgrclassifications { get; set; }

    public virtual DbSet<EmImportLog> EmImportLogs { get; set; }

    public virtual DbSet<EmMapIgrclassificationEntry> EmMapIgrclassificationEntries { get; set; }

    public virtual DbSet<EmPdMainAuthorized> EmPdMainAuthorizeds { get; set; }

    public virtual DbSet<EmPdMainPending> EmPdMainPendings { get; set; }

    public virtual DbSet<EmPdMvaAuthorized> EmPdMvaAuthorizeds { get; set; }

    public virtual DbSet<EmPdMvaPending> EmPdMvaPendings { get; set; }

    public virtual DbSet<EmRevenueHead> EmRevenueHeads { get; set; }

    public virtual DbSet<EpldBusiness> EpldBusinesses { get; set; }

    public virtual DbSet<EpldIndividual> EpldIndividuals { get; set; }

    public virtual DbSet<EsdBusiness> EsdBusinesses { get; set; }

    public virtual DbSet<EsdIndividual> EsdIndividuals { get; set; }

    public virtual DbSet<ExceptionType> ExceptionTypes { get; set; }

    public virtual DbSet<ExternalDataSource> ExternalDataSources { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<GisfileAssessment> GisfileAssessments { get; set; }

    public virtual DbSet<GisfileAssessmentItem> GisfileAssessmentItems { get; set; }

    public virtual DbSet<GisfileAsset> GisfileAssets { get; set; }

    public virtual DbSet<GisfileHolder> GisfileHolders { get; set; }

    public virtual DbSet<GisfileInvoice> GisfileInvoices { get; set; }

    public virtual DbSet<GisfileInvoiceItem> GisfileInvoiceItems { get; set; }

    public virtual DbSet<GisfileParty> GisfileParties { get; set; }

    public virtual DbSet<Gistesting> Gistestings { get; set; }

    public virtual DbSet<Government> Governments { get; set; }

    public virtual DbSet<GovernmentType> GovernmentTypes { get; set; }

    public virtual DbSet<Individual> Individuals { get; set; }

    public virtual DbSet<JtbIndividual> JtbIndividuals { get; set; }

    public virtual DbSet<JtbIndividualOld> JtbIndividualOlds { get; set; }

    public virtual DbSet<JtbNonIndividual> JtbNonIndividuals { get; set; }

    public virtual DbSet<Land> Lands { get; set; }

    public virtual DbSet<LandDevelopment> LandDevelopments { get; set; }

    public virtual DbSet<LandFunction> LandFunctions { get; set; }

    public virtual DbSet<LandOwnership> LandOwnerships { get; set; }

    public virtual DbSet<LandPurpose> LandPurposes { get; set; }

    public virtual DbSet<LandStreetCondition> LandStreetConditions { get; set; }

    public virtual DbSet<LateCharge> LateCharges { get; set; }

    public virtual DbSet<Lga> Lgas { get; set; }

    public virtual DbSet<Lgaclass> Lgaclasses { get; set; }

    public virtual DbSet<MapAssessmentAdjustment> MapAssessmentAdjustments { get; set; }

    public virtual DbSet<MapAssessmentAssessmentItem> MapAssessmentAssessmentItems { get; set; }

    public virtual DbSet<MapAssessmentAssessmentRule> MapAssessmentAssessmentRules { get; set; }

    public virtual DbSet<MapAssessmentLateCharge> MapAssessmentLateCharges { get; set; }

    public virtual DbSet<MapAssessmentRuleAssessmentItem> MapAssessmentRuleAssessmentItems { get; set; }

    public virtual DbSet<MapAssessmentRuleSettlementMethod> MapAssessmentRuleSettlementMethods { get; set; }

    public virtual DbSet<MapBuildingBuildingUnit> MapBuildingBuildingUnits { get; set; }

    public virtual DbSet<MapBuildingLand> MapBuildingLands { get; set; }

    public virtual DbSet<MapBusinessBuilding> MapBusinessBuildings { get; set; }

    public virtual DbSet<MapCertificateCustomField> MapCertificateCustomFields { get; set; }

    public virtual DbSet<MapCertificateGenerate> MapCertificateGenerates { get; set; }

    public virtual DbSet<MapCertificateGenerateField> MapCertificateGenerateFields { get; set; }

    public virtual DbSet<MapCertificateIssue> MapCertificateIssues { get; set; }

    public virtual DbSet<MapCertificateRevoke> MapCertificateRevokes { get; set; }

    public virtual DbSet<MapCertificateSeal> MapCertificateSeals { get; set; }

    public virtual DbSet<MapCertificateSignDigital> MapCertificateSignDigitals { get; set; }

    public virtual DbSet<MapCertificateSignVisible> MapCertificateSignVisibles { get; set; }

    public virtual DbSet<MapCertificateStage> MapCertificateStages { get; set; }

    public virtual DbSet<MapCertificateTypeField> MapCertificateTypeFields { get; set; }

    public virtual DbSet<MapCertificateTypeItem> MapCertificateTypeItems { get; set; }

    public virtual DbSet<MapCertificateValidate> MapCertificateValidates { get; set; }

    public virtual DbSet<MapCompanyAddressInformation> MapCompanyAddressInformations { get; set; }

    public virtual DbSet<MapDirectoratesRevenueStream> MapDirectoratesRevenueStreams { get; set; }

    public virtual DbSet<MapGovernmentAddressInformation> MapGovernmentAddressInformations { get; set; }

    public virtual DbSet<MapIndividualAddressInformation> MapIndividualAddressInformations { get; set; }

    public virtual DbSet<MapMdaserviceMdaserviceItem> MapMdaserviceMdaserviceItems { get; set; }

    public virtual DbSet<MapMdaserviceSettlementMethod> MapMdaserviceSettlementMethods { get; set; }

    public virtual DbSet<MapPaymentAccountOperation> MapPaymentAccountOperations { get; set; }

    public virtual DbSet<MapServiceBillAdjustment> MapServiceBillAdjustments { get; set; }

    public virtual DbSet<MapServiceBillLateCharge> MapServiceBillLateCharges { get; set; }

    public virtual DbSet<MapServiceBillMdaservice> MapServiceBillMdaservices { get; set; }

    public virtual DbSet<MapServiceBillMdaserviceItem> MapServiceBillMdaserviceItems { get; set; }

    public virtual DbSet<MapSettlementSettlementItem> MapSettlementSettlementItems { get; set; }

    public virtual DbSet<MapSpecialAddressInformation> MapSpecialAddressInformations { get; set; }

    public virtual DbSet<MapTaxOfficeTarget> MapTaxOfficeTargets { get; set; }

    public virtual DbSet<MapTaxOfficerTarget> MapTaxOfficerTargets { get; set; }

    public virtual DbSet<MapTaxPayerAsset> MapTaxPayerAssets { get; set; }

    public virtual DbSet<MapTaxPayerAssetProfile> MapTaxPayerAssetProfiles { get; set; }

    public virtual DbSet<MapTaxPayerAssetProfilePt> MapTaxPayerAssetProfilePts { get; set; }

    public virtual DbSet<MapTaxPayerDocument> MapTaxPayerDocuments { get; set; }

    public virtual DbSet<MapTaxPayerMessage> MapTaxPayerMessages { get; set; }

    public virtual DbSet<MapTaxPayerMessageDocument> MapTaxPayerMessageDocuments { get; set; }

    public virtual DbSet<MapTaxPayerReview> MapTaxPayerReviews { get; set; }

    public virtual DbSet<MapTccrequestGenerate> MapTccrequestGenerates { get; set; }

    public virtual DbSet<MapTccrequestGenerateField> MapTccrequestGenerateFields { get; set; }

    public virtual DbSet<MapTccrequestGenerateTccdetail> MapTccrequestGenerateTccdetails { get; set; }

    public virtual DbSet<MapTccrequestIncomeStream> MapTccrequestIncomeStreams { get; set; }

    public virtual DbSet<MapTccrequestIssue> MapTccrequestIssues { get; set; }

    public virtual DbSet<MapTccrequestNote> MapTccrequestNotes { get; set; }

    public virtual DbSet<MapTccrequestNotesDocument> MapTccrequestNotesDocuments { get; set; }

    public virtual DbSet<MapTccrequestPrepareTccdraft> MapTccrequestPrepareTccdrafts { get; set; }

    public virtual DbSet<MapTccrequestRevoke> MapTccrequestRevokes { get; set; }

    public virtual DbSet<MapTccrequestSeal> MapTccrequestSeals { get; set; }

    public virtual DbSet<MapTccrequestSignDigital> MapTccrequestSignDigitals { get; set; }

    public virtual DbSet<MapTccrequestSignVisible> MapTccrequestSignVisibles { get; set; }

    public virtual DbSet<MapTccrequestStage> MapTccrequestStages { get; set; }

    public virtual DbSet<MapTccrequestValidate> MapTccrequestValidates { get; set; }

    public virtual DbSet<MapTccrequestValidateTaxPayerIncome> MapTccrequestValidateTaxPayerIncomes { get; set; }

    public virtual DbSet<MapTccrequestValidateTaxPayerInformation> MapTccrequestValidateTaxPayerInformations { get; set; }

    public virtual DbSet<MapTreasuryReceiptSettlement> MapTreasuryReceiptSettlements { get; set; }

    public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }

    public virtual DbSet<MdaService> MdaServices { get; set; }

    public virtual DbSet<MdaServiceItem> MdaServiceItems { get; set; }

    public virtual DbSet<MstCertificateStage> MstCertificateStages { get; set; }

    public virtual DbSet<MstCertificateStatus> MstCertificateStatuses { get; set; }

    public virtual DbSet<MstComputation> MstComputations { get; set; }

    public virtual DbSet<MstEmailStack> MstEmailStacks { get; set; }

    public virtual DbSet<MstFieldType> MstFieldTypes { get; set; }

    public virtual DbSet<MstLastNumber> MstLastNumbers { get; set; }

    public virtual DbSet<MstPaymentStatus> MstPaymentStatuses { get; set; }

    public virtual DbSet<MstRegisterationStatus> MstRegisterationStatuses { get; set; }

    public virtual DbSet<MstRuleRun> MstRuleRuns { get; set; }

    public virtual DbSet<MstTccrequestStatus> MstTccrequestStatuses { get; set; }

    public virtual DbSet<MstTccstage> MstTccstages { get; set; }

    public virtual DbSet<MstTccstatus> MstTccstatuses { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<NewErastccHolder> NewErastccHolders { get; set; }

    public virtual DbSet<NewId> NewIds { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationMethod> NotificationMethods { get; set; }

    public virtual DbSet<NotificationMode> NotificationModes { get; set; }

    public virtual DbSet<NotificationType> NotificationTypes { get; set; }

    public virtual DbSet<OperationType> OperationTypes { get; set; }

    public virtual DbSet<PayDirectNotification> PayDirectNotifications { get; set; }

    public virtual DbSet<PayeTccHolder> PayeTccHolders { get; set; }

    public virtual DbSet<PaymentAccount> PaymentAccounts { get; set; }

    public virtual DbSet<PaymentFrequency> PaymentFrequencies { get; set; }

    public virtual DbSet<PaymentOption> PaymentOptions { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProfileAttribute> ProfileAttributes { get; set; }

    public virtual DbSet<ProfileGroup> ProfileGroups { get; set; }

    public virtual DbSet<ProfileSector> ProfileSectors { get; set; }

    public virtual DbSet<ProfileSectorElement> ProfileSectorElements { get; set; }

    public virtual DbSet<ProfileSectorSubElement> ProfileSectorSubElements { get; set; }

    public virtual DbSet<ProfileSubAttribute> ProfileSubAttributes { get; set; }

    public virtual DbSet<ProfileSubGroup> ProfileSubGroups { get; set; }

    public virtual DbSet<ProfileSubSector> ProfileSubSectors { get; set; }

    public virtual DbSet<ProfileTaxPayerRole> ProfileTaxPayerRoles { get; set; }

    public virtual DbSet<ProfileTaxPayerType> ProfileTaxPayerTypes { get; set; }

    public virtual DbSet<ProfileType> ProfileTypes { get; set; }

    public virtual DbSet<ProfilesBkp> ProfilesBkps { get; set; }

    public virtual DbSet<ReceiptStatus> ReceiptStatuses { get; set; }

    public virtual DbSet<RevenueStream> RevenueStreams { get; set; }

    public virtual DbSet<RevenueSubStream> RevenueSubStreams { get; set; }

    public virtual DbSet<ReviewStatus> ReviewStatuses { get; set; }

    public virtual DbSet<RinCheck> RinChecks { get; set; }

    public virtual DbSet<ScratchCardDealer> ScratchCardDealers { get; set; }

    public virtual DbSet<ScratchCardPrinter> ScratchCardPrinters { get; set; }

    public virtual DbSet<ScratchCardPurchaseRequest> ScratchCardPurchaseRequests { get; set; }

    public virtual DbSet<ServiceBill> ServiceBills { get; set; }

    public virtual DbSet<Settlement> Settlements { get; set; }

    public virtual DbSet<SettlementMethod> SettlementMethods { get; set; }

    public virtual DbSet<SettlementStatus> SettlementStatuses { get; set; }

    public virtual DbSet<SftpDataSubmission> SftpDataSubmissions { get; set; }

    public virtual DbSet<SftpDataSubmissionType> SftpDataSubmissionTypes { get; set; }

    public virtual DbSet<SftpDataSubmitter> SftpDataSubmitters { get; set; }

    public virtual DbSet<SftpMapDataSubmitterDataSubmissionType> SftpMapDataSubmitterDataSubmissionTypes { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Special> Specials { get; set; }

    public virtual DbSet<SystemRole> SystemRoles { get; set; }

    public virtual DbSet<SystemUser> SystemUsers { get; set; }

    public virtual DbSet<TaxClearanceCertificate> TaxClearanceCertificates { get; set; }

    public virtual DbSet<TaxCredit> TaxCredits { get; set; }

    public virtual DbSet<TaxOffice> TaxOffices { get; set; }

    public virtual DbSet<TaxOffice1> TaxOffices1 { get; set; }

    public virtual DbSet<TaxPayerPayment> TaxPayerPayments { get; set; }

    public virtual DbSet<TaxPayerRole> TaxPayerRoles { get; set; }

    public virtual DbSet<TaxPayerType> TaxPayerTypes { get; set; }

    public virtual DbSet<TccRefHolder> TccRefHolders { get; set; }

    public virtual DbSet<TccRequest> TccRequests { get; set; }

    public virtual DbSet<Tccdetail> Tccdetails { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    public virtual DbSet<TreasuryReceipt> TreasuryReceipts { get; set; }

    public virtual DbSet<UnitFunction> UnitFunctions { get; set; }

    public virtual DbSet<UnitOccupancy> UnitOccupancies { get; set; }

    public virtual DbSet<UnitPurpose> UnitPurposes { get; set; }

    public virtual DbSet<Upload> Uploads { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VehicleFunction> VehicleFunctions { get; set; }

    public virtual DbSet<VehicleInsurance> VehicleInsurances { get; set; }

    public virtual DbSet<VehicleLicense> VehicleLicenses { get; set; }

    public virtual DbSet<VehicleOwnership> VehicleOwnerships { get; set; }

    public virtual DbSet<VehiclePurpose> VehiclePurposes { get; set; }

    public virtual DbSet<VehicleSubType> VehicleSubTypes { get; set; }

    public virtual DbSet<VehicleType> VehicleTypes { get; set; }

    public virtual DbSet<VwAssessmentBill> VwAssessmentBills { get; set; }

    public virtual DbSet<VwAssessmentRule> VwAssessmentRules { get; set; }

    public virtual DbSet<VwBillForPoAsettlement> VwBillForPoAsettlements { get; set; }

    public virtual DbSet<VwBuilding> VwBuildings { get; set; }

    public virtual DbSet<VwBusiness> VwBusinesses { get; set; }

    public virtual DbSet<VwCertificateList> VwCertificateLists { get; set; }

    public virtual DbSet<VwCompany> VwCompanies { get; set; }

    public virtual DbSet<VwEmBankStatement> VwEmBankStatements { get; set; }

    public virtual DbSet<VwEmPdMainAuthorized> VwEmPdMainAuthorizeds { get; set; }

    public virtual DbSet<VwEmPdMainPending> VwEmPdMainPendings { get; set; }

    public virtual DbSet<VwEmPdMvaAuthorized> VwEmPdMvaAuthorizeds { get; set; }

    public virtual DbSet<VwEmPdMvaPending> VwEmPdMvaPendings { get; set; }

    public virtual DbSet<VwGovernment> VwGovernments { get; set; }

    public virtual DbSet<VwIndividual> VwIndividuals { get; set; }

    public virtual DbSet<VwLand> VwLands { get; set; }

    public virtual DbSet<VwMdaservice> VwMdaservices { get; set; }

    public virtual DbSet<VwNotification> VwNotifications { get; set; }

    public virtual DbSet<VwPaymentAccount> VwPaymentAccounts { get; set; }

    public virtual DbSet<VwPaymentAccountOperation> VwPaymentAccountOperations { get; set; }

    public virtual DbSet<VwProfilePayePcMe> VwProfilePayePcMes { get; set; }

    public virtual DbSet<VwProfilePayePcMeAsset> VwProfilePayePcMeAssets { get; set; }

    public virtual DbSet<VwProfilePayePcMeTaxPayer> VwProfilePayePcMeTaxPayers { get; set; }

    public virtual DbSet<VwServiceBillNew> VwServiceBillNews { get; set; }

    public virtual DbSet<VwSpecial> VwSpecials { get; set; }

    public virtual DbSet<VwTccrequestList> VwTccrequestLists { get; set; }

    public virtual DbSet<VwVehicle> VwVehicles { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<ZoneLga> ZoneLgas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=92.205.57.77;Initial Catalog=EIRS;user id=Admin;password=K5?wh7l4##;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressType>(entity =>
        {
            entity.ToTable("Address_Types");

            entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");
            entity.Property(e => e.AddressTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Agency>(entity =>
        {
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.AgencyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AgencyTypeId).HasColumnName("AgencyTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AgencyType).WithMany(p => p.Agencies)
                .HasForeignKey(d => d.AgencyTypeId)
                .HasConstraintName("FK_Agencies_Agency_Types");
        });

        modelBuilder.Entity<AgencyType>(entity =>
        {
            entity.ToTable("Agency_Types");

            entity.Property(e => e.AgencyTypeId).HasColumnName("AgencyTypeID");
            entity.Property(e => e.AgencyTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AlScreen>(entity =>
        {
            entity.HasKey(e => e.Aslid);

            entity.ToTable("AL_Screen");

            entity.Property(e => e.Aslid)
                .ValueGeneratedNever()
                .HasColumnName("ASLID");
            entity.Property(e => e.Aslname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ASLName");
        });

        modelBuilder.Entity<Assessment>(entity =>
        {
            entity.ToTable("Assessment", tb => tb.HasTrigger("TRG_GenerateAssessmentCode"));

            entity.HasIndex(e => e.TaxPayerTypeId, "IDX_ASS_TPTID");

            entity.HasIndex(e => new { e.Active, e.AssessmentDate }, "IDX_AST_IA_IAD");

            entity.HasIndex(e => new { e.SettlementDueDate, e.SettlementStatusId }, "IDX_AST_SDD_SSID");

            entity.HasIndex(e => e.SettlementStatusId, "IDX_AST_SSID");

            entity.HasIndex(e => new { e.SettlementStatusId, e.AssessmentDate }, "IDX_AST_SSID_AD");

            entity.HasIndex(e => new { e.TaxPayerTypeId, e.SettlementDueDate, e.SettlementStatusId }, "IDX_AST_TPTID_SDD_SSID");

            entity.HasIndex(e => new { e.TaxPayerTypeId, e.TaxPayerId }, "IDX_AST_TPTID_TID");

            entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");
            entity.Property(e => e.AssessmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentDate).HasColumnType("datetime");
            entity.Property(e => e.AssessmentNotes)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BillPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementDueDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementStatusId).HasColumnName("SettlementStatusID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
        });

        modelBuilder.Entity<AssessmentGroup>(entity =>
        {
            entity.ToTable("Assessment_Group");

            entity.Property(e => e.AssessmentGroupId).HasColumnName("AssessmentGroupID");
            entity.Property(e => e.AssessmentGroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AssetType).WithMany(p => p.AssessmentGroups)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_Assessment_Group_Asset_Types");
        });

        modelBuilder.Entity<AssessmentItem>(entity =>
        {
            entity.ToTable("Assessment_Items", tb => tb.HasTrigger("TRG_GenerateAssessmentItemRefNo"));

            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.AssessmentGroupId).HasColumnName("AssessmentGroupID");
            entity.Property(e => e.AssessmentItemCategoryId).HasColumnName("AssessmentItemCategoryID");
            entity.Property(e => e.AssessmentItemName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentItemReferenceNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentItemSubCategoryId).HasColumnName("AssessmentItemSubCategoryID");
            entity.Property(e => e.AssessmentSubGroupId).HasColumnName("AssessmentSubGroupID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.ComputationId).HasColumnName("ComputationID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.RevenueSubStreamId).HasColumnName("RevenueSubStreamID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxBaseAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Agency).WithMany(p => p.AssessmentItems)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_Assessment_Items_Agencies");

            entity.HasOne(d => d.AssessmentGroup).WithMany(p => p.AssessmentItems)
                .HasForeignKey(d => d.AssessmentGroupId)
                .HasConstraintName("FK_Assessment_Items_Assessment_Group");

            entity.HasOne(d => d.AssessmentItemCategory).WithMany(p => p.AssessmentItems)
                .HasForeignKey(d => d.AssessmentItemCategoryId)
                .HasConstraintName("FK_Assessment_Items_Assessment_Item_Category");

            entity.HasOne(d => d.AssessmentItemSubCategory).WithMany(p => p.AssessmentItems)
                .HasForeignKey(d => d.AssessmentItemSubCategoryId)
                .HasConstraintName("FK_Assessment_Items_Assessment_Item_SubCategory");

            entity.HasOne(d => d.AssessmentSubGroup).WithMany(p => p.AssessmentItems)
                .HasForeignKey(d => d.AssessmentSubGroupId)
                .HasConstraintName("FK_Assessment_Items_Assessment_SubGroup");

            entity.HasOne(d => d.AssetType).WithMany(p => p.AssessmentItems)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_Assessment_Items_Asset_Types");

            entity.HasOne(d => d.Computation).WithMany(p => p.AssessmentItems)
                .HasForeignKey(d => d.ComputationId)
                .HasConstraintName("FK_Assessment_Items_MST_Computation");

            entity.HasOne(d => d.RevenueStream).WithMany(p => p.AssessmentItems)
                .HasForeignKey(d => d.RevenueStreamId)
                .HasConstraintName("FK_Assessment_Items_Revenue_Stream");

            entity.HasOne(d => d.RevenueSubStream).WithMany(p => p.AssessmentItems)
                .HasForeignKey(d => d.RevenueSubStreamId)
                .HasConstraintName("FK_Assessment_Items_Revenue_SubStream");
        });

        modelBuilder.Entity<AssessmentItemCategory>(entity =>
        {
            entity.ToTable("Assessment_Item_Category");

            entity.Property(e => e.AssessmentItemCategoryId).HasColumnName("AssessmentItemCategoryID");
            entity.Property(e => e.AssessmentItemCategoryName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssessmentItemSubCategory>(entity =>
        {
            entity.ToTable("Assessment_Item_SubCategory");

            entity.Property(e => e.AssessmentItemSubCategoryId).HasColumnName("AssessmentItemSubCategoryID");
            entity.Property(e => e.AssessmentItemCategoryId).HasColumnName("AssessmentItemCategoryID");
            entity.Property(e => e.AssessmentItemSubCategoryName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AssessmentItemCategory).WithMany(p => p.AssessmentItemSubCategories)
                .HasForeignKey(d => d.AssessmentItemCategoryId)
                .HasConstraintName("FK_Assessment_Item_SubCategory_Assessment_Item_Category");
        });

        modelBuilder.Entity<AssessmentRule>(entity =>
        {
            entity.ToTable("Assessment_Rules", tb => tb.HasTrigger("TRG_GenerateAssessmentRuleCode"));

            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentRuleCode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentFrequencyId).HasColumnName("PaymentFrequencyID");
            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.RuleRunId).HasColumnName("RuleRunID");

            entity.HasOne(d => d.PaymentFrequency).WithMany(p => p.AssessmentRules)
                .HasForeignKey(d => d.PaymentFrequencyId)
                .HasConstraintName("FK_Assessment_Rules_Payment_Frequency");

            entity.HasOne(d => d.PaymentOption).WithMany(p => p.AssessmentRules)
                .HasForeignKey(d => d.PaymentOptionId)
                .HasConstraintName("FK_Assessment_Rules_Payment_Options");

            entity.HasOne(d => d.Profile).WithMany(p => p.AssessmentRules)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_Assessment_Rules_Profiles");

            entity.HasOne(d => d.RuleRun).WithMany(p => p.AssessmentRules)
                .HasForeignKey(d => d.RuleRunId)
                .HasConstraintName("FK_Assessment_Rules_MST_RuleRun");
        });

        modelBuilder.Entity<AssessmentSubGroup>(entity =>
        {
            entity.ToTable("Assessment_SubGroup");

            entity.Property(e => e.AssessmentSubGroupId).HasColumnName("AssessmentSubGroupID");
            entity.Property(e => e.AssessmentGroupId).HasColumnName("AssessmentGroupID");
            entity.Property(e => e.AssessmentSubGroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AssessmentGroup).WithMany(p => p.AssessmentSubGroups)
                .HasForeignKey(d => d.AssessmentGroupId)
                .HasConstraintName("FK_Assessment_SubGroup_Assessment_Group");
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.ToTable("Asset_Types");

            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.Alid);

            entity.ToTable("Audit_Log");

            entity.Property(e => e.Alid).HasColumnName("ALID");
            entity.Property(e => e.Aslid).HasColumnName("ASLID");
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LogDate).HasColumnType("datetime");
            entity.Property(e => e.StaffId).HasColumnName("StaffID");

            entity.HasOne(d => d.Asl).WithMany(p => p.AuditLogs)
                .HasForeignKey(d => d.Aslid)
                .HasConstraintName("FK_Audit_Log_AL_Screen");
        });

        modelBuilder.Entity<Building>(entity =>
        {
            entity.ToTable("Building", tb => tb.HasTrigger("TRG_GenerateBuildingRIN_BuildingTagNumber"));

            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.BuildingCompletionId).HasColumnName("BuildingCompletionID");
            entity.Property(e => e.BuildingName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BuildingNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BuildingOwnershipId).HasColumnName("BuildingOwnershipID");
            entity.Property(e => e.BuildingPurposeId).HasColumnName("BuildingPurposeID");
            entity.Property(e => e.BuildingRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BuildingRIN");
            entity.Property(e => e.BuildingSizeLength)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BuildingSize_Length");
            entity.Property(e => e.BuildingSizeWidth)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BuildingSize_Width");
            entity.Property(e => e.BuildingTagNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BuildingTypeId).HasColumnName("BuildingTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.Latitude)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.Longitude)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OffStreetName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StreetName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TownId).HasColumnName("TownID");
            entity.Property(e => e.WardId).HasColumnName("WardID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_Building_Asset_Types");

            entity.HasOne(d => d.BuildingCompletion).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.BuildingCompletionId)
                .HasConstraintName("FK_Building_Building_Completion");

            entity.HasOne(d => d.BuildingOwnership).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.BuildingOwnershipId)
                .HasConstraintName("FK_Building_Building_Ownership");

            entity.HasOne(d => d.BuildingPurpose).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.BuildingPurposeId)
                .HasConstraintName("FK_Building_Building_Purpose");

            entity.HasOne(d => d.BuildingType).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.BuildingTypeId)
                .HasConstraintName("FK_Building_Building_Types");

            entity.HasOne(d => d.Lga).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.Lgaid)
                .HasConstraintName("FK_Building_LGA");

            entity.HasOne(d => d.Town).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.TownId)
                .HasConstraintName("FK_Building_Town");

            entity.HasOne(d => d.Ward).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.WardId)
                .HasConstraintName("FK_Building_Ward");
        });

        modelBuilder.Entity<BuildingCompletion>(entity =>
        {
            entity.ToTable("Building_Completion");

            entity.Property(e => e.BuildingCompletionId).HasColumnName("BuildingCompletionID");
            entity.Property(e => e.BuildingCompletionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BuildingOwnership>(entity =>
        {
            entity.ToTable("Building_Ownership");

            entity.Property(e => e.BuildingOwnershipId).HasColumnName("BuildingOwnershipID");
            entity.Property(e => e.BuildingOwnershipName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BuildingPurpose>(entity =>
        {
            entity.ToTable("Building_Purpose");

            entity.Property(e => e.BuildingPurposeId).HasColumnName("BuildingPurposeID");
            entity.Property(e => e.BuildingPurposeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BuildingType>(entity =>
        {
            entity.ToTable("Building_Types");

            entity.Property(e => e.BuildingTypeId).HasColumnName("BuildingTypeID");
            entity.Property(e => e.BuildingTypeName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BuildingUnit>(entity =>
        {
            entity.ToTable("Building_Unit");

            entity.Property(e => e.BuildingUnitId).HasColumnName("BuildingUnitID");
            entity.Property(e => e.BuildingUnitRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BuildingUnitRIN");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.UnitFunctionId).HasColumnName("UnitFunctionID");
            entity.Property(e => e.UnitNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UnitOccupancyId).HasColumnName("UnitOccupancyID");
            entity.Property(e => e.UnitPurposeId).HasColumnName("UnitPurposeID");

            entity.HasOne(d => d.Size).WithMany(p => p.BuildingUnits)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK_Building_Unit_Sizes");

            entity.HasOne(d => d.UnitFunction).WithMany(p => p.BuildingUnits)
                .HasForeignKey(d => d.UnitFunctionId)
                .HasConstraintName("FK_Building_Unit_Unit_Function");

            entity.HasOne(d => d.UnitOccupancy).WithMany(p => p.BuildingUnits)
                .HasForeignKey(d => d.UnitOccupancyId)
                .HasConstraintName("FK_Building_Unit_Unit_Occupancy");

            entity.HasOne(d => d.UnitPurpose).WithMany(p => p.BuildingUnits)
                .HasForeignKey(d => d.UnitPurposeId)
                .HasConstraintName("FK_Building_Unit_Unit_Purpose");
        });

        modelBuilder.Entity<Business>(entity =>
        {
            entity.ToTable("Business", tb => tb.HasTrigger("TRG_GenerateBusinessRIN"));

            entity.HasIndex(e => e.AssetTypeId, "IDX_BA");

            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.BusinessAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessCategoryId).HasColumnName("BusinessCategoryID");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BusinessNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessOperationId).HasColumnName("BusinessOperationID");
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.BusinessSectorId).HasColumnName("BusinessSectorID");
            entity.Property(e => e.BusinessStructureId).HasColumnName("BusinessStructureID");
            entity.Property(e => e.BusinessSubSectorId).HasColumnName("BusinessSubSectorID");
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.ContactName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_Business_Asset_Types");

            entity.HasOne(d => d.BusinessCategory).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.BusinessCategoryId)
                .HasConstraintName("FK_Business_Business_Category");

            entity.HasOne(d => d.BusinessOperation).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.BusinessOperationId)
                .HasConstraintName("FK_Business_Business_Operation");

            entity.HasOne(d => d.BusinessSector).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.BusinessSectorId)
                .HasConstraintName("FK_Business_Business_Sector");

            entity.HasOne(d => d.BusinessStructure).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.BusinessStructureId)
                .HasConstraintName("FK_Business_Business_Structure");

            entity.HasOne(d => d.BusinessSubSector).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.BusinessSubSectorId)
                .HasConstraintName("FK_Business_Business_SubSector");

            entity.HasOne(d => d.BusinessType).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.BusinessTypeId)
                .HasConstraintName("FK_Business_Business_Types");

            entity.HasOne(d => d.Lga).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.Lgaid)
                .HasConstraintName("FK_Business_LGA");

            entity.HasOne(d => d.Size).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK_Business_Sizes");
        });

        modelBuilder.Entity<BusinessCategory>(entity =>
        {
            entity.ToTable("Business_Category");

            entity.Property(e => e.BusinessCategoryId).HasColumnName("BusinessCategoryID");
            entity.Property(e => e.BusinessCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BusinessType).WithMany(p => p.BusinessCategories)
                .HasForeignKey(d => d.BusinessTypeId)
                .HasConstraintName("FK_Business_Category_Business_Types");
        });

        modelBuilder.Entity<BusinessOperation>(entity =>
        {
            entity.ToTable("Business_Operation");

            entity.Property(e => e.BusinessOperationId).HasColumnName("BusinessOperationID");
            entity.Property(e => e.BusinessOperationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BusinessType).WithMany(p => p.BusinessOperations)
                .HasForeignKey(d => d.BusinessTypeId)
                .HasConstraintName("FK_Business_Operation_Business_Types");
        });

        modelBuilder.Entity<BusinessSector>(entity =>
        {
            entity.ToTable("Business_Sector");

            entity.Property(e => e.BusinessSectorId).HasColumnName("BusinessSectorID");
            entity.Property(e => e.BusinessCategoryId).HasColumnName("BusinessCategoryID");
            entity.Property(e => e.BusinessSectorName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BusinessCategory).WithMany(p => p.BusinessSectors)
                .HasForeignKey(d => d.BusinessCategoryId)
                .HasConstraintName("FK_Business_Sector_Business_Category");

            entity.HasOne(d => d.BusinessType).WithMany(p => p.BusinessSectors)
                .HasForeignKey(d => d.BusinessTypeId)
                .HasConstraintName("FK_Business_Sector_Business_Types");
        });

        modelBuilder.Entity<BusinessStructure>(entity =>
        {
            entity.ToTable("Business_Structure");

            entity.Property(e => e.BusinessStructureId).HasColumnName("BusinessStructureID");
            entity.Property(e => e.BusinessStructureName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BusinessType).WithMany(p => p.BusinessStructures)
                .HasForeignKey(d => d.BusinessTypeId)
                .HasConstraintName("FK_Business_Structure_Business_Types");
        });

        modelBuilder.Entity<BusinessSubSector>(entity =>
        {
            entity.ToTable("Business_SubSector");

            entity.Property(e => e.BusinessSubSectorId).HasColumnName("BusinessSubSectorID");
            entity.Property(e => e.BusinessSectorId).HasColumnName("BusinessSectorID");
            entity.Property(e => e.BusinessSubSectorName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BusinessSector).WithMany(p => p.BusinessSubSectors)
                .HasForeignKey(d => d.BusinessSectorId)
                .HasConstraintName("FK_Business_SubSector_Business_Sector");
        });

        modelBuilder.Entity<BusinessType>(entity =>
        {
            entity.ToTable("Business_Types");

            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.BusinessTypeName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Certificate>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TRG_GenerateCertificateNumber"));

            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CertificateDate).HasColumnType("datetime");
            entity.Property(e => e.CertificateNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CertificatePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CertificateTypeId).HasColumnName("CertificateTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayTypeId).HasColumnName("DisplayTypeID");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.GeneratedPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.OtherInformation).IsUnicode(false);
            entity.Property(e => e.PdftemplateId).HasColumnName("PDFTemplateID");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.QrcodeId).HasColumnName("QRCodeID");
            entity.Property(e => e.QrimagePath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("QRImagePath");
            entity.Property(e => e.SealedPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SedeDocumentId).HasColumnName("SEDE_DocumentID");
            entity.Property(e => e.SedeOrderId).HasColumnName("SEDE_OrderID");
            entity.Property(e => e.SignedDigitalPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SignedVisiblePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SignerId).HasColumnName("SignerID");
            entity.Property(e => e.SignerRoleId).HasColumnName("SignerRoleID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.ValidatedPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.VisibleSignStatusId).HasColumnName("VisibleSignStatusID");

            entity.HasOne(d => d.CertificateType).WithMany(p => p.Certificates)
                .HasForeignKey(d => d.CertificateTypeId)
                .HasConstraintName("FK_Certificates_Certificate_Types");
        });

        modelBuilder.Entity<CertificateType>(entity =>
        {
            entity.ToTable("Certificate_Types");

            entity.Property(e => e.CertificateTypeId).HasColumnName("CertificateTypeID");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.CertificateTemplatePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CertificateTypeName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Cnprefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNPrefix");
            entity.Property(e => e.CnserialNumber).HasColumnName("CNSerialNumber");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessingTypeId).HasColumnName("ProcessingTypeID");
            entity.Property(e => e.SedePdftemplateId).HasColumnName("SEDE_PDFTemplateID");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company", tb => tb.HasTrigger("TRG_GenerateCompanyRIN"));

            entity.HasIndex(e => e.TaxOfficeId, "IDX_COMP_TOID");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Cac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CAC");
            entity.Property(e => e.CacregistrationNumber)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("CACRegistrationNumber");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CompanyRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CompanyRIN");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.EconomicActivitiesId).HasColumnName("EconomicActivitiesID");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationMethodId).HasColumnName("NotificationMethodID");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RegisterationDate).HasColumnType("datetime");
            entity.Property(e => e.RegisterationStatusId).HasColumnName("RegisterationStatusID");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficerId).HasColumnName("TaxOfficerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.Tin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.VerificationOtp).HasColumnName("VerificationOTP");

            entity.HasOne(d => d.EconomicActivities).WithMany(p => p.Companies)
                .HasForeignKey(d => d.EconomicActivitiesId)
                .HasConstraintName("FK_Company_Economic_Activities");

            entity.HasOne(d => d.NotificationMethod).WithMany(p => p.Companies)
                .HasForeignKey(d => d.NotificationMethodId)
                .HasConstraintName("FK_Company_Notification_Method");

            entity.HasOne(d => d.RegisterationStatus).WithMany(p => p.Companies)
                .HasForeignKey(d => d.RegisterationStatusId)
                .HasConstraintName("FK_Company_MST_RegisterationStatus");

            entity.HasOne(d => d.TaxOffice).WithMany(p => p.Companies)
                .HasForeignKey(d => d.TaxOfficeId)
                .HasConstraintName("FK_Company_Tax_Offices");

            entity.HasOne(d => d.TaxPayerType).WithMany(p => p.Companies)
                .HasForeignKey(d => d.TaxPayerTypeId)
                .HasConstraintName("FK_Company_TaxPayer_Types");
        });

        modelBuilder.Entity<DealerType>(entity =>
        {
            entity.ToTable("Dealer_Types");

            entity.Property(e => e.DealerTypeId).HasColumnName("DealerTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DealerTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DiEdoGisMdaServiceItems2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DI_EdoGIS_MDA_Service_Items_2021");

            entity.Property(e => e.ComputationId).HasColumnName("ComputationID");
            entity.Property(e => e.ComputationName).HasMaxLength(255);
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemCategoryName).HasMaxLength(255);
            entity.Property(e => e.ItemSubCategoryId).HasColumnName("ItemSubCategoryID");
            entity.Property(e => e.ItemSubCategoryName).HasMaxLength(255);
            entity.Property(e => e.MdaserviceItemId).HasColumnName("MDAServiceItemID");
            entity.Property(e => e.MdaserviceItemName)
                .HasMaxLength(255)
                .HasColumnName("MDAServiceItemName");
            entity.Property(e => e.RevenueAgencyId).HasColumnName("RevenueAgencyID");
            entity.Property(e => e.RevenueAgencyName).HasMaxLength(255);
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.RevenueStreamName).HasMaxLength(255);
            entity.Property(e => e.RevenueSubStreamId).HasColumnName("RevenueSubStreamID");
            entity.Property(e => e.RevenueSubStreamName).HasMaxLength(255);
        });

        modelBuilder.Entity<DiEdoGisMdaServiceItems22021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DI_EdoGIS_MDA_Service_Items_2_2021");

            entity.Property(e => e.ComputationId).HasColumnName("ComputationID");
            entity.Property(e => e.ComputationName).HasMaxLength(255);
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemCategoryName).HasMaxLength(255);
            entity.Property(e => e.ItemSubCategoryId).HasColumnName("ItemSubCategoryID");
            entity.Property(e => e.ItemSubCategoryName).HasMaxLength(255);
            entity.Property(e => e.MdaserviceItemId).HasColumnName("MDAServiceItemID");
            entity.Property(e => e.MdaserviceItemName)
                .HasMaxLength(255)
                .HasColumnName("MDAServiceItemName");
            entity.Property(e => e.RevenueAgencyId).HasColumnName("RevenueAgencyID");
            entity.Property(e => e.RevenueAgencyName).HasMaxLength(255);
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.RevenueStreamName).HasMaxLength(255);
            entity.Property(e => e.RevenueSubStreamId).HasColumnName("RevenueSubStreamID");
            entity.Property(e => e.RevenueSubStreamName).HasMaxLength(255);
        });

        modelBuilder.Entity<DiEdoGisMdaServices2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DI_EdoGIS_MDA_Services_2021");

            entity.Property(e => e.FrequencyId).HasColumnName("FrequencyID");
            entity.Property(e => e.FrequencyName).HasMaxLength(255);
            entity.Property(e => e.MdaserviceId).HasColumnName("MDAServiceID");
            entity.Property(e => e.MdaserviceItemIds)
                .HasMaxLength(255)
                .HasColumnName("MDAServiceItemIds");
            entity.Property(e => e.MdaserviceName)
                .HasMaxLength(255)
                .HasColumnName("MDAServiceName");
            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.PaymentOptionName).HasMaxLength(255);
            entity.Property(e => e.RunRuleId).HasColumnName("RunRuleID");
            entity.Property(e => e.RunRuleName).HasMaxLength(255);
            entity.Property(e => e.SerivceAmount).HasMaxLength(255);
            entity.Property(e => e.SettlementMethodIds).HasMaxLength(255);
            entity.Property(e => e.SettlementMethodNames).HasMaxLength(255);
        });

        modelBuilder.Entity<DiEdoGisMdaServices22021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DI_EdoGIS_MDA_Services_2_2021");

            entity.Property(e => e.FrequencyId).HasColumnName("FrequencyID");
            entity.Property(e => e.FrequencyName).HasMaxLength(255);
            entity.Property(e => e.MdaserviceId).HasColumnName("MDAServiceID");
            entity.Property(e => e.MdaserviceItemIds)
                .HasMaxLength(255)
                .HasColumnName("MDAServiceItemIds");
            entity.Property(e => e.MdaserviceName)
                .HasMaxLength(255)
                .HasColumnName("MDAServiceName");
            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.PaymentOptionName).HasMaxLength(255);
            entity.Property(e => e.RunRuleId).HasColumnName("RunRuleID");
            entity.Property(e => e.RunRuleName).HasMaxLength(255);
            entity.Property(e => e.SerivceAmount).HasMaxLength(255);
            entity.Property(e => e.SettlementMethodIds).HasMaxLength(255);
            entity.Property(e => e.SettlementMethodNames).HasMaxLength(255);
        });

        modelBuilder.Entity<DiMdaService2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DI_MDA_Service_2021");

            entity.Property(e => e.FrequencyId).HasColumnName("FrequencyID");
            entity.Property(e => e.FrequencyName).HasMaxLength(255);
            entity.Property(e => e.MdaserviceId).HasColumnName("MDAServiceID");
            entity.Property(e => e.MdaserviceItemIds)
                .HasMaxLength(255)
                .HasColumnName("MDAServiceItemIds");
            entity.Property(e => e.MdaserviceName)
                .HasMaxLength(255)
                .HasColumnName("MDAServiceName");
            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.PaymentOptionName).HasMaxLength(255);
            entity.Property(e => e.RunRuleId).HasColumnName("RunRuleID");
            entity.Property(e => e.RunRuleName).HasMaxLength(255);
            entity.Property(e => e.SerivceAmount).HasMaxLength(255);
            entity.Property(e => e.ServiceItemRef).HasMaxLength(255);
            entity.Property(e => e.SettlementMethodIds).HasMaxLength(255);
            entity.Property(e => e.SettlementMethodNames).HasMaxLength(255);
        });

        modelBuilder.Entity<DiMdaServiceItems2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DI_MDA_Service_Items_2021");

            entity.Property(e => e.ComputationId).HasColumnName("ComputationID");
            entity.Property(e => e.ComputationName).HasMaxLength(255);
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemCategoryName).HasMaxLength(255);
            entity.Property(e => e.ItemSubCategoryId).HasColumnName("ItemSubCategoryID");
            entity.Property(e => e.ItemSubCategoryName).HasMaxLength(255);
            entity.Property(e => e.MdaserviceItemId).HasColumnName("MDAServiceItemID");
            entity.Property(e => e.MdaserviceItemName)
                .HasMaxLength(255)
                .HasColumnName("MDAServiceItemName");
            entity.Property(e => e.RevenueAgencyId).HasColumnName("RevenueAgencyID");
            entity.Property(e => e.RevenueAgencyName).HasMaxLength(255);
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.RevenueStreamName).HasMaxLength(255);
            entity.Property(e => e.RevenueSubStreamId).HasColumnName("RevenueSubStreamID");
            entity.Property(e => e.RevenueSubStreamName).HasMaxLength(255);
        });

        modelBuilder.Entity<Directorate>(entity =>
        {
            entity.Property(e => e.DirectorateId).HasColumnName("DirectorateID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DirectorateName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EconomicActivity>(entity =>
        {
            entity.HasKey(e => e.EconomicActivitiesId);

            entity.ToTable("Economic_Activities");

            entity.Property(e => e.EconomicActivitiesId).HasColumnName("EconomicActivitiesID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EconomicActivitiesName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");

            entity.HasOne(d => d.TaxPayerType).WithMany(p => p.EconomicActivities)
                .HasForeignKey(d => d.TaxPayerTypeId)
                .HasConstraintName("FK_Economic_Activities_TaxPayer_Types");
        });

        modelBuilder.Entity<EedIndividual>(entity =>
        {
            entity.HasKey(e => e.Eedid);

            entity.ToTable("EED_Individual");

            entity.Property(e => e.Eedid).HasColumnName("EEDID");
            entity.Property(e => e.Bvn)
                .IsUnicode(false)
                .HasColumnName("BVN");
            entity.Property(e => e.City)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.ContactAddress).IsUnicode(false);
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("date_of_birth");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.EmailAddress)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.FirstName)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.HouseNumber)
                .IsUnicode(false)
                .HasColumnName("house_number");
            entity.Property(e => e.LastName)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Lganame)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.MaritalStatus).IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.Nationality).IsUnicode(false);
            entity.Property(e => e.Nin)
                .IsUnicode(false)
                .HasColumnName("NIN");
            entity.Property(e => e.Notification).IsUnicode(false);
            entity.Property(e => e.Occupation).IsUnicode(false);
            entity.Property(e => e.PhoneNo1)
                .IsUnicode(false)
                .HasColumnName("phone_no_1");
            entity.Property(e => e.PhoneNo2)
                .IsUnicode(false)
                .HasColumnName("phone_no_2");
            entity.Property(e => e.StateName).IsUnicode(false);
            entity.Property(e => e.StateOfOrigin).IsUnicode(false);
            entity.Property(e => e.StreetName)
                .IsUnicode(false)
                .HasColumnName("street_name");
            entity.Property(e => e.TaxOffice).IsUnicode(false);
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.Title).IsUnicode(false);
        });

        modelBuilder.Entity<Ega>(entity =>
        {
            entity.ToTable("EGA");

            entity.Property(e => e.Egaid).HasColumnName("EGAID");
            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.BillRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ErrorMessage).IsUnicode(false);
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.Result)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxBaseAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
        });

        modelBuilder.Entity<ElmahError>(entity =>
        {
            entity.HasKey(e => e.ErrorId).IsClustered(false);

            entity.ToTable("ELMAH_Error");

            entity.HasIndex(e => new { e.Application, e.TimeUtc, e.Sequence }, "IX_ELMAH_Error_App_Time_Seq").IsDescending(false, true, true);

            entity.Property(e => e.ErrorId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AllXml).HasColumnType("ntext");
            entity.Property(e => e.Application).HasMaxLength(60);
            entity.Property(e => e.Host).HasMaxLength(50);
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();
            entity.Property(e => e.Source).HasMaxLength(60);
            entity.Property(e => e.TimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.User).HasMaxLength(50);
        });

        modelBuilder.Entity<EmBank>(entity =>
        {
            entity.HasKey(e => e.BankId);

            entity.ToTable("EM_Bank");

            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BankDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmBankStatement>(entity =>
        {
            entity.HasKey(e => e.Bsid);

            entity.ToTable("EM_BankStatement");

            entity.Property(e => e.Bsid).HasColumnName("BSID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.Category).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.RevenueHead).IsUnicode(false);
        });

        modelBuilder.Entity<EmCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("EM_Category");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmDataSource>(entity =>
        {
            entity.HasKey(e => e.DataSourceId);

            entity.ToTable("EM_DataSource");

            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmIgrclassification>(entity =>
        {
            entity.HasKey(e => e.IgrclassificationId);

            entity.ToTable("EM_IGRClassification");

            entity.Property(e => e.IgrclassificationId).HasColumnName("IGRClassificationID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RevenueHeadId).HasColumnName("RevenueHeadID");
        });

        modelBuilder.Entity<EmImportLog>(entity =>
        {
            entity.HasKey(e => e.ImportLogId);

            entity.ToTable("EM_ImportLog");

            entity.Property(e => e.ImportLogId).HasColumnName("ImportLogID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.ImportDate).HasColumnType("datetime");
            entity.Property(e => e.ImportFilePath)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmMapIgrclassificationEntry>(entity =>
        {
            entity.HasKey(e => e.Cdseid);

            entity.ToTable("EM_MAP_IGRClassification_Entry");

            entity.Property(e => e.Cdseid).HasColumnName("CDSEID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.Dseid).HasColumnName("DSEID");
            entity.Property(e => e.IgrclassificationId).HasColumnName("IGRClassificationID");
        });

        modelBuilder.Entity<EmPdMainAuthorized>(entity =>
        {
            entity.HasKey(e => e.Pdmaid);

            entity.ToTable("EM_PD_Main_Authorized");

            entity.Property(e => e.Pdmaid).HasColumnName("PDMAID");
            entity.Property(e => e.AdditionalInfo).IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentReference).IsUnicode(false);
            entity.Property(e => e.AuthId)
                .IsUnicode(false)
                .HasColumnName("AuthID");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.BankBranch).IsUnicode(false);
            entity.Property(e => e.ChequeValueDate).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.DepositSlip).IsUnicode(false);
            entity.Property(e => e.PaymentCode).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentMethod).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.ReceiptNo).IsUnicode(false);
            entity.Property(e => e.RetrievalRefNumber).IsUnicode(false);
            entity.Property(e => e.RevenueItem).IsUnicode(false);
            entity.Property(e => e.Rin)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.TaxPayerType).IsUnicode(false);
        });

        modelBuilder.Entity<EmPdMainPending>(entity =>
        {
            entity.HasKey(e => e.Pdmpid);

            entity.ToTable("EM_PD_Main_Pending");

            entity.Property(e => e.Pdmpid).HasColumnName("PDMPID");
            entity.Property(e => e.AdditionalInfo).IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentReference).IsUnicode(false);
            entity.Property(e => e.AuthId)
                .IsUnicode(false)
                .HasColumnName("AuthID");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.BankBranch).IsUnicode(false);
            entity.Property(e => e.ChequeValueDate).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.DepositSlip).IsUnicode(false);
            entity.Property(e => e.PaymentCode).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentMethod).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.ReceiptNo).IsUnicode(false);
            entity.Property(e => e.RetrievalRefNumber).IsUnicode(false);
            entity.Property(e => e.RevenueItem).IsUnicode(false);
            entity.Property(e => e.Rin)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.TaxPayerType).IsUnicode(false);
        });

        modelBuilder.Entity<EmPdMvaAuthorized>(entity =>
        {
            entity.HasKey(e => e.Pdmvaid);

            entity.ToTable("EM_PD_MVA_Authorized");

            entity.Property(e => e.Pdmvaid).HasColumnName("PDMVAID");
            entity.Property(e => e.AdditionalInfo).IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentReference).IsUnicode(false);
            entity.Property(e => e.AuthId)
                .IsUnicode(false)
                .HasColumnName("AuthID");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.BankBranch).IsUnicode(false);
            entity.Property(e => e.ChequeValueDate).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.DepositSlip).IsUnicode(false);
            entity.Property(e => e.PaymentCode).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentMethod).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.ReceiptNo).IsUnicode(false);
            entity.Property(e => e.RetrievalRefNumber).IsUnicode(false);
            entity.Property(e => e.RevenueItem).IsUnicode(false);
            entity.Property(e => e.Rin)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.TaxPayerType).IsUnicode(false);
        });

        modelBuilder.Entity<EmPdMvaPending>(entity =>
        {
            entity.HasKey(e => e.Pdmvpid);

            entity.ToTable("EM_PD_MVA_Pending");

            entity.Property(e => e.Pdmvpid).HasColumnName("PDMVPID");
            entity.Property(e => e.AdditionalInfo).IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentReference).IsUnicode(false);
            entity.Property(e => e.AuthId)
                .IsUnicode(false)
                .HasColumnName("AuthID");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.BankBranch).IsUnicode(false);
            entity.Property(e => e.ChequeValueDate).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.DepositSlip).IsUnicode(false);
            entity.Property(e => e.PaymentCode).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentMethod).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.ReceiptNo).IsUnicode(false);
            entity.Property(e => e.RetrievalRefNumber).IsUnicode(false);
            entity.Property(e => e.RevenueItem).IsUnicode(false);
            entity.Property(e => e.Rin)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.TaxPayerType).IsUnicode(false);
        });

        modelBuilder.Entity<EmRevenueHead>(entity =>
        {
            entity.HasKey(e => e.RevenueHeadId);

            entity.ToTable("EM_RevenueHead");

            entity.Property(e => e.RevenueHeadId).HasColumnName("RevenueHeadID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RevenueHeadName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Category).WithMany(p => p.EmRevenueHeads)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_EM_RevenueHead_EM_Category");
        });

        modelBuilder.Entity<EpldBusiness>(entity =>
        {
            entity.HasKey(e => e.Epldid);

            entity.ToTable("EPLD_Business");

            entity.Property(e => e.Epldid).HasColumnName("EPLDID");
            entity.Property(e => e.BusinessAddress).IsUnicode(false);
            entity.Property(e => e.BusinessCategoryId).HasColumnName("BusinessCategoryID");
            entity.Property(e => e.BusinessCategoryName).IsUnicode(false);
            entity.Property(e => e.BusinessNumber).IsUnicode(false);
            entity.Property(e => e.BusinessOperationId).HasColumnName("BusinessOperationID");
            entity.Property(e => e.BusinessOperationName).IsUnicode(false);
            entity.Property(e => e.BusinessSectorId).HasColumnName("BusinessSectorID");
            entity.Property(e => e.BusinessSectorName).IsUnicode(false);
            entity.Property(e => e.BusinessStructureId).HasColumnName("BusinessStructureID");
            entity.Property(e => e.BusinessStructureName).IsUnicode(false);
            entity.Property(e => e.BusinessSubSectorId).HasColumnName("BusinessSubSectorID");
            entity.Property(e => e.BusinessSubSectorName).IsUnicode(false);
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.BusinessTypename).IsUnicode(false);
            entity.Property(e => e.CompCacRegistrationnumber)
                .IsUnicode(false)
                .HasColumnName("comp_cac_registrationnumber");
            entity.Property(e => e.CompEconomicActivityId).HasColumnName("comp_economic_activity_id");
            entity.Property(e => e.CompEconomicActivityName)
                .IsUnicode(false)
                .HasColumnName("comp_economic_activity_name");
            entity.Property(e => e.CompEmailAddress)
                .IsUnicode(false)
                .HasColumnName("comp_email_address");
            entity.Property(e => e.CompName)
                .IsUnicode(false)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompNotificationName)
                .IsUnicode(false)
                .HasColumnName("comp_notificationName");
            entity.Property(e => e.CompNotificationid).HasColumnName("comp_notificationid");
            entity.Property(e => e.CompPhoneNo1)
                .IsUnicode(false)
                .HasColumnName("comp_phone_no_1");
            entity.Property(e => e.CompPhoneNo2)
                .IsUnicode(false)
                .HasColumnName("comp_phone_no_2");
            entity.Property(e => e.CompTaxofficeName)
                .IsUnicode(false)
                .HasColumnName("comp_taxofficeName");
            entity.Property(e => e.CompTaxofficeid).HasColumnName("comp_taxofficeid");
            entity.Property(e => e.CompTin)
                .IsUnicode(false)
                .HasColumnName("comp_tin");
            entity.Property(e => e.ContactName).IsUnicode(false);
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.IndDateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("ind_date_of_birth");
            entity.Property(e => e.IndEconomicActivityId).HasColumnName("ind_economic_activity_id");
            entity.Property(e => e.IndEconomicActivityName)
                .IsUnicode(false)
                .HasColumnName("ind_economic_activity_name");
            entity.Property(e => e.IndEmailAddress)
                .IsUnicode(false)
                .HasColumnName("ind_email_address");
            entity.Property(e => e.IndFirstName)
                .IsUnicode(false)
                .HasColumnName("ind_first_name");
            entity.Property(e => e.IndGenderId).HasColumnName("ind_GenderID");
            entity.Property(e => e.IndGenderName)
                .IsUnicode(false)
                .HasColumnName("ind_GenderName");
            entity.Property(e => e.IndLastName)
                .IsUnicode(false)
                .HasColumnName("ind_last_name");
            entity.Property(e => e.IndMaritalstatusName)
                .IsUnicode(false)
                .HasColumnName("ind_maritalstatusName");
            entity.Property(e => e.IndMaritalstatusid).HasColumnName("ind_maritalstatusid");
            entity.Property(e => e.IndMiddleName)
                .IsUnicode(false)
                .HasColumnName("ind_middle_name");
            entity.Property(e => e.IndNationalityName)
                .IsUnicode(false)
                .HasColumnName("ind_nationalityName");
            entity.Property(e => e.IndNationalityid).HasColumnName("ind_nationalityid");
            entity.Property(e => e.IndNotificationName)
                .IsUnicode(false)
                .HasColumnName("ind_notificationName");
            entity.Property(e => e.IndNotificationid).HasColumnName("ind_notificationid");
            entity.Property(e => e.IndPhoneNo1)
                .IsUnicode(false)
                .HasColumnName("ind_phone_no_1");
            entity.Property(e => e.IndPhoneNo2)
                .IsUnicode(false)
                .HasColumnName("ind_phone_no_2");
            entity.Property(e => e.IndTaxofficeName)
                .IsUnicode(false)
                .HasColumnName("ind_taxofficeName");
            entity.Property(e => e.IndTaxofficeid).HasColumnName("ind_taxofficeid");
            entity.Property(e => e.IndTin)
                .IsUnicode(false)
                .HasColumnName("ind_tin");
            entity.Property(e => e.IndTitleId).HasColumnName("ind_TitleID");
            entity.Property(e => e.IndTitleName)
                .IsUnicode(false)
                .HasColumnName("ind_TitleName");
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.Lganame)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.RecordResult)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.RecordStatus)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RegisteredName).IsUnicode(false);
            entity.Property(e => e.Rin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.SizeName).IsUnicode(false);
            entity.Property(e => e.TaxPayerRoleId).HasColumnName("TaxPayerRoleID");
            entity.Property(e => e.TaxPayerRoleName).IsUnicode(false);
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName).IsUnicode(false);
        });

        modelBuilder.Entity<EpldIndividual>(entity =>
        {
            entity.HasKey(e => e.Epldid);

            entity.ToTable("EPLD_Individual");

            entity.Property(e => e.Epldid).HasColumnName("EPLDID");
            entity.Property(e => e.Bvn)
                .IsUnicode(false)
                .HasColumnName("BVN");
            entity.Property(e => e.City)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.ContactAddress).IsUnicode(false);
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("date_of_birth");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.EconomicActivityId).HasColumnName("EconomicActivityID");
            entity.Property(e => e.EconomicActivityName).IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.FirstName)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.GenderName).IsUnicode(false);
            entity.Property(e => e.HouseNumber)
                .IsUnicode(false)
                .HasColumnName("house_number");
            entity.Property(e => e.LastName)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Lganame)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MaritalStatusName).IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.NationalityId).HasColumnName("NationalityID");
            entity.Property(e => e.NationalityName).IsUnicode(false);
            entity.Property(e => e.Nin)
                .IsUnicode(false)
                .HasColumnName("NIN");
            entity.Property(e => e.NotificationMethodId).HasColumnName("NotificationMethodID");
            entity.Property(e => e.NotificationMethodName).IsUnicode(false);
            entity.Property(e => e.PhoneNo1)
                .IsUnicode(false)
                .HasColumnName("phone_no_1");
            entity.Property(e => e.PhoneNo2)
                .IsUnicode(false)
                .HasColumnName("phone_no_2");
            entity.Property(e => e.RecordResult)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.RecordStatus)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Rin)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.StateName).IsUnicode(false);
            entity.Property(e => e.StateOfOrigin).IsUnicode(false);
            entity.Property(e => e.StreetName)
                .IsUnicode(false)
                .HasColumnName("street_name");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficeName).IsUnicode(false);
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.TitleName).IsUnicode(false);
        });

        modelBuilder.Entity<EsdBusiness>(entity =>
        {
            entity.HasKey(e => e.Esdid);

            entity.ToTable("ESD_Business");

            entity.Property(e => e.Esdid).HasColumnName("ESDID");
            entity.Property(e => e.BusinessCategory)
                .IsUnicode(false)
                .HasColumnName("business_category");
            entity.Property(e => e.BusinessOperation)
                .IsUnicode(false)
                .HasColumnName("business_operation");
            entity.Property(e => e.BusinessSector)
                .IsUnicode(false)
                .HasColumnName("business_sector");
            entity.Property(e => e.BusinessStructure)
                .IsUnicode(false)
                .HasColumnName("business_structure");
            entity.Property(e => e.BusinessSubSector)
                .IsUnicode(false)
                .HasColumnName("business_sub_sector");
            entity.Property(e => e.BusinessType)
                .IsUnicode(false)
                .HasColumnName("business_type");
            entity.Property(e => e.City)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CommencementDate)
                .HasColumnType("datetime")
                .HasColumnName("commencement_date");
            entity.Property(e => e.CompCacRegistrationnumber)
                .IsUnicode(false)
                .HasColumnName("comp_cac_registrationnumber");
            entity.Property(e => e.CompEconomicActivity)
                .IsUnicode(false)
                .HasColumnName("comp_economic_activity");
            entity.Property(e => e.CompEmailAddress)
                .IsUnicode(false)
                .HasColumnName("comp_email_address");
            entity.Property(e => e.CompName)
                .IsUnicode(false)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompNotification)
                .IsUnicode(false)
                .HasColumnName("comp_notification");
            entity.Property(e => e.CompPhoneNo1)
                .IsUnicode(false)
                .HasColumnName("comp_phone_no_1");
            entity.Property(e => e.CompPhoneNo2)
                .IsUnicode(false)
                .HasColumnName("comp_phone_no_2");
            entity.Property(e => e.CompTaxoffice)
                .IsUnicode(false)
                .HasColumnName("comp_taxoffice");
            entity.Property(e => e.CompTin)
                .IsUnicode(false)
                .HasColumnName("comp_tin");
            entity.Property(e => e.ContactAddress).IsUnicode(false);
            entity.Property(e => e.ContactName)
                .IsUnicode(false)
                .HasColumnName("Contact_Name");
            entity.Property(e => e.CountryName).IsUnicode(false);
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateOfIncorporation)
                .HasColumnType("datetime")
                .HasColumnName("date_of_incorporation");
            entity.Property(e => e.DateOfRegistration)
                .HasColumnType("datetime")
                .HasColumnName("date_of_registration");
            entity.Property(e => e.DirectorEmail)
                .IsUnicode(false)
                .HasColumnName("director_email");
            entity.Property(e => e.DirectorName)
                .IsUnicode(false)
                .HasColumnName("director_name");
            entity.Property(e => e.DirectorPhone)
                .IsUnicode(false)
                .HasColumnName("director_phone");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.EmailAddress)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.FinYrBegin).IsUnicode(false);
            entity.Property(e => e.FinYrEnd).IsUnicode(false);
            entity.Property(e => e.HouseNumber)
                .IsUnicode(false)
                .HasColumnName("house_number");
            entity.Property(e => e.IndDateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("ind_date_of_birth");
            entity.Property(e => e.IndEconomicActivity)
                .IsUnicode(false)
                .HasColumnName("ind_economic_activity");
            entity.Property(e => e.IndEmailAddress)
                .IsUnicode(false)
                .HasColumnName("ind_email_address");
            entity.Property(e => e.IndFirstName)
                .IsUnicode(false)
                .HasColumnName("ind_first_name");
            entity.Property(e => e.IndGender)
                .IsUnicode(false)
                .HasColumnName("ind_Gender");
            entity.Property(e => e.IndLastName)
                .IsUnicode(false)
                .HasColumnName("ind_last_name");
            entity.Property(e => e.IndMaritalstatus)
                .IsUnicode(false)
                .HasColumnName("ind_maritalstatus");
            entity.Property(e => e.IndMiddleName)
                .IsUnicode(false)
                .HasColumnName("ind_middle_name");
            entity.Property(e => e.IndNationality)
                .IsUnicode(false)
                .HasColumnName("ind_nationality");
            entity.Property(e => e.IndNotification)
                .IsUnicode(false)
                .HasColumnName("ind_notification");
            entity.Property(e => e.IndPhoneNo1)
                .IsUnicode(false)
                .HasColumnName("ind_phone_no_1");
            entity.Property(e => e.IndPhoneNo2)
                .IsUnicode(false)
                .HasColumnName("ind_phone_no_2");
            entity.Property(e => e.IndTaxoffice)
                .IsUnicode(false)
                .HasColumnName("ind_taxoffice");
            entity.Property(e => e.IndTin)
                .IsUnicode(false)
                .HasColumnName("ind_tin");
            entity.Property(e => e.IndTitle)
                .IsUnicode(false)
                .HasColumnName("ind_Title");
            entity.Property(e => e.Lganame)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.LineOfBusinessCode)
                .IsUnicode(false)
                .HasColumnName("line_of_business_code");
            entity.Property(e => e.LobName)
                .IsUnicode(false)
                .HasColumnName("lob_name");
            entity.Property(e => e.MainTradeName)
                .IsUnicode(false)
                .HasColumnName("main_trade_name");
            entity.Property(e => e.OrgName)
                .IsUnicode(false)
                .HasColumnName("org_name");
            entity.Property(e => e.PhoneNo1)
                .IsUnicode(false)
                .HasColumnName("phone_no_1");
            entity.Property(e => e.PhoneNo2)
                .IsUnicode(false)
                .HasColumnName("phone_no_2");
            entity.Property(e => e.PremisesSize)
                .IsUnicode(false)
                .HasColumnName("Premises_Size");
            entity.Property(e => e.RecordError)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("record_error");
            entity.Property(e => e.RecordStatus)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("record_status");
            entity.Property(e => e.RegisteredName)
                .IsUnicode(false)
                .HasColumnName("registered_name");
            entity.Property(e => e.RegistrationNumber)
                .IsUnicode(false)
                .HasColumnName("registration_number");
            entity.Property(e => e.StateName).IsUnicode(false);
            entity.Property(e => e.StreetName)
                .IsUnicode(false)
                .HasColumnName("street_name");
            entity.Property(e => e.TaxAuthorityCode).IsUnicode(false);
            entity.Property(e => e.TaxAuthorityName).IsUnicode(false);
            entity.Property(e => e.TaxPayerRole).IsUnicode(false);
            entity.Property(e => e.TaxPayerType).IsUnicode(false);
            entity.Property(e => e.TaxpayerStatus).IsUnicode(false);
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
        });

        modelBuilder.Entity<EsdIndividual>(entity =>
        {
            entity.HasKey(e => e.Esdid);

            entity.ToTable("ESD_Individual");

            entity.Property(e => e.Esdid).HasColumnName("ESDID");
            entity.Property(e => e.Bvn)
                .IsUnicode(false)
                .HasColumnName("BVN");
            entity.Property(e => e.City)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.ContactAddress).IsUnicode(false);
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("date_of_birth");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.EmailAddress)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.FirstName)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.HouseNumber)
                .IsUnicode(false)
                .HasColumnName("house_number");
            entity.Property(e => e.LastName)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Lganame)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.MaritalStatus).IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.Nationality).IsUnicode(false);
            entity.Property(e => e.Nin)
                .IsUnicode(false)
                .HasColumnName("NIN");
            entity.Property(e => e.Notification).IsUnicode(false);
            entity.Property(e => e.Occupation).IsUnicode(false);
            entity.Property(e => e.PhoneNo1)
                .IsUnicode(false)
                .HasColumnName("phone_no_1");
            entity.Property(e => e.PhoneNo2)
                .IsUnicode(false)
                .HasColumnName("phone_no_2");
            entity.Property(e => e.RecordError)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("record_error");
            entity.Property(e => e.RecordStatus)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("record_status");
            entity.Property(e => e.StateName).IsUnicode(false);
            entity.Property(e => e.StateOfOrigin).IsUnicode(false);
            entity.Property(e => e.StreetName)
                .IsUnicode(false)
                .HasColumnName("street_name");
            entity.Property(e => e.TaxOffice).IsUnicode(false);
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.Title).IsUnicode(false);
        });

        modelBuilder.Entity<ExceptionType>(entity =>
        {
            entity.ToTable("Exception_Type");

            entity.Property(e => e.ExceptionTypeId).HasColumnName("ExceptionTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExceptionTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExternalDataSource>(entity =>
        {
            entity.HasKey(e => e.DataSourceId);

            entity.ToTable("External_DataSource");

            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.ToTable("Gender");

            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.GenderName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GisfileAssessment>(entity =>
        {
            entity.ToTable("GISFileAssessment");

            entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");
            entity.Property(e => e.FileId).HasDefaultValueSql("(CONVERT([bigint],(0)))");
        });

        modelBuilder.Entity<GisfileAssessmentItem>(entity =>
        {
            entity.ToTable("GISFileAssessmentItem");

            entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");
        });

        modelBuilder.Entity<GisfileAsset>(entity =>
        {
            entity.ToTable("GISFileAsset");

            entity.Property(e => e.AssetLga).HasColumnName("AssetLGA");
            entity.Property(e => e.FileId).HasDefaultValueSql("(CONVERT([bigint],(0)))");
            entity.Property(e => e.PartyId).HasColumnName("PartyID");
        });

        modelBuilder.Entity<GisfileHolder>(entity =>
        {
            entity.ToTable("GISFileHolder");

            entity.Property(e => e.DateSaved).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.FileId).HasDefaultValueSql("(CONVERT([bigint],(0)))");
        });

        modelBuilder.Entity<GisfileInvoice>(entity =>
        {
            entity.ToTable("GISFileInvoice");

            entity.Property(e => e.FileId).HasDefaultValueSql("(CONVERT([bigint],(0)))");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.IsReversal).HasColumnName("isReversal");
        });

        modelBuilder.Entity<GisfileInvoiceItem>(entity =>
        {
            entity.ToTable("GISFileInvoiceItem");

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
        });

        modelBuilder.Entity<GisfileParty>(entity =>
        {
            entity.ToTable("GISFileParty");

            entity.Property(e => e.FileId).HasDefaultValueSql("(CONVERT([bigint],(0)))");
            entity.Property(e => e.PartyDob).HasColumnName("PartyDOB");
            entity.Property(e => e.PartyExtId).HasColumnName("PartyExtID");
            entity.Property(e => e.PartyId).HasColumnName("PartyID");
            entity.Property(e => e.PartyNin).HasColumnName("PartyNIN");
            entity.Property(e => e.PartyTin).HasColumnName("PartyTIN");
        });

        modelBuilder.Entity<Gistesting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GISTesting");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Government>(entity =>
        {
            entity.ToTable("Government", tb => tb.HasTrigger("TRG_GenerateGovernmentRIN"));

            entity.Property(e => e.GovernmentId).HasColumnName("GovernmentID");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.GovernmentName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GovernmentRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("GovernmentRIN");
            entity.Property(e => e.GovernmentTypeId).HasColumnName("GovernmentTypeID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationMethodId).HasColumnName("NotificationMethodID");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RegisterationDate).HasColumnType("datetime");
            entity.Property(e => e.RegisterationStatusId).HasColumnName("RegisterationStatusID");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficerId).HasColumnName("TaxOfficerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.Tin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.VerificationOtp).HasColumnName("VerificationOTP");

            entity.HasOne(d => d.GovernmentType).WithMany(p => p.Governments)
                .HasForeignKey(d => d.GovernmentTypeId)
                .HasConstraintName("FK_Government_Government_Types");

            entity.HasOne(d => d.NotificationMethod).WithMany(p => p.Governments)
                .HasForeignKey(d => d.NotificationMethodId)
                .HasConstraintName("FK_Government_Notification_Method");

            entity.HasOne(d => d.RegisterationStatus).WithMany(p => p.Governments)
                .HasForeignKey(d => d.RegisterationStatusId)
                .HasConstraintName("FK_Government_MST_RegisterationStatus");

            entity.HasOne(d => d.TaxOffice).WithMany(p => p.Governments)
                .HasForeignKey(d => d.TaxOfficeId)
                .HasConstraintName("FK_Government_Tax_Offices");

            entity.HasOne(d => d.TaxPayerType).WithMany(p => p.Governments)
                .HasForeignKey(d => d.TaxPayerTypeId)
                .HasConstraintName("FK_Government_TaxPayer_Types");
        });

        modelBuilder.Entity<GovernmentType>(entity =>
        {
            entity.ToTable("Government_Types");

            entity.Property(e => e.GovernmentTypeId).HasColumnName("GovernmentTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GovernmentTypeName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Individual>(entity =>
        {
            entity.ToTable("Individual", tb => tb.HasTrigger("TRG_GenerateIndividualRIN"));

            entity.HasIndex(e => e.TaxOfficeId, "IDX_IND_RIN_FL");

            entity.HasIndex(e => e.TitleId, "IDX_IND_TITLE");

            entity.HasIndex(e => e.TaxOfficeId, "IDX_IN_TOF");

            entity.Property(e => e.IndividualId).HasColumnName("IndividualID");
            entity.Property(e => e.BiometricDetails)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.EconomicActivitiesId).HasColumnName("EconomicActivitiesID");
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.IndividualRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IndividualRIN");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NationalityId).HasColumnName("NationalityID");
            entity.Property(e => e.Nin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NIN");
            entity.Property(e => e.NotificationMethodId).HasColumnName("NotificationMethodID");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RegisterationDate).HasColumnType("datetime");
            entity.Property(e => e.RegisterationStatusId).HasColumnName("RegisterationStatusID");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficerId).HasColumnName("TaxOfficerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.Tin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TIN");
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.VerificationOtp).HasColumnName("VerificationOTP");

            entity.HasOne(d => d.EconomicActivities).WithMany(p => p.Individuals)
                .HasForeignKey(d => d.EconomicActivitiesId)
                .HasConstraintName("FK_Individual_Economic_Activities");

            entity.HasOne(d => d.Gender).WithMany(p => p.Individuals)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK_Individual_Gender");

            entity.HasOne(d => d.MaritalStatus).WithMany(p => p.Individuals)
                .HasForeignKey(d => d.MaritalStatusId)
                .HasConstraintName("FK_Individual_MaritalStatus");

            entity.HasOne(d => d.Nationality).WithMany(p => p.Individuals)
                .HasForeignKey(d => d.NationalityId)
                .HasConstraintName("FK_Individual_Nationality");

            entity.HasOne(d => d.NotificationMethod).WithMany(p => p.Individuals)
                .HasForeignKey(d => d.NotificationMethodId)
                .HasConstraintName("FK_Individual_Notification_Method");

            entity.HasOne(d => d.RegisterationStatus).WithMany(p => p.Individuals)
                .HasForeignKey(d => d.RegisterationStatusId)
                .HasConstraintName("FK_Individual_MST_RegisterationStatus");

            entity.HasOne(d => d.TaxOffice).WithMany(p => p.Individuals)
                .HasForeignKey(d => d.TaxOfficeId)
                .HasConstraintName("FK_Individual_Tax_Offices");

            entity.HasOne(d => d.TaxPayerType).WithMany(p => p.Individuals)
                .HasForeignKey(d => d.TaxPayerTypeId)
                .HasConstraintName("FK_Individual_TaxPayer_Types");

            entity.HasOne(d => d.Title).WithMany(p => p.Individuals)
                .HasForeignKey(d => d.TitleId)
                .HasConstraintName("FK_Individual_Titles");
        });

        modelBuilder.Entity<JtbIndividual>(entity =>
        {
            entity.ToTable("JTB_Individual");

            entity.Property(e => e.JtbindividualId).HasColumnName("JTBIndividualID");
            entity.Property(e => e.Bvn)
                .IsUnicode(false)
                .HasColumnName("bvn");
            entity.Property(e => e.City)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CountryName).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("date_of_birth");
            entity.Property(e => e.DateOfRegistration)
                .HasColumnType("datetime")
                .HasColumnName("date_of_registration");
            entity.Property(e => e.EmailAddress)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.GenderName).IsUnicode(false);
            entity.Property(e => e.HouseNumber)
                .IsUnicode(false)
                .HasColumnName("house_number");
            entity.Property(e => e.LastName)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Lganame)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.MaritalStatus).IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NationalityName)
                .IsUnicode(false)
                .HasColumnName("nationality_name");
            entity.Property(e => e.Nin)
                .IsUnicode(false)
                .HasColumnName("nin");
            entity.Property(e => e.Occupation).IsUnicode(false);
            entity.Property(e => e.PhoneNo1)
                .IsUnicode(false)
                .HasColumnName("phone_no_1");
            entity.Property(e => e.PhoneNo2)
                .IsUnicode(false)
                .HasColumnName("phone_no_2");
            entity.Property(e => e.SbirtName)
                .IsUnicode(false)
                .HasColumnName("SBIRt_name");
            entity.Property(e => e.StateName).IsUnicode(false);
            entity.Property(e => e.StateOfOrigin).IsUnicode(false);
            entity.Property(e => e.StreetName)
                .IsUnicode(false)
                .HasColumnName("street_name");
            entity.Property(e => e.TaxAuthorityCode).IsUnicode(false);
            entity.Property(e => e.TaxAuthorityName).IsUnicode(false);
            entity.Property(e => e.TaxpayerPhoto)
                .IsUnicode(false)
                .HasColumnName("taxpayer_photo");
            entity.Property(e => e.TaxpayerStatus).IsUnicode(false);
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
            entity.Property(e => e.Title).IsUnicode(false);
        });

        modelBuilder.Entity<JtbIndividualOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JTB_Individual_Old");

            entity.Property(e => e.BiometricDetails).HasMaxLength(255);
            entity.Property(e => e.ContactAddress).HasMaxLength(255);
            entity.Property(e => e.Dob)
                .HasMaxLength(255)
                .HasColumnName("DOB");
            entity.Property(e => e.EconomicActivitiesId).HasColumnName("EconomicActivitiesID");
            entity.Property(e => e.EconomicActivitiesName).HasMaxLength(255);
            entity.Property(e => e.EmailAddress1).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.GenderName).HasMaxLength(255);
            entity.Property(e => e.IndividualId).HasColumnName("IndividualID");
            entity.Property(e => e.IndividualRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IndividualRIN");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MaritalStatusName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.MobileNumber2).HasMaxLength(255);
            entity.Property(e => e.NationalityId).HasColumnName("NationalityID");
            entity.Property(e => e.NationalityName).HasMaxLength(255);
            entity.Property(e => e.NotificationMethodId).HasColumnName("NotificationMethodID");
            entity.Property(e => e.NotificationMethodName).HasMaxLength(255);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficeName).HasMaxLength(255);
            entity.Property(e => e.Tin)
                .HasMaxLength(255)
                .HasColumnName("TIN");
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.TitleName).HasMaxLength(255);
        });

        modelBuilder.Entity<JtbNonIndividual>(entity =>
        {
            entity.ToTable("JTB_NonIndividual");

            entity.Property(e => e.JtbnonIndividualId).HasColumnName("JTBNonIndividualID");
            entity.Property(e => e.City)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CommencementDate)
                .HasColumnType("datetime")
                .HasColumnName("commencement_date");
            entity.Property(e => e.CountryName).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfIncorporation)
                .HasColumnType("datetime")
                .HasColumnName("date_of_incorporation");
            entity.Property(e => e.DateOfRegistration)
                .HasColumnType("datetime")
                .HasColumnName("date_of_registration");
            entity.Property(e => e.DirectorEmail)
                .IsUnicode(false)
                .HasColumnName("director_email");
            entity.Property(e => e.DirectorName)
                .IsUnicode(false)
                .HasColumnName("director_name");
            entity.Property(e => e.DirectorPhone)
                .IsUnicode(false)
                .HasColumnName("director_phone");
            entity.Property(e => e.EmailAddress)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.FinYrBegin).IsUnicode(false);
            entity.Property(e => e.FinYrEnd).IsUnicode(false);
            entity.Property(e => e.HouseNumber)
                .IsUnicode(false)
                .HasColumnName("house_number");
            entity.Property(e => e.Lganame)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.LineOfBusinessCode)
                .IsUnicode(false)
                .HasColumnName("line_of_business_code");
            entity.Property(e => e.LobName)
                .IsUnicode(false)
                .HasColumnName("lob_name");
            entity.Property(e => e.MainTradeName)
                .IsUnicode(false)
                .HasColumnName("main_trade_name");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrgName)
                .IsUnicode(false)
                .HasColumnName("org_name");
            entity.Property(e => e.PhoneNo1)
                .IsUnicode(false)
                .HasColumnName("phone_no_1");
            entity.Property(e => e.PhoneNo2)
                .IsUnicode(false)
                .HasColumnName("phone_no_2");
            entity.Property(e => e.RegisteredName)
                .IsUnicode(false)
                .HasColumnName("registered_name");
            entity.Property(e => e.RegistrationNumber)
                .IsUnicode(false)
                .HasColumnName("registration_number");
            entity.Property(e => e.StateName).IsUnicode(false);
            entity.Property(e => e.StreetName)
                .IsUnicode(false)
                .HasColumnName("street_name");
            entity.Property(e => e.TaxAuthorityCode).IsUnicode(false);
            entity.Property(e => e.TaxAuthorityName).IsUnicode(false);
            entity.Property(e => e.TaxpayerStatus).IsUnicode(false);
            entity.Property(e => e.Tin)
                .IsUnicode(false)
                .HasColumnName("tin");
        });

        modelBuilder.Entity<Land>(entity =>
        {
            entity.ToTable("Land", tb => tb.HasTrigger("TRG_GenerateLandRIN"));

            entity.HasIndex(e => e.AssetTypeId, "IDX_LA");

            entity.Property(e => e.LandId).HasColumnName("LandID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.COfORef)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("C_OF_O_Ref");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.LandDevelopmentId).HasColumnName("LandDevelopmentID");
            entity.Property(e => e.LandFunctionId).HasColumnName("LandFunctionID");
            entity.Property(e => e.LandOccupier)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LandOwnershipId).HasColumnName("LandOwnershipID");
            entity.Property(e => e.LandPurposeId).HasColumnName("LandPurposeID");
            entity.Property(e => e.LandRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LandRIN");
            entity.Property(e => e.LandSizeLength)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LandSize_Length");
            entity.Property(e => e.LandSizeWidth)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LandSize_Width");
            entity.Property(e => e.LandStreetConditionId).HasColumnName("LandStreetConditionID");
            entity.Property(e => e.Latitude)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.Longitude)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Neighborhood)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PlotNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StreetName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TownId).HasColumnName("TownID");
            entity.Property(e => e.ValueOfLand).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WardId).HasColumnName("WardID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.Lands)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_Land_Asset_Types");

            entity.HasOne(d => d.LandDevelopment).WithMany(p => p.Lands)
                .HasForeignKey(d => d.LandDevelopmentId)
                .HasConstraintName("FK_Land_Land_Development");

            entity.HasOne(d => d.LandFunction).WithMany(p => p.Lands)
                .HasForeignKey(d => d.LandFunctionId)
                .HasConstraintName("FK_Land_Land_Function");

            entity.HasOne(d => d.LandOwnership).WithMany(p => p.Lands)
                .HasForeignKey(d => d.LandOwnershipId)
                .HasConstraintName("FK_Land_Land_Ownership");

            entity.HasOne(d => d.LandPurpose).WithMany(p => p.Lands)
                .HasForeignKey(d => d.LandPurposeId)
                .HasConstraintName("FK_Land_Land_Purpose");

            entity.HasOne(d => d.LandStreetCondition).WithMany(p => p.Lands)
                .HasForeignKey(d => d.LandStreetConditionId)
                .HasConstraintName("FK_Land_Land_StreetCondition");

            entity.HasOne(d => d.Lga).WithMany(p => p.Lands)
                .HasForeignKey(d => d.Lgaid)
                .HasConstraintName("FK_Land_LGA");

            entity.HasOne(d => d.Town).WithMany(p => p.Lands)
                .HasForeignKey(d => d.TownId)
                .HasConstraintName("FK_Land_Town");

            entity.HasOne(d => d.Ward).WithMany(p => p.Lands)
                .HasForeignKey(d => d.WardId)
                .HasConstraintName("FK_Land_Ward");
        });

        modelBuilder.Entity<LandDevelopment>(entity =>
        {
            entity.ToTable("Land_Development");

            entity.Property(e => e.LandDevelopmentId).HasColumnName("LandDevelopmentID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LandDevelopmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LandFunction>(entity =>
        {
            entity.ToTable("Land_Function");

            entity.Property(e => e.LandFunctionId).HasColumnName("LandFunctionID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LandFunctionName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LandPurposeId).HasColumnName("LandPurposeID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.LandPurpose).WithMany(p => p.LandFunctions)
                .HasForeignKey(d => d.LandPurposeId)
                .HasConstraintName("FK_Land_Function_Land_Purpose");
        });

        modelBuilder.Entity<LandOwnership>(entity =>
        {
            entity.ToTable("Land_Ownership");

            entity.Property(e => e.LandOwnershipId).HasColumnName("LandOwnershipID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LandOwnershipName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LandPurpose>(entity =>
        {
            entity.ToTable("Land_Purpose");

            entity.Property(e => e.LandPurposeId).HasColumnName("LandPurposeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LandPurposeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LandStreetCondition>(entity =>
        {
            entity.ToTable("Land_StreetCondition");

            entity.Property(e => e.LandStreetConditionId).HasColumnName("LandStreetConditionID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LandStreetConditionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LateCharge>(entity =>
        {
            entity.ToTable("Late_Charges");

            entity.Property(e => e.LateChargeId).HasColumnName("LateChargeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Interest).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Penalty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
        });

        modelBuilder.Entity<Lga>(entity =>
        {
            entity.ToTable("LGA");

            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LgaclassId).HasColumnName("LGAClassID");
            entity.Property(e => e.Lganame)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Lgaclass).WithMany(p => p.Lgas)
                .HasForeignKey(d => d.LgaclassId)
                .HasConstraintName("FK_LGA_LGAClass");
        });

        modelBuilder.Entity<Lgaclass>(entity =>
        {
            entity.ToTable("LGAClass");

            entity.Property(e => e.LgaclassId)
                .ValueGeneratedNever()
                .HasColumnName("LGAClassID");
            entity.Property(e => e.LgaclassName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LGAClassName");
        });

        modelBuilder.Entity<MapAssessmentAdjustment>(entity =>
        {
            entity.HasKey(e => e.Aadid);

            entity.ToTable("MAP_Assessment_Adjustment");

            entity.Property(e => e.Aadid).HasColumnName("AADID");
            entity.Property(e => e.Aaiid).HasColumnName("AAIID");
            entity.Property(e => e.AdjustmentDate).HasColumnType("datetime");
            entity.Property(e => e.AdjustmentLine)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AdjustmentTypeId).HasColumnName("AdjustmentTypeID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Aai).WithMany(p => p.MapAssessmentAdjustments)
                .HasForeignKey(d => d.Aaiid)
                .HasConstraintName("FK_MAP_Assessment_Adjustment_MAP_Assessment_AssessmentItem");
        });

        modelBuilder.Entity<MapAssessmentAssessmentItem>(entity =>
        {
            entity.HasKey(e => e.Aaiid);

            entity.ToTable("MAP_Assessment_AssessmentItem");

            entity.HasIndex(e => e.AssessmentItemId, "IDX_AAI_AID");

            entity.HasIndex(e => e.Aarid, "IDX_MAAI_AARID_AIID_TA");

            entity.HasIndex(e => e.AssessmentItemId, "IDX_MAAI_AIID_AARID");

            entity.Property(e => e.Aaiid).HasColumnName("AAIID");
            entity.Property(e => e.Aarid).HasColumnName("AARID");
            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxBaseAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Aar).WithMany(p => p.MapAssessmentAssessmentItems)
                .HasForeignKey(d => d.Aarid)
                .HasConstraintName("FK_MAP_Assessment_AssessmentItem_MAP_Assessment_AssessmentRule");

            entity.HasOne(d => d.AssessmentItem).WithMany(p => p.MapAssessmentAssessmentItems)
                .HasForeignKey(d => d.AssessmentItemId)
                .HasConstraintName("FK_MAP_Assessment_AssessmentItem_Assessment_Items");

            entity.HasOne(d => d.PaymentStatus).WithMany(p => p.MapAssessmentAssessmentItems)
                .HasForeignKey(d => d.PaymentStatusId)
                .HasConstraintName("FK_MAP_Assessment_AssessmentItem_MST_PaymentStatus");
        });

        modelBuilder.Entity<MapAssessmentAssessmentRule>(entity =>
        {
            entity.HasKey(e => e.Aarid);

            entity.ToTable("MAP_Assessment_AssessmentRule");

            entity.HasIndex(e => e.AssessmentId, "IDX_AAR_AID");

            entity.HasIndex(e => e.AssessmentYear, "IDX_AAR_AY_AID");

            entity.HasIndex(e => new { e.AssetTypeId, e.AssetId }, "IDX_MAAR_ATID_AID_AID");

            entity.Property(e => e.Aarid).HasColumnName("AARID");
            entity.Property(e => e.AssessmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");
            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

            entity.HasOne(d => d.Assessment).WithMany(p => p.MapAssessmentAssessmentRules)
                .HasForeignKey(d => d.AssessmentId)
                .HasConstraintName("FK_MAP_Assessment_AssessmentRule_Assessment");
        });

        modelBuilder.Entity<MapAssessmentLateCharge>(entity =>
        {
            entity.HasKey(e => e.Alcid);

            entity.ToTable("MAP_Assessment_LateCharge");

            entity.Property(e => e.Alcid).HasColumnName("ALCID");
            entity.Property(e => e.Aaiid).HasColumnName("AAIID");
            entity.Property(e => e.ChargeDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Interest).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Penalty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MapAssessmentRuleAssessmentItem>(entity =>
        {
            entity.HasKey(e => e.Araiid);

            entity.ToTable("MAP_AssessmentRule_AssessmentItem");

            entity.Property(e => e.Araiid).HasColumnName("ARAIID");
            entity.Property(e => e.AssessmentItemId).HasColumnName("AssessmentItemID");
            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AssessmentItem).WithMany(p => p.MapAssessmentRuleAssessmentItems)
                .HasForeignKey(d => d.AssessmentItemId)
                .HasConstraintName("FK_MAP_AssessmentRule_AssessmentItem_Assessment_Items");

            entity.HasOne(d => d.AssessmentRule).WithMany(p => p.MapAssessmentRuleAssessmentItems)
                .HasForeignKey(d => d.AssessmentRuleId)
                .HasConstraintName("FK_MAP_AssessmentRule_AssessmentItem_Assessment_Rules");
        });

        modelBuilder.Entity<MapAssessmentRuleSettlementMethod>(entity =>
        {
            entity.HasKey(e => e.Arsmid);

            entity.ToTable("MAP_AssessmentRule_SettlementMethod");

            entity.Property(e => e.Arsmid).HasColumnName("ARSMID");
            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementMethodId).HasColumnName("SettlementMethodID");

            entity.HasOne(d => d.AssessmentRule).WithMany(p => p.MapAssessmentRuleSettlementMethods)
                .HasForeignKey(d => d.AssessmentRuleId)
                .HasConstraintName("FK_MAP_AssessmentRule_SettlementMethod_Assessment_Rules");

            entity.HasOne(d => d.SettlementMethod).WithMany(p => p.MapAssessmentRuleSettlementMethods)
                .HasForeignKey(d => d.SettlementMethodId)
                .HasConstraintName("FK_MAP_AssessmentRule_SettlementMethod_Settlement_Method");
        });

        modelBuilder.Entity<MapBuildingBuildingUnit>(entity =>
        {
            entity.HasKey(e => e.Bbuid);

            entity.ToTable("MAP_Building_BuildingUnit");

            entity.Property(e => e.Bbuid).HasColumnName("BBUID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.BuildingUnitId).HasColumnName("BuildingUnitID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Building).WithMany(p => p.MapBuildingBuildingUnits)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_MAP_Building_BuildingUnit_Building");

            entity.HasOne(d => d.BuildingUnit).WithMany(p => p.MapBuildingBuildingUnits)
                .HasForeignKey(d => d.BuildingUnitId)
                .HasConstraintName("FK_MAP_Building_BuildingUnit_Building_Unit");
        });

        modelBuilder.Entity<MapBuildingLand>(entity =>
        {
            entity.HasKey(e => e.Blid);

            entity.ToTable("MAP_Building_Land");

            entity.Property(e => e.Blid).HasColumnName("BLID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LandId).HasColumnName("LandID");

            entity.HasOne(d => d.Building).WithMany(p => p.MapBuildingLands)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_MAP_Building_Land_Building");

            entity.HasOne(d => d.Land).WithMany(p => p.MapBuildingLands)
                .HasForeignKey(d => d.LandId)
                .HasConstraintName("FK_MAP_Building_Land_Land");
        });

        modelBuilder.Entity<MapBusinessBuilding>(entity =>
        {
            entity.HasKey(e => e.Bbid);

            entity.ToTable("MAP_Business_Building");

            entity.Property(e => e.Bbid).HasColumnName("BBID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.BuildingUnitId).HasColumnName("BuildingUnitID");
            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Building).WithMany(p => p.MapBusinessBuildings)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_MAP_Business_Building_Building");

            entity.HasOne(d => d.Business).WithMany(p => p.MapBusinessBuildings)
                .HasForeignKey(d => d.BusinessId)
                .HasConstraintName("FK_MAP_Business_Building_Business");
        });

        modelBuilder.Entity<MapCertificateCustomField>(entity =>
        {
            entity.HasKey(e => e.Ccfid);

            entity.ToTable("MAP_Certificate_CustomField");

            entity.Property(e => e.Ccfid).HasColumnName("CCFID");
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Ctfid).HasColumnName("CTFID");
            entity.Property(e => e.FieldValue).IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Certificate).WithMany(p => p.MapCertificateCustomFields)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("FK_MAP_Certificate_CustomField_Certificates");

            entity.HasOne(d => d.Ctf).WithMany(p => p.MapCertificateCustomFields)
                .HasForeignKey(d => d.Ctfid)
                .HasConstraintName("FK_MAP_Certificate_CustomField_MAP_CertificateType_Field");
        });

        modelBuilder.Entity<MapCertificateGenerate>(entity =>
        {
            entity.HasKey(e => e.Cgid);

            entity.ToTable("MAP_Certificate_Generate");

            entity.Property(e => e.Cgid).HasColumnName("CGID");
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CertificatePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.Location)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Certificate).WithMany(p => p.MapCertificateGenerates)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("FK_MAP_Certificate_Generate_Certificates");
        });

        modelBuilder.Entity<MapCertificateGenerateField>(entity =>
        {
            entity.HasKey(e => e.Cgfid);

            entity.ToTable("MAP_Certificate_Generate_Field");

            entity.Property(e => e.Cgfid).HasColumnName("CGFID");
            entity.Property(e => e.Cgid).HasColumnName("CGID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.FieldValue).IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Pfid).HasColumnName("PFID");

            entity.HasOne(d => d.Cg).WithMany(p => p.MapCertificateGenerateFields)
                .HasForeignKey(d => d.Cgid)
                .HasConstraintName("FK_MAP_Certificate_Generate_Field_MAP_Certificate_Generate");
        });

        modelBuilder.Entity<MapCertificateIssue>(entity =>
        {
            entity.HasKey(e => e.Ciid);

            entity.ToTable("MAP_Certificate_Issue");

            entity.Property(e => e.Ciid).HasColumnName("CIID");
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Certificate).WithMany(p => p.MapCertificateIssues)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("FK_MAP_Certificate_Issue_Certificates");
        });

        modelBuilder.Entity<MapCertificateRevoke>(entity =>
        {
            entity.HasKey(e => e.Crid);

            entity.ToTable("MAP_Certificate_Revoke");

            entity.Property(e => e.Crid).HasColumnName("CRID");
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Certificate).WithMany(p => p.MapCertificateRevokes)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("FK_MAP_Certificate_Revoke_Certificates");
        });

        modelBuilder.Entity<MapCertificateSeal>(entity =>
        {
            entity.HasKey(e => e.Csid);

            entity.ToTable("MAP_Certificate_Seal");

            entity.Property(e => e.Csid).HasColumnName("CSID");
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Certificate).WithMany(p => p.MapCertificateSeals)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("FK_MAP_Certificate_Seal_Certificates");
        });

        modelBuilder.Entity<MapCertificateSignDigital>(entity =>
        {
            entity.HasKey(e => e.Csdid);

            entity.ToTable("MAP_Certificate_SignDigital");

            entity.Property(e => e.Csdid).HasColumnName("CSDID");
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Certificate).WithMany(p => p.MapCertificateSignDigitals)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("FK_MAP_Certificate_SignDigital_Certificates");
        });

        modelBuilder.Entity<MapCertificateSignVisible>(entity =>
        {
            entity.HasKey(e => e.Csvid);

            entity.ToTable("MAP_Certificate_SignVisible");

            entity.Property(e => e.Csvid).HasColumnName("CSVID");
            entity.Property(e => e.AdditionalSignatureLocation).IsUnicode(false);
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentWidth)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SignDate).HasColumnType("datetime");
            entity.Property(e => e.SignSourceId).HasColumnName("SignSourceID");
            entity.Property(e => e.StageId).HasColumnName("StageID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<MapCertificateStage>(entity =>
        {
            entity.HasKey(e => e.Csid);

            entity.ToTable("MAP_Certificate_Stages");

            entity.Property(e => e.Csid).HasColumnName("CSID");
            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.StageId).HasColumnName("StageID");

            entity.HasOne(d => d.Certificate).WithMany(p => p.MapCertificateStages)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("FK_MAP_Certificate_Stages_Certificates");
        });

        modelBuilder.Entity<MapCertificateTypeField>(entity =>
        {
            entity.HasKey(e => e.Ctfid).HasName("PK_MST_ReceiverOption");

            entity.ToTable("MAP_CertificateType_Field");

            entity.Property(e => e.Ctfid).HasColumnName("CTFID");
            entity.Property(e => e.CertificateTypeId).HasColumnName("CertificateTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FieldName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FieldSlug)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.FieldTypeId).HasColumnName("FieldTypeID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CertificateType).WithMany(p => p.MapCertificateTypeFields)
                .HasForeignKey(d => d.CertificateTypeId)
                .HasConstraintName("FK_MAP_CertificateType_Field_Certificate_Types");

            entity.HasOne(d => d.FieldType).WithMany(p => p.MapCertificateTypeFields)
                .HasForeignKey(d => d.FieldTypeId)
                .HasConstraintName("FK_MAP_CertificateType_Field_MST_FieldType");
        });

        modelBuilder.Entity<MapCertificateTypeItem>(entity =>
        {
            entity.HasKey(e => e.Ctiid);

            entity.ToTable("MAP_CertificateType_Items");

            entity.Property(e => e.Ctiid).HasColumnName("CTIID");
            entity.Property(e => e.CertificateTypeId).HasColumnName("CertificateTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MapCertificateValidate>(entity =>
        {
            entity.HasKey(e => e.Cvid);

            entity.ToTable("MAP_Certificate_Validate");

            entity.Property(e => e.Cvid).HasColumnName("CVID");
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Certificate).WithMany(p => p.MapCertificateValidates)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("FK_MAP_Certificate_Validate_Certificates");
        });

        modelBuilder.Entity<MapCompanyAddressInformation>(entity =>
        {
            entity.HasKey(e => e.Caiid);

            entity.ToTable("MAP_Company_AddressInformation");

            entity.Property(e => e.Caiid).HasColumnName("CAIID");
            entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AddressType).WithMany(p => p.MapCompanyAddressInformations)
                .HasForeignKey(d => d.AddressTypeId)
                .HasConstraintName("FK_MAP_Company_AddressInformation_Address_Types");

            entity.HasOne(d => d.Building).WithMany(p => p.MapCompanyAddressInformations)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_MAP_Company_AddressInformation_Building");

            entity.HasOne(d => d.Company).WithMany(p => p.MapCompanyAddressInformations)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_MAP_Company_AddressInformation_Company");
        });

        modelBuilder.Entity<MapDirectoratesRevenueStream>(entity =>
        {
            entity.HasKey(e => e.Drsid).HasName("PK_MAP_Directorate_RevenueStream");

            entity.ToTable("MAP_Directorates_RevenueStream");

            entity.Property(e => e.Drsid).HasColumnName("DRSID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DirectorateId).HasColumnName("DirectorateID");
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");

            entity.HasOne(d => d.Directorate).WithMany(p => p.MapDirectoratesRevenueStreams)
                .HasForeignKey(d => d.DirectorateId)
                .HasConstraintName("FK_MAP_Directorates_RevenueStream_Directorates");

            entity.HasOne(d => d.RevenueStream).WithMany(p => p.MapDirectoratesRevenueStreams)
                .HasForeignKey(d => d.RevenueStreamId)
                .HasConstraintName("FK_MAP_Directorates_RevenueStream_Revenue_Stream");
        });

        modelBuilder.Entity<MapGovernmentAddressInformation>(entity =>
        {
            entity.HasKey(e => e.Gaiid);

            entity.ToTable("MAP_Government_AddressInformation");

            entity.Property(e => e.Gaiid).HasColumnName("GAIID");
            entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GovernmentId).HasColumnName("GovernmentID");

            entity.HasOne(d => d.AddressType).WithMany(p => p.MapGovernmentAddressInformations)
                .HasForeignKey(d => d.AddressTypeId)
                .HasConstraintName("FK_MAP_Government_AddressInformation_Address_Types");

            entity.HasOne(d => d.Building).WithMany(p => p.MapGovernmentAddressInformations)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_MAP_Government_AddressInformation_Building");

            entity.HasOne(d => d.Government).WithMany(p => p.MapGovernmentAddressInformations)
                .HasForeignKey(d => d.GovernmentId)
                .HasConstraintName("FK_MAP_Government_AddressInformation_Government");
        });

        modelBuilder.Entity<MapIndividualAddressInformation>(entity =>
        {
            entity.HasKey(e => e.Iaiid);

            entity.ToTable("MAP_Individual_AddressInformation");

            entity.Property(e => e.Iaiid).HasColumnName("IAIID");
            entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IndividualId).HasColumnName("IndividualID");

            entity.HasOne(d => d.AddressType).WithMany(p => p.MapIndividualAddressInformations)
                .HasForeignKey(d => d.AddressTypeId)
                .HasConstraintName("FK_MAP_Individual_AddressInformation_Address_Types");

            entity.HasOne(d => d.Building).WithMany(p => p.MapIndividualAddressInformations)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_MAP_Individual_AddressInformation_Building");

            entity.HasOne(d => d.Individual).WithMany(p => p.MapIndividualAddressInformations)
                .HasForeignKey(d => d.IndividualId)
                .HasConstraintName("FK_MAP_Individual_AddressInformation_Individual");
        });

        modelBuilder.Entity<MapMdaserviceMdaserviceItem>(entity =>
        {
            entity.HasKey(e => e.Msmsiid);

            entity.ToTable("MAP_MDAService_MDAServiceItem");

            entity.HasIndex(e => e.MdaserviceId, "IDX_MDAServiceItem_mdaservice");

            entity.Property(e => e.Msmsiid).HasColumnName("MSMSIID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MdaserviceId).HasColumnName("MDAServiceID");
            entity.Property(e => e.MdaserviceItemId).HasColumnName("MDAServiceItemID");

            entity.HasOne(d => d.Mdaservice).WithMany(p => p.MapMdaserviceMdaserviceItems)
                .HasForeignKey(d => d.MdaserviceId)
                .HasConstraintName("FK_MAP_MDAService_MDAServiceItem_MDA_Services");

            entity.HasOne(d => d.MdaserviceItem).WithMany(p => p.MapMdaserviceMdaserviceItems)
                .HasForeignKey(d => d.MdaserviceItemId)
                .HasConstraintName("FK_MAP_MDAService_MDAServiceItem_MDAService_Items");
        });

        modelBuilder.Entity<MapMdaserviceSettlementMethod>(entity =>
        {
            entity.HasKey(e => e.Arsmid);

            entity.ToTable("MAP_MDAService_SettlementMethod");

            entity.HasIndex(e => e.MdaserviceId, "IDX_MDA_SMTHD");

            entity.Property(e => e.Arsmid).HasColumnName("ARSMID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MdaserviceId).HasColumnName("MDAServiceID");
            entity.Property(e => e.SettlementMethodId).HasColumnName("SettlementMethodID");

            entity.HasOne(d => d.Mdaservice).WithMany(p => p.MapMdaserviceSettlementMethods)
                .HasForeignKey(d => d.MdaserviceId)
                .HasConstraintName("FK_MAP_MDAService_SettlementMethod_MDA_Services");

            entity.HasOne(d => d.SettlementMethod).WithMany(p => p.MapMdaserviceSettlementMethods)
                .HasForeignKey(d => d.SettlementMethodId)
                .HasConstraintName("FK_MAP_MDAService_SettlementMethod_Settlement_Method");
        });

        modelBuilder.Entity<MapPaymentAccountOperation>(entity =>
        {
            entity.HasKey(e => e.Poaid);

            entity.ToTable("MAP_PaymentAccount_Operation");

            entity.Property(e => e.Poaid).HasColumnName("POAID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FromSettlementMethodId).HasColumnName("From_SettlementMethodID");
            entity.Property(e => e.FromTaxPayerId).HasColumnName("From_TaxPayerID");
            entity.Property(e => e.FromTaxPayerTypeId).HasColumnName("From_TaxPayerTypeID");
            entity.Property(e => e.OperationDate).HasColumnType("datetime");
            entity.Property(e => e.OperationTypeId).HasColumnName("OperationTypeID");
            entity.Property(e => e.PoaaccountId).HasColumnName("POAAccountId");
            entity.Property(e => e.ToBillId).HasColumnName("To_BillID");
            entity.Property(e => e.ToBillTypeId).HasColumnName("To_BillTypeID");
            entity.Property(e => e.ToTaxPayerId).HasColumnName("To_TaxPayerID");
            entity.Property(e => e.ToTaxPayerTypeId).HasColumnName("To_TaxPayerTypeID");
        });

        modelBuilder.Entity<MapServiceBillAdjustment>(entity =>
        {
            entity.HasKey(e => e.Sadid);

            entity.ToTable("MAP_ServiceBill_Adjustment");

            entity.Property(e => e.Sadid).HasColumnName("SADID");
            entity.Property(e => e.AdjustmentDate).HasColumnType("datetime");
            entity.Property(e => e.AdjustmentLine)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AdjustmentTypeId).HasColumnName("AdjustmentTypeID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Sbsiid).HasColumnName("SBSIID");

            entity.HasOne(d => d.Sbsi).WithMany(p => p.MapServiceBillAdjustments)
                .HasForeignKey(d => d.Sbsiid)
                .HasConstraintName("FK_MAP_ServiceBill_Adjustment_MAP_ServiceBill_MDAServiceItem");
        });

        modelBuilder.Entity<MapServiceBillLateCharge>(entity =>
        {
            entity.HasKey(e => e.Slcid);

            entity.ToTable("MAP_ServiceBill_LateCharge");

            entity.Property(e => e.Slcid).HasColumnName("SLCID");
            entity.Property(e => e.ChargeDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Interest).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Penalty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sbsiid).HasColumnName("SBSIID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Sbsi).WithMany(p => p.MapServiceBillLateCharges)
                .HasForeignKey(d => d.Sbsiid)
                .HasConstraintName("FK_MAP_ServiceBill_LateCharge_MAP_ServiceBill_MDAServiceItem");
        });

        modelBuilder.Entity<MapServiceBillMdaservice>(entity =>
        {
            entity.HasKey(e => e.Sbsid);

            entity.ToTable("MAP_ServiceBill_MDAService");

            entity.HasIndex(e => e.ServiceBillId, "IDX_SMS_SBID");

            entity.Property(e => e.Sbsid).HasColumnName("SBSID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MdaserviceId).HasColumnName("MDAServiceID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServiceBillId).HasColumnName("ServiceBillID");

            entity.HasOne(d => d.Mdaservice).WithMany(p => p.MapServiceBillMdaservices)
                .HasForeignKey(d => d.MdaserviceId)
                .HasConstraintName("FK_MAP_ServiceBill_MDAService_MDA_Services");

            entity.HasOne(d => d.ServiceBill).WithMany(p => p.MapServiceBillMdaservices)
                .HasForeignKey(d => d.ServiceBillId)
                .HasConstraintName("FK_MAP_ServiceBill_MDAService_ServiceBill");
        });

        modelBuilder.Entity<MapServiceBillMdaserviceItem>(entity =>
        {
            entity.HasKey(e => e.Sbsiid);

            entity.ToTable("MAP_ServiceBill_MDAServiceItem");

            entity.HasIndex(e => e.Sbsid, "IDX_SB_MSI_SBSID");

            entity.HasIndex(e => e.MdaserviceItemId, "IDX_SB_MSI_SIID");

            entity.Property(e => e.Sbsiid).HasColumnName("SBSIID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MdaserviceItemId).HasColumnName("MDAServiceItemID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sbsid).HasColumnName("SBSID");
            entity.Property(e => e.ServiceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServiceBaseAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MdaserviceItem).WithMany(p => p.MapServiceBillMdaserviceItems)
                .HasForeignKey(d => d.MdaserviceItemId)
                .HasConstraintName("FK_MAP_ServiceBill_MDAServiceItem_MDA_Service_Items");

            entity.HasOne(d => d.Sbs).WithMany(p => p.MapServiceBillMdaserviceItems)
                .HasForeignKey(d => d.Sbsid)
                .HasConstraintName("FK_MAP_ServiceBill_MDAServiceItem_MAP_ServiceBill_MDAService");
        });

        modelBuilder.Entity<MapSettlementSettlementItem>(entity =>
        {
            entity.HasKey(e => e.Siid);

            entity.ToTable("MAP_Settlement_SettlementItem");

            entity.HasIndex(e => e.Aaiid, "IDX_SSI_AAIID_iSID_iSAMT");

            entity.HasIndex(e => e.Sbsiid, "IDX_SSI_SBSIID_SID_SA");

            entity.HasIndex(e => e.SettlementId, "IDX_SSI_SID_AID_SA");

            entity.Property(e => e.Siid).HasColumnName("SIID");
            entity.Property(e => e.Aaiid).HasColumnName("AAIID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Sbsiid).HasColumnName("SBSIID");
            entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Aai).WithMany(p => p.MapSettlementSettlementItems)
                .HasForeignKey(d => d.Aaiid)
                .HasConstraintName("FK_MAP_Settlement_SettlementItem_MAP_Assessment_AssessmentItem");

            entity.HasOne(d => d.Sbsi).WithMany(p => p.MapSettlementSettlementItems)
                .HasForeignKey(d => d.Sbsiid)
                .HasConstraintName("FK_MAP_Settlement_SettlementItem_MAP_ServiceBill_MDAServiceItem");

            entity.HasOne(d => d.Settlement).WithMany(p => p.MapSettlementSettlementItems)
                .HasForeignKey(d => d.SettlementId)
                .HasConstraintName("FK_MAP_Settlement_SettlementItem_Settlement");
        });

        modelBuilder.Entity<MapSpecialAddressInformation>(entity =>
        {
            entity.HasKey(e => e.Saiid);

            entity.ToTable("MAP_Special_AddressInformation");

            entity.Property(e => e.Saiid).HasColumnName("SAIID");
            entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SpecialId).HasColumnName("SpecialID");

            entity.HasOne(d => d.AddressType).WithMany(p => p.MapSpecialAddressInformations)
                .HasForeignKey(d => d.AddressTypeId)
                .HasConstraintName("FK_MAP_Special_AddressInformation_Address_Types");

            entity.HasOne(d => d.Building).WithMany(p => p.MapSpecialAddressInformations)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_MAP_Special_AddressInformation_Building");

            entity.HasOne(d => d.Special).WithMany(p => p.MapSpecialAddressInformations)
                .HasForeignKey(d => d.SpecialId)
                .HasConstraintName("FK_MAP_Special_AddressInformation_Special");
        });

        modelBuilder.Entity<MapTaxOfficeTarget>(entity =>
        {
            entity.HasKey(e => e.Totid);

            entity.ToTable("MAP_TaxOffice_Target");

            entity.Property(e => e.Totid).HasColumnName("TOTID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.TargetAmount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");

            entity.HasOne(d => d.RevenueStream).WithMany(p => p.MapTaxOfficeTargets)
                .HasForeignKey(d => d.RevenueStreamId)
                .HasConstraintName("FK_MAP_TaxOffice_Target_Revenue_Stream");

            entity.HasOne(d => d.TaxOffice).WithMany(p => p.MapTaxOfficeTargets)
                .HasForeignKey(d => d.TaxOfficeId)
                .HasConstraintName("FK_MAP_TaxOffice_Target_Tax_Offices");
        });

        modelBuilder.Entity<MapTaxOfficerTarget>(entity =>
        {
            entity.HasKey(e => e.Totid);

            entity.ToTable("MAP_TaxOfficer_Target");

            entity.Property(e => e.Totid).HasColumnName("TOTID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.TargetAmount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficerId).HasColumnName("TaxOfficerID");

            entity.HasOne(d => d.RevenueStream).WithMany(p => p.MapTaxOfficerTargets)
                .HasForeignKey(d => d.RevenueStreamId)
                .HasConstraintName("FK_MAP_TaxOfficer_Target_Revenue_Stream");

            entity.HasOne(d => d.TaxOffice).WithMany(p => p.MapTaxOfficerTargets)
                .HasForeignKey(d => d.TaxOfficeId)
                .HasConstraintName("FK_MAP_TaxOfficer_Target_Tax_Offices");
        });

        modelBuilder.Entity<MapTaxPayerAsset>(entity =>
        {
            entity.HasKey(e => e.Tpaid);

            entity.ToTable("MAP_TaxPayer_Asset");

            entity.HasIndex(e => new { e.AssetTypeId, e.AssetId }, "IDX_ATA");

            entity.HasIndex(e => new { e.AssetId, e.Active }, "IDX_MTPA_AID_A_TPTID_TPID_ATID");

            entity.HasIndex(e => e.Active, "IDX_MTPA_A_TPTID_TPID_ATID_AID");

            entity.Property(e => e.Tpaid).HasColumnName("TPAID");
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.BuildingUnitId).HasColumnName("BuildingUnitID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerRoleId).HasColumnName("TaxPayerRoleID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.MapTaxPayerAssets)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_MAP_TaxPayer_Asset_Asset_Types");

            entity.HasOne(d => d.TaxPayer).WithMany(p => p.MapTaxPayerAssets)
                .HasForeignKey(d => d.TaxPayerId)
                .HasConstraintName("FK_MAP_TaxPayer_Asset_TaxPayer_Types");

            entity.HasOne(d => d.TaxPayerRole).WithMany(p => p.MapTaxPayerAssets)
                .HasForeignKey(d => d.TaxPayerRoleId)
                .HasConstraintName("FK_MAP_TaxPayer_Asset_TaxPayer_Roles");
        });

        modelBuilder.Entity<MapTaxPayerAssetProfile>(entity =>
        {
            entity.HasKey(e => e.Tpapid);

            entity.ToTable("MAP_TaxPayer_Asset_Profile");

            entity.HasIndex(e => e.Tpaid, "IDX_TPAP_PROF");

            entity.HasIndex(e => e.ProfileId, "IDX_TPA_Profile");

            entity.Property(e => e.Tpapid).HasColumnName("TPAPID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.Tpaid).HasColumnName("TPAID");

            entity.HasOne(d => d.Profile).WithMany(p => p.MapTaxPayerAssetProfiles)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_MAP_TaxPayer_Asset_Profile_Profiles");

            entity.HasOne(d => d.Tpa).WithMany(p => p.MapTaxPayerAssetProfiles)
                .HasForeignKey(d => d.Tpaid)
                .HasConstraintName("FK_MAP_TaxPayer_Asset_Profile_MAP_TaxPayer_Asset");
        });

        modelBuilder.Entity<MapTaxPayerAssetProfilePt>(entity =>
        {
            entity.HasKey(e => e.Tpapptid).HasName("MAP_TaxPayer_Asset_Profile_TempPT");

            entity.ToTable("MAP_TaxPayer_Asset_Profile_PT");

            entity.HasIndex(e => e.Tpaid, "IDX_A_P_PT");

            entity.Property(e => e.Tpapptid).HasColumnName("TPAPPTID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.Tpaid).HasColumnName("TPAID");
        });

        modelBuilder.Entity<MapTaxPayerDocument>(entity =>
        {
            entity.HasKey(e => e.Tpdid);

            entity.ToTable("MAP_TaxPayer_Document", tb => tb.HasTrigger("TRG_GenerateDocumentRef"));

            entity.Property(e => e.Tpdid).HasColumnName("TPDID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentPath)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.DocumentRefNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
        });

        modelBuilder.Entity<MapTaxPayerMessage>(entity =>
        {
            entity.HasKey(e => e.Tpmid);

            entity.ToTable("MAP_TaxPayer_Message");

            entity.Property(e => e.Tpmid).HasColumnName("TPMID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Message).IsUnicode(false);
            entity.Property(e => e.MessageDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiverStaffId).HasColumnName("Receiver_StaffID");
            entity.Property(e => e.ReceiverTaxPayerId).HasColumnName("Receiver_TaxPayerID");
            entity.Property(e => e.ReceiverTaxPayerTypeId).HasColumnName("Receiver_TaxPayerTypeID");
            entity.Property(e => e.SenderStaffId).HasColumnName("Sender_StaffID");
            entity.Property(e => e.SenderTaxPayerId).HasColumnName("Sender_TaxPayerID");
            entity.Property(e => e.SenderTaxPayerTypeId).HasColumnName("Sender_TaxPayerTypeID");
        });

        modelBuilder.Entity<MapTaxPayerMessageDocument>(entity =>
        {
            entity.HasKey(e => e.Tpmdid);

            entity.ToTable("MAP_TaxPayer_Message_Document");

            entity.Property(e => e.Tpmdid).HasColumnName("TPMDID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentName)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.DocumentPath)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Tpmid).HasColumnName("TPMID");

            entity.HasOne(d => d.Tpm).WithMany(p => p.MapTaxPayerMessageDocuments)
                .HasForeignKey(d => d.Tpmid)
                .HasConstraintName("FK_MAP_TaxPayer_Message_Document_MAP_TaxPayer_Message");
        });

        modelBuilder.Entity<MapTaxPayerReview>(entity =>
        {
            entity.HasKey(e => e.Tprid);

            entity.ToTable("MAP_TaxPayer_Review");

            entity.Property(e => e.Tprid).HasColumnName("TPRID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReviewDate).HasColumnType("datetime");
            entity.Property(e => e.ReviewStatusId).HasColumnName("ReviewStatusID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<MapTccrequestGenerate>(entity =>
        {
            entity.HasKey(e => e.Rgid);

            entity.ToTable("MAP_TCCRequest_Generate");

            entity.Property(e => e.Rgid).HasColumnName("RGID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.Location)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestGenerates)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_Generate_TCC_Request");
        });

        modelBuilder.Entity<MapTccrequestGenerateField>(entity =>
        {
            entity.HasKey(e => e.Rgfid);

            entity.ToTable("MAP_TCCRequest_Generate_Field");

            entity.Property(e => e.Rgfid).HasColumnName("RGFID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.FieldValue).IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Pfid).HasColumnName("PFID");
            entity.Property(e => e.Rgid).HasColumnName("RGID");

            entity.HasOne(d => d.Rg).WithMany(p => p.MapTccrequestGenerateFields)
                .HasForeignKey(d => d.Rgid)
                .HasConstraintName("FK_MAP_TCCRequest_Generate_Field_MAP_TCCRequest_Generate");
        });

        modelBuilder.Entity<MapTccrequestGenerateTccdetail>(entity =>
        {
            entity.HasKey(e => e.GtccdetailId);

            entity.ToTable("MAP_TCCRequest_GenerateTCCDetail");

            entity.Property(e => e.GtccdetailId).HasColumnName("GTCCDetailID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestGenerateTccdetails)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_GenerateTCCDetail_TCC_Request");
        });

        modelBuilder.Entity<MapTccrequestIncomeStream>(entity =>
        {
            entity.HasKey(e => e.Trisid);

            entity.ToTable("MAP_TCCRequest_IncomeStream");

            entity.Property(e => e.Trisid).HasColumnName("TRISID");
            entity.Property(e => e.BusinessAddress).IsUnicode(false);
            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessOperationId).HasColumnName("BusinessOperationID");
            entity.Property(e => e.BusinessTypeId).HasColumnName("BusinessTypeID");
            entity.Property(e => e.ContactPersonName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.TaxPayerRoleId).HasColumnName("TaxPayerRoleID");
            entity.Property(e => e.TccrequestId).HasColumnName("TCCRequestID");
            entity.Property(e => e.TotalIncomeEarned).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MapTccrequestIssue>(entity =>
        {
            entity.HasKey(e => e.Riid);

            entity.ToTable("MAP_TCCRequest_Issue");

            entity.Property(e => e.Riid).HasColumnName("RIID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestIssues)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_Issue_TCC_Request");
        });

        modelBuilder.Entity<MapTccrequestNote>(entity =>
        {
            entity.HasKey(e => e.Rnid);

            entity.ToTable("MAP_TCCRequest_Notes");

            entity.Property(e => e.Rnid).HasColumnName("RNID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.NotesDate).HasColumnType("datetime");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.StageId).HasColumnName("StageID");
        });

        modelBuilder.Entity<MapTccrequestNotesDocument>(entity =>
        {
            entity.HasKey(e => e.Rndid);

            entity.ToTable("MAP_TCCRequest_Notes_Document");

            entity.Property(e => e.Rndid).HasColumnName("RNDID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentName)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.DocumentPath)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Rnid).HasColumnName("RNID");

            entity.HasOne(d => d.Rn).WithMany(p => p.MapTccrequestNotesDocuments)
                .HasForeignKey(d => d.Rnid)
                .HasConstraintName("FK_MAP_TCCRequest_Notes_Document_MAP_TCCRequest_Notes");
        });

        modelBuilder.Entity<MapTccrequestPrepareTccdraft>(entity =>
        {
            entity.HasKey(e => e.PtccdraftId);

            entity.ToTable("MAP_TCCRequest_PrepareTCCDraft");

            entity.Property(e => e.PtccdraftId).HasColumnName("PTCCDraftID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestPrepareTccdrafts)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_PrepareTCCDraft_TCC_Request");
        });

        modelBuilder.Entity<MapTccrequestRevoke>(entity =>
        {
            entity.HasKey(e => e.Rrid);

            entity.ToTable("MAP_TCCRequest_Revoke");

            entity.Property(e => e.Rrid).HasColumnName("RRID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestRevokes)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_Revoke_TCC_Request");
        });

        modelBuilder.Entity<MapTccrequestSeal>(entity =>
        {
            entity.HasKey(e => e.Rsid);

            entity.ToTable("MAP_TCCRequest_Seal");

            entity.Property(e => e.Rsid).HasColumnName("RSID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestSeals)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_Seal_TCC_Request");
        });

        modelBuilder.Entity<MapTccrequestSignDigital>(entity =>
        {
            entity.HasKey(e => e.Rsdid);

            entity.ToTable("MAP_TCCRequest_SignDigital");

            entity.Property(e => e.Rsdid).HasColumnName("RSDID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestSignDigitals)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_SignDigital_TCC_Request");
        });

        modelBuilder.Entity<MapTccrequestSignVisible>(entity =>
        {
            entity.HasKey(e => e.Rsvid);

            entity.ToTable("MAP_TCCRequest_SignVisible");

            entity.Property(e => e.Rsvid).HasColumnName("RSVID");
            entity.Property(e => e.AdditionalSignatureLocation).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentWidth)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.SignDate).HasColumnType("datetime");
            entity.Property(e => e.SignSourceId).HasColumnName("SignSourceID");
            entity.Property(e => e.StageId).HasColumnName("StageID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<MapTccrequestStage>(entity =>
        {
            entity.HasKey(e => e.Rsid);

            entity.ToTable("MAP_TCCRequest_Stages");

            entity.Property(e => e.Rsid).HasColumnName("RSID");
            entity.Property(e => e.ActionName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.ControllerName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.StageId).HasColumnName("StageID");
        });

        modelBuilder.Entity<MapTccrequestValidate>(entity =>
        {
            entity.HasKey(e => e.Rvid);

            entity.ToTable("MAP_TCCRequest_Validate");

            entity.Property(e => e.Rvid).HasColumnName("RVID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestValidates)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_Validate_TCC_Request");
        });

        modelBuilder.Entity<MapTccrequestValidateTaxPayerIncome>(entity =>
        {
            entity.HasKey(e => e.VtpincomeId);

            entity.ToTable("MAP_TCCRequest_ValidateTaxPayerIncome");

            entity.Property(e => e.VtpincomeId).HasColumnName("VTPIncomeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestValidateTaxPayerIncomes)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_ValidateTaxPayerIncome_TCC_Request");
        });

        modelBuilder.Entity<MapTccrequestValidateTaxPayerInformation>(entity =>
        {
            entity.HasKey(e => e.VtpinformationId);

            entity.ToTable("MAP_TCCRequest_ValidateTaxPayerInformation");

            entity.Property(e => e.VtpinformationId).HasColumnName("VTPInformationID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.HasOne(d => d.Request).WithMany(p => p.MapTccrequestValidateTaxPayerInformations)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_MAP_TCCRequest_ValidateTaxPayerInformation_TCC_Request");
        });

        modelBuilder.Entity<MapTreasuryReceiptSettlement>(entity =>
        {
            entity.HasKey(e => e.Rsid);

            entity.ToTable("MAP_TreasuryReceipt_Settlement");

            entity.Property(e => e.Rsid).HasColumnName("RSID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");
            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");

            entity.HasOne(d => d.Receipt).WithMany(p => p.MapTreasuryReceiptSettlements)
                .HasForeignKey(d => d.ReceiptId)
                .HasConstraintName("FK_MAP_TreasuryReceipt_Settlement_Treasury_Receipt");

            entity.HasOne(d => d.Settlement).WithMany(p => p.MapTreasuryReceiptSettlements)
                .HasForeignKey(d => d.SettlementId)
                .HasConstraintName("FK_MAP_TreasuryReceipt_Settlement_Settlement");
        });

        modelBuilder.Entity<MaritalStatus>(entity =>
        {
            entity.ToTable("MaritalStatus");

            entity.Property(e => e.MaritalStatusId)
                .ValueGeneratedNever()
                .HasColumnName("MaritalStatusID");
            entity.Property(e => e.MaritalStatusName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MdaService>(entity =>
        {
            entity.ToTable("MDA_Services", tb => tb.HasTrigger("TRG_GenerateMDAServiceCode"));

            entity.Property(e => e.MdaserviceId).HasColumnName("MDAServiceID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MdaserviceCode)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MDAServiceCode");
            entity.Property(e => e.MdaserviceName)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasColumnName("MDAServiceName");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentFrequencyId).HasColumnName("PaymentFrequencyID");
            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.RuleRunId).HasColumnName("RuleRunID");
            entity.Property(e => e.ServiceAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.PaymentFrequency).WithMany(p => p.MdaServices)
                .HasForeignKey(d => d.PaymentFrequencyId)
                .HasConstraintName("FK_MDA_Services_Payment_Frequency");

            entity.HasOne(d => d.PaymentOption).WithMany(p => p.MdaServices)
                .HasForeignKey(d => d.PaymentOptionId)
                .HasConstraintName("FK_MDA_Services_Payment_Options");

            entity.HasOne(d => d.RuleRun).WithMany(p => p.MdaServices)
                .HasForeignKey(d => d.RuleRunId)
                .HasConstraintName("FK_MDA_Services_MST_RuleRun");
        });

        modelBuilder.Entity<MdaServiceItem>(entity =>
        {
            entity.ToTable("MDA_Service_Items", tb => tb.HasTrigger("TRG_GenerateMDAServiceItemRefNo"));

            entity.Property(e => e.MdaserviceItemId).HasColumnName("MDAServiceItemID");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.AssessmentItemCategoryId).HasColumnName("AssessmentItemCategoryID");
            entity.Property(e => e.AssessmentItemSubCategoryId).HasColumnName("AssessmentItemSubCategoryID");
            entity.Property(e => e.ComputationId).HasColumnName("ComputationID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MdaserviceItemName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MDAServiceItemName");
            entity.Property(e => e.MdaserviceItemReferenceNo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MDAServiceItemReferenceNo");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.RevenueSubStreamId).HasColumnName("RevenueSubStreamID");
            entity.Property(e => e.ServiceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServiceBaseAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Agency).WithMany(p => p.MdaServiceItems)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_MDA_Service_Items_Agencies");

            entity.HasOne(d => d.AssessmentItemCategory).WithMany(p => p.MdaServiceItems)
                .HasForeignKey(d => d.AssessmentItemCategoryId)
                .HasConstraintName("FK_MDA_Service_Items_Assessment_Item_Category");

            entity.HasOne(d => d.AssessmentItemSubCategory).WithMany(p => p.MdaServiceItems)
                .HasForeignKey(d => d.AssessmentItemSubCategoryId)
                .HasConstraintName("FK_MDA_Service_Items_Assessment_Item_SubCategory");

            entity.HasOne(d => d.Computation).WithMany(p => p.MdaServiceItems)
                .HasForeignKey(d => d.ComputationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MDA_Service_Items_MST_Computation");

            entity.HasOne(d => d.RevenueStream).WithMany(p => p.MdaServiceItems)
                .HasForeignKey(d => d.RevenueStreamId)
                .HasConstraintName("FK_MDA_Service_Items_Revenue_Stream");

            entity.HasOne(d => d.RevenueSubStream).WithMany(p => p.MdaServiceItems)
                .HasForeignKey(d => d.RevenueSubStreamId)
                .HasConstraintName("FK_MDA_Service_Items_Revenue_SubStream");
        });

        modelBuilder.Entity<MstCertificateStage>(entity =>
        {
            entity.HasKey(e => e.CertificateStageId);

            entity.ToTable("MST_CertificateStage");

            entity.Property(e => e.CertificateStageId).HasColumnName("CertificateStageID");
            entity.Property(e => e.ActionName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CertificateStageName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ControllerName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstCertificateStatus>(entity =>
        {
            entity.HasKey(e => e.CertificateStatusId);

            entity.ToTable("MST_CertificateStatus");

            entity.Property(e => e.CertificateStatusId)
                .ValueGeneratedNever()
                .HasColumnName("CertificateStatusID");
            entity.Property(e => e.CertificateStatusName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstComputation>(entity =>
        {
            entity.HasKey(e => e.ComputationId);

            entity.ToTable("MST_Computation");

            entity.Property(e => e.ComputationId)
                .ValueGeneratedNever()
                .HasColumnName("ComputationID");
            entity.Property(e => e.ComputationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstEmailStack>(entity =>
        {
            entity.HasKey(e => e.EmailStackId);

            entity.ToTable("MST_EmailStack");

            entity.Property(e => e.AttachmentName).IsUnicode(false);
            entity.Property(e => e.AttachmentPath).IsUnicode(false);
            entity.Property(e => e.EmailCreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailSendOn).HasColumnType("datetime");
            entity.Property(e => e.FromAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.ToBcc).HasColumnName("ToBCC");
            entity.Property(e => e.ToBccname).HasColumnName("ToBCCName");
            entity.Property(e => e.ToCc).HasColumnName("ToCC");
            entity.Property(e => e.ToCcname).HasColumnName("ToCCName");
        });

        modelBuilder.Entity<MstFieldType>(entity =>
        {
            entity.HasKey(e => e.FieldTypeId);

            entity.ToTable("MST_FieldType");

            entity.Property(e => e.FieldTypeId).HasColumnName("FieldTypeID");
            entity.Property(e => e.FieldTypeName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstLastNumber>(entity =>
        {
            entity.HasKey(e => e.LastId);

            entity.ToTable("MST_LastNumber");

            entity.Property(e => e.LastId)
                .ValueGeneratedNever()
                .HasColumnName("LastID");
            entity.Property(e => e.LastNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastNumberType)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstPaymentStatus>(entity =>
        {
            entity.HasKey(e => e.PaymentStatusId);

            entity.ToTable("MST_PaymentStatus");

            entity.Property(e => e.PaymentStatusId)
                .ValueGeneratedNever()
                .HasColumnName("PaymentStatusID");
            entity.Property(e => e.PaymentStatusName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstRegisterationStatus>(entity =>
        {
            entity.HasKey(e => e.RegisterationStatusId);

            entity.ToTable("MST_RegisterationStatus");

            entity.Property(e => e.RegisterationStatusId)
                .ValueGeneratedNever()
                .HasColumnName("RegisterationStatusID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RegisterationStatusName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstRuleRun>(entity =>
        {
            entity.HasKey(e => e.RuleRunId);

            entity.ToTable("MST_RuleRun");

            entity.Property(e => e.RuleRunId)
                .ValueGeneratedNever()
                .HasColumnName("RuleRunID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RuleRunName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstTccrequestStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("MST_TCCRequestStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstTccstage>(entity =>
        {
            entity.HasKey(e => e.TccstageId);

            entity.ToTable("MST_TCCStage");

            entity.Property(e => e.TccstageId).HasColumnName("TCCStageID");
            entity.Property(e => e.ActionName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ControllerName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TccstageName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TCCStageName");
        });

        modelBuilder.Entity<MstTccstatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("MST_TCCStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.ToTable("Nationality");

            entity.Property(e => e.NationalityId)
                .ValueGeneratedNever()
                .HasColumnName("NationalityID");
            entity.Property(e => e.NationalityName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NewErastccHolder>(entity =>
        {
            entity.ToTable("NewERASTccHolder");

            entity.Property(e => e.BusinessName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LGA");
            entity.Property(e => e.Rin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalIncomeEarned).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<NewId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NewID");

            entity.Property(e => e.Newid1).HasColumnName("newid");
            entity.Property(e => e.Rand).HasColumnName("rand");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK_Notification");

            entity.ToTable(tb => tb.HasTrigger("TRG_GenerateNotificationRefCode"));

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NotificationDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationMethodId).HasColumnName("NotificationMethodID");
            entity.Property(e => e.NotificationModeId).HasColumnName("NotificationModeID");
            entity.Property(e => e.NotificationRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");

            entity.HasOne(d => d.NotificationMethod).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.NotificationMethodId)
                .HasConstraintName("FK_Notifications_Notification_Method");

            entity.HasOne(d => d.NotificationMode).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.NotificationModeId)
                .HasConstraintName("FK_Notifications_Notification_Mode");

            entity.HasOne(d => d.NotificationType).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.NotificationTypeId)
                .HasConstraintName("FK_Notifications_Notification_Type");
        });

        modelBuilder.Entity<NotificationMethod>(entity =>
        {
            entity.ToTable("Notification_Method");

            entity.Property(e => e.NotificationMethodId).HasColumnName("NotificationMethodID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationMethodName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NotificationMode>(entity =>
        {
            entity.ToTable("Notification_Mode");

            entity.Property(e => e.NotificationModeId)
                .ValueGeneratedNever()
                .HasColumnName("NotificationModeID");
            entity.Property(e => e.NotificationModeName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NotificationType>(entity =>
        {
            entity.ToTable("Notification_Type");

            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeDescription)
                .HasMaxLength(5000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OperationType>(entity =>
        {
            entity.HasKey(e => e.OperationTypesId);

            entity.ToTable("Operation_Types");

            entity.Property(e => e.OperationTypesId).HasColumnName("Operation_TypesID");
            entity.Property(e => e.OperationTypesName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Operation_TypesName");
        });

        modelBuilder.Entity<PayDirectNotification>(entity =>
        {
            entity.HasKey(e => e.PdinotificationId);

            entity.ToTable("PayDirect_Notifications");

            entity.Property(e => e.PdinotificationId).HasColumnName("PDINotificationID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestParameter).IsUnicode(false);
        });

        modelBuilder.Entity<PayeTccHolder>(entity =>
        {
            entity.ToTable("PayeTccHolder");

            entity.Property(e => e.AnnualTaxIi).HasColumnName("AnnualTaxII");
            entity.Property(e => e.AssessmentYear)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndividualRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IndividualRIN");
            entity.Property(e => e.ReceiptDetail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RowId).HasColumnName("RowID");
        });

        modelBuilder.Entity<PaymentAccount>(entity =>
        {
            entity.ToTable("Payment_Account", tb => tb.HasTrigger("TRG_GeneratePOARef"));

            entity.HasIndex(e => e.RevenueStreamId, "IDX_POA_RSID_TPTID_TPID_A_SMID_PD");

            entity.HasIndex(e => e.SettlementMethodId, "IDX_PoA_SMID");

            entity.HasIndex(e => new { e.TaxPayerTypeId, e.TaxPayerId }, "IDX_PoA_TPTID_TPID");

            entity.HasIndex(e => new { e.RevenueStreamId, e.PaymentDate }, "IX_PA_RSID_PD");

            entity.Property(e => e.PaymentAccountId).HasColumnName("PaymentAccountID");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsManualEntry).HasColumnName("isManualEntry");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.RevenueSubStreamId).HasColumnName("RevenueSubStreamID");
            entity.Property(e => e.SettlementMethodId).HasColumnName("SettlementMethodID");
            entity.Property(e => e.SettlementStatusId).HasColumnName("SettlementStatusID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TransactionRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.RevenueStream).WithMany(p => p.PaymentAccounts)
                .HasForeignKey(d => d.RevenueStreamId)
                .HasConstraintName("FK_Payment_Account_Revenue_Stream");

            entity.HasOne(d => d.RevenueSubStream).WithMany(p => p.PaymentAccounts)
                .HasForeignKey(d => d.RevenueSubStreamId)
                .HasConstraintName("FK_Payment_Account_Revenue_SubStream");

            entity.HasOne(d => d.SettlementMethod).WithMany(p => p.PaymentAccounts)
                .HasForeignKey(d => d.SettlementMethodId)
                .HasConstraintName("FK_Payment_Account_Settlement_Method");

            entity.HasOne(d => d.SettlementStatus).WithMany(p => p.PaymentAccounts)
                .HasForeignKey(d => d.SettlementStatusId)
                .HasConstraintName("FK_Payment_Account_Settlement_Status");

            entity.HasOne(d => d.TaxPayerType).WithMany(p => p.PaymentAccounts)
                .HasForeignKey(d => d.TaxPayerTypeId)
                .HasConstraintName("FK_Payment_Account_TaxPayer_Types");
        });

        modelBuilder.Entity<PaymentFrequency>(entity =>
        {
            entity.ToTable("Payment_Frequency");

            entity.Property(e => e.PaymentFrequencyId).HasColumnName("PaymentFrequencyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentFrequencyName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PaymentOption>(entity =>
        {
            entity.ToTable("Payment_Options");

            entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentOptionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TRG_GenerateProfileRefNo"));

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProfileReferenceNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_Profiles_Asset_Types");
        });

        modelBuilder.Entity<ProfileAttribute>(entity =>
        {
            entity.ToTable("ProfileAttribute");

            entity.Property(e => e.ProfileAttributeId).HasColumnName("ProfileAttributeID");
            entity.Property(e => e.AttributeId).HasColumnName("AttributeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileAttributes)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileAttribute_Profiles");
        });

        modelBuilder.Entity<ProfileGroup>(entity =>
        {
            entity.ToTable("ProfileGroup");

            entity.Property(e => e.ProfileGroupId).HasColumnName("ProfileGroupID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileGroups)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileGroup_Profiles");
        });

        modelBuilder.Entity<ProfileSector>(entity =>
        {
            entity.ToTable("ProfileSector");

            entity.Property(e => e.ProfileSectorId).HasColumnName("ProfileSectorID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.SectorId).HasColumnName("SectorID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileSectors)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileSector_Profiles");
        });

        modelBuilder.Entity<ProfileSectorElement>(entity =>
        {
            entity.ToTable("ProfileSectorElement");

            entity.Property(e => e.ProfileSectorElementId).HasColumnName("ProfileSectorElementID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.SectorElementId).HasColumnName("SectorElementID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileSectorElements)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileSectorElement_Profiles");
        });

        modelBuilder.Entity<ProfileSectorSubElement>(entity =>
        {
            entity.ToTable("ProfileSectorSubElement");

            entity.Property(e => e.ProfileSectorSubElementId).HasColumnName("ProfileSectorSubElementID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.SectorSubElementId).HasColumnName("SectorSubElementID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileSectorSubElements)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileSectorSubElement_Profiles");
        });

        modelBuilder.Entity<ProfileSubAttribute>(entity =>
        {
            entity.ToTable("ProfileSubAttribute");

            entity.Property(e => e.ProfileSubAttributeId).HasColumnName("ProfileSubAttributeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.SubAttributeId).HasColumnName("SubAttributeID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileSubAttributes)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileSubAttribute_Profiles");
        });

        modelBuilder.Entity<ProfileSubGroup>(entity =>
        {
            entity.ToTable("ProfileSubGroup");

            entity.Property(e => e.ProfileSubGroupId).HasColumnName("ProfileSubGroupID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.SubGroupId).HasColumnName("SubGroupID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileSubGroups)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileSubGroup_Profiles");
        });

        modelBuilder.Entity<ProfileSubSector>(entity =>
        {
            entity.ToTable("ProfileSubSector");

            entity.HasIndex(e => e.ProfileId, "IDX_ProfileSubSector");

            entity.Property(e => e.ProfileSubSectorId).HasColumnName("ProfileSubSectorID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.SubSectorId).HasColumnName("SubSectorID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileSubSectors)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileSubSector_Profiles");
        });

        modelBuilder.Entity<ProfileTaxPayerRole>(entity =>
        {
            entity.ToTable("ProfileTaxPayerRole");

            entity.HasIndex(e => e.ProfileId, "IDX_ProfileTaxPayerRole");

            entity.Property(e => e.ProfileTaxPayerRoleId).HasColumnName("ProfileTaxPayerRoleID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.TaxPayerRoleId).HasColumnName("TaxPayerRoleID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileTaxPayerRoles)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileTaxPayerRole_Profiles");
        });

        modelBuilder.Entity<ProfileTaxPayerType>(entity =>
        {
            entity.ToTable("ProfileTaxPayerType");

            entity.Property(e => e.ProfileTaxPayerTypeId).HasColumnName("ProfileTaxPayerTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileTaxPayerTypes)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("FK_ProfileTaxPayerType_Profiles");
        });

        modelBuilder.Entity<ProfileType>(entity =>
        {
            entity.ToTable("Profile_Types");

            entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileTypeName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProfilesBkp>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("Profiles_BKP", tb => tb.HasTrigger("TRG_GenerateProfileRefNo_BKP"));

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProfileReferenceNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.ProfilesBkps)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_Profiles_Asset_Types_BKP");
        });

        modelBuilder.Entity<ReceiptStatus>(entity =>
        {
            entity.ToTable("Receipt_Status");

            entity.Property(e => e.ReceiptStatusId).HasColumnName("ReceiptStatusID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptStatusName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RevenueStream>(entity =>
        {
            entity.ToTable("Revenue_Stream");

            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.BillTemplatePath).HasMaxLength(2500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RevenueStreamName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Smscontent).HasColumnName("SMSContent");
        });

        modelBuilder.Entity<RevenueSubStream>(entity =>
        {
            entity.ToTable("Revenue_SubStream");

            entity.Property(e => e.RevenueSubStreamId).HasColumnName("RevenueSubStreamID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.RevenueSubStreamName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.RevenueStream).WithMany(p => p.RevenueSubStreams)
                .HasForeignKey(d => d.RevenueStreamId)
                .HasConstraintName("FK_Revenue_SubStream_Revenue_Stream");
        });

        modelBuilder.Entity<ReviewStatus>(entity =>
        {
            entity.ToTable("Review_Status");

            entity.Property(e => e.ReviewStatusId).HasColumnName("ReviewStatusID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReviewStatusName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RinCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RIN_Check");

            entity.Property(e => e.CompanyRin)
                .HasMaxLength(255)
                .HasColumnName("Company RIN");
            entity.Property(e => e.IndividualRin)
                .HasMaxLength(255)
                .HasColumnName("Individual RIN");
            entity.Property(e => e.PhoneNumber).HasColumnName("PHONE_NUMBER");
        });

        modelBuilder.Entity<ScratchCardDealer>(entity =>
        {
            entity.ToTable("Scratch_Card_Dealers");

            entity.Property(e => e.ScratchCardDealerId).HasColumnName("ScratchCardDealerID");
            entity.Property(e => e.AgreedCommissionPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DealerTypeId).HasColumnName("DealerTypeID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScratchCardDealerName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScratchCardPrinter>(entity =>
        {
            entity.ToTable("Scratch_Card_Printer");

            entity.Property(e => e.ScratchCardPrinterId).HasColumnName("ScratchCardPrinterID");
            entity.Property(e => e.AgreedUnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScratchCardPrinterName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScratchCardPurchaseRequest>(entity =>
        {
            entity.HasKey(e => e.ScprequestId);

            entity.ToTable("ScratchCard_PurchaseRequest");

            entity.Property(e => e.ScprequestId).HasColumnName("SCPRequestID");
            entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DealerTypeId).HasColumnName("DealerTypeID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.RequestReferenceNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ScratchCardDealerId).HasColumnName("ScratchCardDealerID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ServiceBill>(entity =>
        {
            entity.ToTable("ServiceBill", tb => tb.HasTrigger("TRG_GenerateServiceBillCode"));

            entity.HasIndex(e => e.TaxPayerTypeId, "IDX_SB_TPTID");

            entity.HasIndex(e => new { e.TaxPayerTypeId, e.TaxPayerId }, "IDX_SB_TPTID_TPID");

            entity.Property(e => e.ServiceBillId).HasColumnName("ServiceBillID");
            entity.Property(e => e.BillPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.ServiceBillAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServiceBillDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceBillRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SettlementDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementDueDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementStatusId).HasColumnName("SettlementStatusID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
        });

        modelBuilder.Entity<Settlement>(entity =>
        {
            entity.ToTable("Settlement", tb => tb.HasTrigger("TRG_GenerateSettlementCode"));

            entity.HasIndex(e => new { e.SettlementMethodId, e.SettlementDate }, "IDX_SMT_SMID_SD_AID_SAMT");

            entity.HasIndex(e => new { e.SettlementMethodId, e.SettlementDate }, "IDX_SMT_SMID_SD_ISBID_ISAMT");

            entity.HasIndex(e => new { e.SettlementMethodId, e.SettlementDate }, "IDX_ST_SMD_SD");

            entity.HasIndex(e => e.Active, "IDX_Settlement_cActive");

            entity.HasIndex(e => e.AssessmentId, "IDX_Settlment_Assessment");

            entity.HasIndex(e => e.ServiceBillId, "IDX_Settlment_ServiceBill");

            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
            entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceBillId).HasColumnName("ServiceBillID");
            entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SettlementDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementMethodId).HasColumnName("SettlementMethodID");
            entity.Property(e => e.SettlementNotes).IsUnicode(false);
            entity.Property(e => e.SettlementRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TransactionRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Assessment).WithMany(p => p.Settlements)
                .HasForeignKey(d => d.AssessmentId)
                .HasConstraintName("FK_Settlement_Assessment");

            entity.HasOne(d => d.ServiceBill).WithMany(p => p.Settlements)
                .HasForeignKey(d => d.ServiceBillId)
                .HasConstraintName("FK_Settlement_ServiceBill");

            entity.HasOne(d => d.SettlementMethod).WithMany(p => p.Settlements)
                .HasForeignKey(d => d.SettlementMethodId)
                .HasConstraintName("FK_Settlement_Settlement_Method");
        });

        modelBuilder.Entity<SettlementMethod>(entity =>
        {
            entity.ToTable("Settlement_Method");

            entity.Property(e => e.SettlementMethodId).HasColumnName("SettlementMethodID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementMethodName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SettlementStatus>(entity =>
        {
            entity.ToTable("Settlement_Status");

            entity.Property(e => e.SettlementStatusId).HasColumnName("SettlementStatusID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementStatusName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StatusDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SftpDataSubmission>(entity =>
        {
            entity.HasKey(e => e.DataSubmissionId);

            entity.ToTable("SFTP_DataSubmission", tb => tb.HasTrigger("TRG_GenerateSubmissionRefNo"));

            entity.Property(e => e.DataSubmissionId).HasColumnName("DataSubmissionID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSubmissionTypeId).HasColumnName("DataSubmissionTypeID");
            entity.Property(e => e.DataSubmitterId).HasColumnName("DataSubmitterID");
            entity.Property(e => e.DocumentPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionDate).HasColumnType("datetime");
            entity.Property(e => e.SubmissionRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.DataSubmissionType).WithMany(p => p.SftpDataSubmissions)
                .HasForeignKey(d => d.DataSubmissionTypeId)
                .HasConstraintName("FK_SFTP_DataSubmission_SFTP_DataSubmissionType");

            entity.HasOne(d => d.DataSubmitter).WithMany(p => p.SftpDataSubmissions)
                .HasForeignKey(d => d.DataSubmitterId)
                .HasConstraintName("FK_SFTP_DataSubmission_SFTP_DataSubmitter");
        });

        modelBuilder.Entity<SftpDataSubmissionType>(entity =>
        {
            entity.HasKey(e => e.DataSubmissionTypeId);

            entity.ToTable("SFTP_DataSubmissionType");

            entity.Property(e => e.DataSubmissionTypeId).HasColumnName("DataSubmissionTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSubmissionTypeName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateFilePath)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SftpDataSubmitter>(entity =>
        {
            entity.HasKey(e => e.DataSubmitterId);

            entity.ToTable("SFTP_DataSubmitter");

            entity.Property(e => e.DataSubmitterId).HasColumnName("DataSubmitterID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Rin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.UserName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SftpMapDataSubmitterDataSubmissionType>(entity =>
        {
            entity.HasKey(e => e.Dstdsid);

            entity.ToTable("SFTP_MAP_DataSubmitter_DataSubmissionType");

            entity.Property(e => e.Dstdsid).HasColumnName("DSTDSID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSubmissionTypeId).HasColumnName("DataSubmissionTypeID");
            entity.Property(e => e.DataSubmitterId).HasColumnName("DataSubmitterID");

            entity.HasOne(d => d.DataSubmissionType).WithMany(p => p.SftpMapDataSubmitterDataSubmissionTypes)
                .HasForeignKey(d => d.DataSubmissionTypeId)
                .HasConstraintName("FK_SFTP_MAP_DataSubmitter_DataSubmissionType_SFTP_DataSubmissionType");

            entity.HasOne(d => d.DataSubmitter).WithMany(p => p.SftpMapDataSubmitterDataSubmissionTypes)
                .HasForeignKey(d => d.DataSubmitterId)
                .HasConstraintName("FK_SFTP_MAP_DataSubmitter_DataSubmissionType_SFTP_DataSubmitter");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SizeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Special>(entity =>
        {
            entity.ToTable("Special", tb => tb.HasTrigger("TRG_GenerateSpecialRIN"));

            entity.Property(e => e.SpecialId).HasColumnName("SpecialID");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationMethodId).HasColumnName("NotificationMethodID");
            entity.Property(e => e.SpecialRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SpecialRIN");
            entity.Property(e => e.SpecialTaxPayerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficerId).HasColumnName("TaxOfficerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.Tin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TIN");

            entity.HasOne(d => d.NotificationMethod).WithMany(p => p.Specials)
                .HasForeignKey(d => d.NotificationMethodId)
                .HasConstraintName("FK_Special_Notification_Method");

            entity.HasOne(d => d.TaxOffice).WithMany(p => p.Specials)
                .HasForeignKey(d => d.TaxOfficeId)
                .HasConstraintName("FK_Special_Tax_Offices");

            entity.HasOne(d => d.TaxPayerType).WithMany(p => p.Specials)
                .HasForeignKey(d => d.TaxPayerTypeId)
                .HasConstraintName("FK_Special_TaxPayer_Types");
        });

        modelBuilder.Entity<SystemRole>(entity =>
        {
            entity.ToTable("SystemRole");

            entity.Property(e => e.SystemRoleId).HasColumnName("SystemRoleID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SystemRoleName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SystemUser>(entity =>
        {
            entity.ToTable("SystemUser");

            entity.Property(e => e.SystemUserId).HasColumnName("SystemUserID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SystemRoleId).HasColumnName("SystemRoleID");
            entity.Property(e => e.SystemUserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserLogin)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.SystemRole).WithMany(p => p.SystemUsers)
                .HasForeignKey(d => d.SystemRoleId)
                .HasConstraintName("FK_SystemUser_SystemRole");
        });

        modelBuilder.Entity<TaxClearanceCertificate>(entity =>
        {
            entity.HasKey(e => e.Tccid);

            entity.ToTable("TaxClearanceCertificate", tb => tb.HasTrigger("TRG_GenerateTCCNumber"));

            entity.Property(e => e.Tccid).HasColumnName("TCCID");
            entity.Property(e => e.CancelNotes).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IncomeSource)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TaxPayerDetails).IsUnicode(false);
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.Tccdate)
                .HasColumnType("datetime")
                .HasColumnName("TCCDate");
            entity.Property(e => e.Tccnumber)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TCCNumber");
        });

        modelBuilder.Entity<TaxCredit>(entity =>
        {
            entity.ToTable("Tax_Credit");

            entity.Property(e => e.TaxCreditId).HasColumnName("TaxCreditID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreditDate).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
        });

        modelBuilder.Entity<TaxOffice>(entity =>
        {
            entity.ToTable("Tax_Offices");

            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxOfficeName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.AddressType).WithMany(p => p.TaxOffices)
                .HasForeignKey(d => d.AddressTypeId)
                .HasConstraintName("FK_Tax_Offices_Address_Types");

            entity.HasOne(d => d.Building).WithMany(p => p.TaxOffices)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_Tax_Offices_Building");
        });

        modelBuilder.Entity<TaxOffice1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TaxOffice");

            entity.Property(e => e.TaxOfficeId).ValueGeneratedOnAdd();
            entity.Property(e => e.TaxOfficeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZoneCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TaxPayerPayment>(entity =>
        {
            entity.HasKey(e => e.Tppid);

            entity.ToTable("TaxPayerPayment");

            entity.Property(e => e.Tppid).HasColumnName("TPPID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TransactionAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionDescription)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.TransactionRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");
        });

        modelBuilder.Entity<TaxPayerRole>(entity =>
        {
            entity.ToTable("TaxPayer_Roles");

            entity.Property(e => e.TaxPayerRoleId).HasColumnName("TaxPayerRoleID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxPayerRoleName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.TaxPayerRoles)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_TaxPayer_Roles_Asset_Types");

            entity.HasOne(d => d.TaxPayerType).WithMany(p => p.TaxPayerRoles)
                .HasForeignKey(d => d.TaxPayerTypeId)
                .HasConstraintName("FK_TaxPayer_Roles_TaxPayer_Types");
        });

        modelBuilder.Entity<TaxPayerType>(entity =>
        {
            entity.ToTable("TaxPayer_Types");

            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TccRefHolder>(entity =>
        {
            entity.ToTable("TccRefHolder");

            entity.Property(e => e.ReciptRef)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReqId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TccRequest>(entity =>
        {
            entity.ToTable("TCC_Request", tb => tb.HasTrigger("TRG_GenerateRequestRef"));

            entity.Property(e => e.TccrequestId).HasColumnName("TCCRequestID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GeneratedPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PdftemplateId).HasColumnName("PDFTemplateID");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.RequestRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SealedPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SedeDocumentId).HasColumnName("SEDE_DocumentID");
            entity.Property(e => e.SedeOrderId).HasColumnName("SEDE_OrderID");
            entity.Property(e => e.ServiceBillId).HasColumnName("ServiceBillID");
            entity.Property(e => e.SignedDigitalPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SignedVisiblePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.ValidatedPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.VisibleSignStatusId).HasColumnName("VisibleSignStatusID");
        });

        modelBuilder.Entity<Tccdetail>(entity =>
        {
            entity.ToTable("TCCDetails");

            entity.Property(e => e.TccdetailId).HasColumnName("TCCDetailID");
            entity.Property(e => e.AssessableIncome).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Erasassessed)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ERASAssessed");
            entity.Property(e => e.ErastaxPaid)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ERASTaxPaid");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TcctaxPaid)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TCCTaxPaid");
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TitleName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Town>(entity =>
        {
            entity.ToTable("Town");

            entity.Property(e => e.TownId).HasColumnName("TownID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TownName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Lga).WithMany(p => p.Towns)
                .HasForeignKey(d => d.Lgaid)
                .HasConstraintName("FK_Town_LGA");
        });

        modelBuilder.Entity<TreasuryReceipt>(entity =>
        {
            entity.HasKey(e => e.ReceiptId);

            entity.ToTable("Treasury_Receipt", tb => tb.HasTrigger("TRG_GenerateReceiptRefNo"));

            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");
            entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");
            entity.Property(e => e.CancelNotes)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentUrl)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GeneratedPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ServiceBillId).HasColumnName("ServiceBillID");
            entity.Property(e => e.SignSourceId).HasColumnName("SignSourceID");
            entity.Property(e => e.SignedPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<UnitFunction>(entity =>
        {
            entity.ToTable("Unit_Function");

            entity.Property(e => e.UnitFunctionId).HasColumnName("UnitFunctionID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UnitFunctionName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UnitPurposeId).HasColumnName("UnitPurposeID");

            entity.HasOne(d => d.UnitPurpose).WithMany(p => p.UnitFunctions)
                .HasForeignKey(d => d.UnitPurposeId)
                .HasConstraintName("FK_Unit_Function_Unit_Purpose");
        });

        modelBuilder.Entity<UnitOccupancy>(entity =>
        {
            entity.ToTable("Unit_Occupancy");

            entity.Property(e => e.UnitOccupancyId).HasColumnName("UnitOccupancyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UnitOccupancyName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UnitPurpose>(entity =>
        {
            entity.ToTable("Unit_Purpose");

            entity.Property(e => e.UnitPurposeId).HasColumnName("UnitPurposeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UnitPurposeName)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Upload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("upload");

            entity.Property(e => e.Aaiid).HasColumnName("AAIID");
            entity.Property(e => e.Aarid).HasColumnName("AARID");
            entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");
            entity.Property(e => e.SNo).HasColumnName("s/no");
            entity.Property(e => e.SettlementDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.ToTable("Vehicle", tb => tb.HasTrigger("TRG_GenerateVehicleRIN"));

            entity.HasIndex(e => e.AssetTypeId, "IDX_VA");

            entity.HasIndex(e => e.VehiclePurposeId, "IDX_VH_VP");

            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DsrefId).HasColumnName("DSRefID");
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleDescription)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.VehicleFunctionId).HasColumnName("VehicleFunctionID");
            entity.Property(e => e.VehicleOwnershipId).HasColumnName("VehicleOwnershipID");
            entity.Property(e => e.VehiclePurposeId).HasColumnName("VehiclePurposeID");
            entity.Property(e => e.VehicleRegNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.VehicleRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VehicleRIN");
            entity.Property(e => e.VehicleSubTypeId).HasColumnName("VehicleSubTypeID");
            entity.Property(e => e.VehicleTypeId).HasColumnName("VehicleTypeID");
            entity.Property(e => e.Vin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VIN");

            entity.HasOne(d => d.AssetType).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.AssetTypeId)
                .HasConstraintName("FK_Vehicle_Asset_Types");

            entity.HasOne(d => d.Lga).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.Lgaid)
                .HasConstraintName("FK_Vehicle_LGA");

            entity.HasOne(d => d.VehicleFunction).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.VehicleFunctionId)
                .HasConstraintName("FK_Vehicle_Vehicle_Function");

            entity.HasOne(d => d.VehicleOwnership).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.VehicleOwnershipId)
                .HasConstraintName("FK_Vehicle_Vehicle_Ownership");

            entity.HasOne(d => d.VehiclePurpose).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.VehiclePurposeId)
                .HasConstraintName("FK_Vehicle_Vehicle_Purpose");

            entity.HasOne(d => d.VehicleSubType).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.VehicleSubTypeId)
                .HasConstraintName("FK_Vehicle_Vehicle_SubTypes");

            entity.HasOne(d => d.VehicleType).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.VehicleTypeId)
                .HasConstraintName("FK_Vehicle_Vehicle_Types");
        });

        modelBuilder.Entity<VehicleFunction>(entity =>
        {
            entity.ToTable("Vehicle_Function");

            entity.Property(e => e.VehicleFunctionId).HasColumnName("VehicleFunctionID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleFunctionName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.VehiclePurposeId).HasColumnName("VehiclePurposeID");

            entity.HasOne(d => d.VehiclePurpose).WithMany(p => p.VehicleFunctions)
                .HasForeignKey(d => d.VehiclePurposeId)
                .HasConstraintName("FK_Vehicle_Function_Vehicle_Purpose");
        });

        modelBuilder.Entity<VehicleInsurance>(entity =>
        {
            entity.ToTable("Vehicle_Insurance");

            entity.Property(e => e.VehicleInsuranceId).HasColumnName("VehicleInsuranceID");
            entity.Property(e => e.BrokerAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoverTypeId).HasColumnName("CoverTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.InsuranceCertificateNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InsuranceStatusId).HasColumnName("InsuranceStatusID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PremiumAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            entity.Property(e => e.VerificationAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.VehicleInsurances)
                .HasForeignKey(d => d.VehicleId)
                .HasConstraintName("FK_Vehicle_Insurance_Vehicle");
        });

        modelBuilder.Entity<VehicleLicense>(entity =>
        {
            entity.ToTable("Vehicle_Licenses");

            entity.Property(e => e.VehicleLicenseId).HasColumnName("VehicleLicenseID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.LicenseNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LicenseStatusId).HasColumnName("LicenseStatusID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            entity.Property(e => e.VehicleInsuranceId).HasColumnName("VehicleInsuranceID");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.VehicleLicenses)
                .HasForeignKey(d => d.VehicleId)
                .HasConstraintName("FK_Vehicle_Licenses_Vehicle");

            entity.HasOne(d => d.VehicleInsurance).WithMany(p => p.VehicleLicenses)
                .HasForeignKey(d => d.VehicleInsuranceId)
                .HasConstraintName("FK_Vehicle_Licenses_Vehicle_Insurance");
        });

        modelBuilder.Entity<VehicleOwnership>(entity =>
        {
            entity.ToTable("Vehicle_Ownership");

            entity.Property(e => e.VehicleOwnershipId).HasColumnName("VehicleOwnershipID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleOwnershipName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VehiclePurpose>(entity =>
        {
            entity.ToTable("Vehicle_Purpose");

            entity.Property(e => e.VehiclePurposeId).HasColumnName("VehiclePurposeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.VehiclePurposeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VehicleSubType>(entity =>
        {
            entity.ToTable("Vehicle_SubTypes");

            entity.Property(e => e.VehicleSubTypeId).HasColumnName("VehicleSubTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleSubTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.VehicleTypeId).HasColumnName("VehicleTypeID");

            entity.HasOne(d => d.VehicleType).WithMany(p => p.VehicleSubTypes)
                .HasForeignKey(d => d.VehicleTypeId)
                .HasConstraintName("FK_Vehicle_SubTypes_Vehicle_Types");
        });

        modelBuilder.Entity<VehicleType>(entity =>
        {
            entity.ToTable("Vehicle_Types");

            entity.Property(e => e.VehicleTypeId).HasColumnName("VehicleTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAssessmentBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AssessmentBill");

            entity.Property(e => e.AssessmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentDate).HasColumnType("datetime");
            entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");
            entity.Property(e => e.AssessmentRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SettlementDueDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementStatusId).HasColumnName("SettlementStatusID");
            entity.Property(e => e.SettlementStatusName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficerId).HasColumnName("TaxOfficerID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(501)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
        });

        modelBuilder.Entity<VwAssessmentRule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AssessmentRule");

            entity.Property(e => e.AssessmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssessmentRuleId).HasColumnName("AssessmentRuleID");
            entity.Property(e => e.AssessmentRuleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentFrequencyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RuleRunName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBillForPoAsettlement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BillForPoASettlement");

            entity.Property(e => e.BillAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillId).HasColumnName("BillID");
            entity.Property(e => e.BillRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BillTypeId).HasColumnName("BillTypeID");
            entity.Property(e => e.BillTypeName)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SettlementStatusId).HasColumnName("SettlementStatusID");
            entity.Property(e => e.SettlementStatusName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(501)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBuilding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Building");

            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.BuildingName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BuildingPurposeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BuildingRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BuildingRIN");
            entity.Property(e => e.StreetName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBusiness>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Business");

            entity.Property(e => e.BusinessAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BusinessRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BusinessRIN");
            entity.Property(e => e.BusinessSubSectorName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCertificateList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CertificateList");

            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CertificateNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CertificateStatusName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CertificateTypeName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Company");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CompanyRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CompanyRIN");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.Tin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<VwEmBankStatement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_EM_BankStatement");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.Bsid)
                .ValueGeneratedOnAdd()
                .HasColumnName("BSID");
            entity.Property(e => e.Category).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.RevenueHead).IsUnicode(false);
        });

        modelBuilder.Entity<VwEmPdMainAuthorized>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_EM_PD_Main_Authorized");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.Pdmaid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PDMAID");
            entity.Property(e => e.Rin)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.TaxPayerType).IsUnicode(false);
        });

        modelBuilder.Entity<VwEmPdMainPending>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_EM_PD_Main_Pending");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.Pdmpid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PDMPID");
            entity.Property(e => e.Rin)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.TaxPayerType).IsUnicode(false);
        });

        modelBuilder.Entity<VwEmPdMvaAuthorized>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_EM_PD_MVA_Authorized");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.Pdmvaid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PDMVAID");
            entity.Property(e => e.Rin)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.TaxPayerType).IsUnicode(false);
        });

        modelBuilder.Entity<VwEmPdMvaPending>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_EM_PD_MVA_Pending");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bank).IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).IsUnicode(false);
            entity.Property(e => e.PaymentDateTime).IsUnicode(false);
            entity.Property(e => e.PaymentRefNumber).IsUnicode(false);
            entity.Property(e => e.Pdmvpid)
                .ValueGeneratedOnAdd()
                .HasColumnName("PDMVPID");
            entity.Property(e => e.Rin)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.TaxPayerType).IsUnicode(false);
        });

        modelBuilder.Entity<VwGovernment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Government");

            entity.Property(e => e.ContactAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.GovernmentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GovernmentID");
            entity.Property(e => e.GovernmentName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GovernmentRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("GovernmentRIN");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.Tin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<VwIndividual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Individual");

            entity.Property(e => e.ContactAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.IndividualId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IndividualID");
            entity.Property(e => e.IndividualName)
                .HasMaxLength(501)
                .IsUnicode(false);
            entity.Property(e => e.IndividualRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IndividualRIN");
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.Tin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<VwLand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Land");

            entity.Property(e => e.LandFunctionName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LandId).HasColumnName("LandID");
            entity.Property(e => e.LandOccupier)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LandRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LandRIN");
            entity.Property(e => e.PlotNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMdaservice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MDAServices");

            entity.Property(e => e.MdaserviceId).HasColumnName("MDAServiceID");
            entity.Property(e => e.MdaserviceName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MDAServiceName");
            entity.Property(e => e.PaymentFrequencyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RuleRunName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ServiceAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VwNotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Notifications");

            entity.Property(e => e.NotificationDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.NotificationMethodName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NotificationRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NotificationTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
        });

        modelBuilder.Entity<VwPaymentAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PaymentAccount");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentAccountId).HasColumnName("PaymentAccountID");
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.PaymentRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RevenueStreamId).HasColumnName("RevenueStreamID");
            entity.Property(e => e.SettlementMethodId).HasColumnName("SettlementMethodID");
            entity.Property(e => e.SettlementMethodName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficerId).HasColumnName("TaxOfficerID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(501)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
            entity.Property(e => e.TransactionRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPaymentAccountOperation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PaymentAccountOperation");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FromName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FromTaxPayer)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OperationDate).HasColumnType("datetime");
            entity.Property(e => e.OperationTypesName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Operation_TypesName");
            entity.Property(e => e.Poaid).HasColumnName("POAID");
            entity.Property(e => e.ToName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ToTaxPayer)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwProfilePayePcMe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Profile_PAYE_PC_ME");

            entity.Property(e => e.ProfileDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.ProfileReferenceNo)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwProfilePayePcMeAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Profile_PAYE_PC_ME_Asset");

            entity.Property(e => e.AssetName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AssetRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AssetRIN");
            entity.Property(e => e.AssetTypeName)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwProfilePayePcMeTaxPayer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Profile_PAYE_PC_ME_TaxPayer");

            entity.Property(e => e.ContactAddress)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(501)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TaxPayerRIN");
            entity.Property(e => e.TaxPayerTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwServiceBillNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ServiceBillNew");

            entity.Property(e => e.ServiceBillAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServiceBillDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceBillId).HasColumnName("ServiceBillID");
            entity.Property(e => e.ServiceBillRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SettlementDueDate).HasColumnType("datetime");
            entity.Property(e => e.SettlementStatusId).HasColumnName("SettlementStatusID");
            entity.Property(e => e.SettlementStatusName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.TaxOfficerId).HasColumnName("TaxOfficerID");
            entity.Property(e => e.TaxPayerId).HasColumnName("TaxPayerID");
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(501)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerTypeId).HasColumnName("TaxPayerTypeID");
        });

        modelBuilder.Entity<VwSpecial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Special");

            entity.Property(e => e.ContactName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SpecialId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SpecialID");
            entity.Property(e => e.SpecialRin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SpecialRIN");
            entity.Property(e => e.SpecialTaxPayerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.Tin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<VwTccrequestList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TCCRequestList");

            entity.Property(e => e.MobileNumber1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.RequestRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ServiceBillRefNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SettlementStatusName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TaxPayerName)
                .HasMaxLength(501)
                .IsUnicode(false);
            entity.Property(e => e.TccrequestId).HasColumnName("TCCRequestID");
        });

        modelBuilder.Entity<VwVehicle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Vehicle");

            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            entity.Property(e => e.VehiclePurposeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.VehicleRegNumber)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.VehicleRin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VehicleRIN");
            entity.Property(e => e.VehicleSubTypeName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.ToTable("Ward");

            entity.Property(e => e.WardId).HasColumnName("WardID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Lgaid).HasColumnName("LGAID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.WardName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Lga).WithMany(p => p.Wards)
                .HasForeignKey(d => d.Lgaid)
                .HasConstraintName("FK_Ward_LGA");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.ZoneCode);

            entity.ToTable("Zone");

            entity.Property(e => e.ZoneCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasColumnName("ModifiedBY");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ZoneId).ValueGeneratedOnAdd();
            entity.Property(e => e.ZoneName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ZoneLga>(entity =>
        {
            entity.ToTable("ZoneLGA");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LgaName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZoneCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

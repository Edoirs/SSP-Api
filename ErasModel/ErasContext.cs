
namespace SelfPortalAPi.ErasModel;

public partial class ErasContext : DbContext
{
    public ErasContext()
    {
    }

    public ErasContext(DbContextOptions<ErasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApiLog> ApiLogs { get; set; }

    public virtual DbSet<ElmahError> ElmahErrors { get; set; }

    public virtual DbSet<MapApiUsersRight> MapApiUsersRights { get; set; }

    public virtual DbSet<MapCentralMenuScreen> MapCentralMenuScreens { get; set; }

    public virtual DbSet<MapUserScreen> MapUserScreens { get; set; }

    public virtual DbSet<MstApi> MstApis { get; set; }

    public virtual DbSet<MstAwarenessCategory> MstAwarenessCategories { get; set; }

    public virtual DbSet<MstBusiness> MstBusinesses { get; set; }

    public virtual DbSet<MstCentralMenu> MstCentralMenus { get; set; }

    public virtual DbSet<MstFaq> MstFaqs { get; set; }

    public virtual DbSet<MstMenu> MstMenus { get; set; }

    public virtual DbSet<MstPage> MstPages { get; set; }

    public virtual DbSet<MstScreen> MstScreens { get; set; }

    public virtual DbSet<MstUser> MstUsers { get; set; }

    public virtual DbSet<MstUserToken> MstUserTokens { get; set; }

    public virtual DbSet<MstUserType> MstUserTypes { get; set; }

    public virtual DbSet<SystemRole> SystemRoles { get; set; }

    public virtual DbSet<SystemUser> SystemUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=92.205.57.77;Initial Catalog=ERAS;user id=Admin;password=K5?wh7l4##;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApiLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("API_Log");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.RequestTimestamp).HasColumnType("datetime");
            entity.Property(e => e.ResponseTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<ElmahError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ELMAH_Error");

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

        modelBuilder.Entity<MapApiUsersRight>(entity =>
        {
            entity.HasKey(e => e.Uaid);

            entity.ToTable("MAP_API_Users_Rights");

            entity.Property(e => e.Uaid).HasColumnName("UAID");
            entity.Property(e => e.Apiaccess).HasColumnName("APIAccess");
            entity.Property(e => e.Apiid).HasColumnName("APIID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Api).WithMany(p => p.MapApiUsersRights)
                .HasForeignKey(d => d.Apiid)
                .HasConstraintName("FK_MAP_API_Users_Rights_MST_API");

            entity.HasOne(d => d.User).WithMany(p => p.MapApiUsersRights)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_MAP_API_Users_Rights_MST_Users");
        });

        modelBuilder.Entity<MapCentralMenuScreen>(entity =>
        {
            entity.HasKey(e => e.Cmsid);

            entity.ToTable("MAP_CentralMenu_Screen");

            entity.Property(e => e.Cmsid).HasColumnName("CMSID");
            entity.Property(e => e.CentralMenuId).HasColumnName("CentralMenuID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsMainScreen).HasColumnName("isMainScreen");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

            entity.HasOne(d => d.CentralMenu).WithMany(p => p.MapCentralMenuScreens)
                .HasForeignKey(d => d.CentralMenuId)
                .HasConstraintName("FK_MAP_CentralMenu_Screen_MST_CentralMenu");

            entity.HasOne(d => d.Screen).WithMany(p => p.MapCentralMenuScreens)
                .HasForeignKey(d => d.ScreenId)
                .HasConstraintName("FK_MAP_CentralMenu_Screen_MST_Screen");
        });

        modelBuilder.Entity<MapUserScreen>(entity =>
        {
            entity.HasKey(e => e.Usid);

            entity.ToTable("MAP_User_Screen");

            entity.Property(e => e.Usid).HasColumnName("USID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScreenId).HasColumnName("ScreenID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Screen).WithMany(p => p.MapUserScreens)
                .HasForeignKey(d => d.ScreenId)
                .HasConstraintName("FK_MAP_User_Screen_MST_Screen");

            entity.HasOne(d => d.User).WithMany(p => p.MapUserScreens)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_MAP_User_Screen_MST_Users");
        });

        modelBuilder.Entity<MstApi>(entity =>
        {
            entity.HasKey(e => e.Apiid);

            entity.ToTable("MST_API", tb => tb.HasTrigger("TRG_AddUserToRight"));

            entity.Property(e => e.Apiid).HasColumnName("APIID");
            entity.Property(e => e.ActionName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Apidescription)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("APIDescription");
            entity.Property(e => e.Apiname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("APIName");
            entity.Property(e => e.ControllerName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentPath)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstAwarenessCategory>(entity =>
        {
            entity.HasKey(e => e.AwarenessCategoryId);

            entity.ToTable("MST_AwarenessCategory");

            entity.Property(e => e.AwarenessCategoryId).HasColumnName("AwarenessCategoryID");
            entity.Property(e => e.AwarenessCategoryName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SectionDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstBusiness>(entity =>
        {
            entity.HasKey(e => e.BusinessId);

            entity.ToTable("MST_Business");

            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.AssetType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BuildingTag)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessCategory)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessOperation)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessSector)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessStructure)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessSubSector)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BusinessType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Latitude)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Lga)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LGA");
            entity.Property(e => e.Longitude)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Mdaservices).HasColumnName("MDAServices");
            entity.Property(e => e.Paye).HasColumnName("PAYE");
            entity.Property(e => e.Phone)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Size)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Source)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tin)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<MstCentralMenu>(entity =>
        {
            entity.HasKey(e => e.CentralMenuId);

            entity.ToTable("MST_CentralMenu");

            entity.Property(e => e.CentralMenuId).HasColumnName("CentralMenuID");
            entity.Property(e => e.CentralMenuName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ParentCentralMenuId).HasColumnName("ParentCentralMenuID");
            entity.Property(e => e.SortOrder).HasColumnType("decimal(18, 5)");

            entity.HasOne(d => d.ParentCentralMenu).WithMany(p => p.InverseParentCentralMenu)
                .HasForeignKey(d => d.ParentCentralMenuId)
                .HasConstraintName("FK_MST_CentralMenu_MST_CentralMenu1");
        });

        modelBuilder.Entity<MstFaq>(entity =>
        {
            entity.HasKey(e => e.Faqid);

            entity.ToTable("MST_FAQ");

            entity.Property(e => e.Faqid).HasColumnName("FAQID");
            entity.Property(e => e.AwarenessCategoryId).HasColumnName("AwarenessCategoryID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Faqtext)
                .IsUnicode(false)
                .HasColumnName("FAQText");
            entity.Property(e => e.Faqtitle)
                .IsUnicode(false)
                .HasColumnName("FAQTitle");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AwarenessCategory).WithMany(p => p.MstFaqs)
                .HasForeignKey(d => d.AwarenessCategoryId)
                .HasConstraintName("FK_MST_FAQ_MST_AwarenessCategory");
        });

        modelBuilder.Entity<MstMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("MST_Menu");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MenuName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MenuUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MenuURL");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.MetaKeywords)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PageContent).IsUnicode(false);
            entity.Property(e => e.PageHeader)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PageTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ParentMenuId).HasColumnName("ParentMenuID");
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.ParentMenu).WithMany(p => p.InverseParentMenu)
                .HasForeignKey(d => d.ParentMenuId)
                .HasConstraintName("FK_MST_Menu_MST_Menu1");
        });

        modelBuilder.Entity<MstPage>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.ToTable("MST_Pages");

            entity.Property(e => e.PageId)
                .ValueGeneratedNever()
                .HasColumnName("PageID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.MetaKeywords)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PageContent).IsUnicode(false);
            entity.Property(e => e.PageHeader)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PageName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PageTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstScreen>(entity =>
        {
            entity.HasKey(e => e.ScreenId);

            entity.ToTable("MST_Screen");

            entity.Property(e => e.ScreenId).HasColumnName("ScreenID");
            entity.Property(e => e.ActionName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ControllerName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ScreenName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ScreenUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ViewName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("MST_Users");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.ContactName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IsTomanager).HasColumnName("IsTOManager");
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SignaturePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TaxOfficeId).HasColumnName("TaxOfficeID");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TomanagerId).HasColumnName("TOManagerID");
            entity.Property(e => e.UserName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

            entity.HasOne(d => d.UserType).WithMany(p => p.MstUsers)
                .HasForeignKey(d => d.UserTypeId)
                .HasConstraintName("FK_MST_Users_MST_UserType");
        });

        modelBuilder.Entity<MstUserToken>(entity =>
        {
            entity.HasKey(e => e.TokenId);

            entity.ToTable("MST_UserToken");

            entity.Property(e => e.TokenId).HasColumnName("TokenID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Ipaddresss)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IPAddresss");
            entity.Property(e => e.Token)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.TokenExpiresDate).HasColumnType("datetime");
            entity.Property(e => e.TokenIssuedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.MstUserTokens)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_MST_UserToken_MST_User");
        });

        modelBuilder.Entity<MstUserType>(entity =>
        {
            entity.HasKey(e => e.UserTypeId);

            entity.ToTable("MST_UserType");

            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserTypeName)
                .HasMaxLength(500)
                .IsUnicode(false);
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

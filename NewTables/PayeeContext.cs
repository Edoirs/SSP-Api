
using Microsoft.EntityFrameworkCore;

namespace SelfPortalAPi.NewTables
{
    public partial class PayeeContext : DbContext
    {
        public PayeeContext()
        {
        }

        public PayeeContext(DbContextOptions<PayeeContext> options)
            : base(options)
        {
    }

        public virtual DbSet<AnnualReturn> AnnualReturns { get; set; }
        public virtual DbSet<FormH1> FormH1s { get; set; }
        public virtual DbSet<FormH3> FormH3s { get; set; }
        public virtual DbSet<FiledFormH> FiledFormH { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Schedule_Record> Schedule_Records { get; set; }
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<LocalGovtPostalCodes> LocalGovtPostalCodees { get; set; }
        public virtual DbSet<Projection> Projections { get; set; }
        public virtual DbSet<UserManagement> UserManagements { get; set; }
        public virtual DbSet<LocalGovernment> LocalGovernments { get; set; }
        public virtual DbSet<Cooperate> Cooperates { get; set; }
    }
}
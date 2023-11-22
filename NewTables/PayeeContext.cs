
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

        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<LocalGovtPostalCodes> LocalGovtPostalCodees { get; set; }
        public virtual DbSet<LocalGovernment> LocalGovernments { get; set; }
        public virtual DbSet<Cooperate> Cooperates { get; set; }
    }
}
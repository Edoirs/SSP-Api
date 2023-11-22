using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TaxPayerType
{
    public int TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<EconomicActivity> EconomicActivities { get; set; } = new List<EconomicActivity>();

    public virtual ICollection<Government> Governments { get; set; } = new List<Government>();

    public virtual ICollection<Individual> Individuals { get; set; } = new List<Individual>();

    public virtual ICollection<MapTaxPayerAsset> MapTaxPayerAssets { get; set; } = new List<MapTaxPayerAsset>();

    public virtual ICollection<PaymentAccount> PaymentAccounts { get; set; } = new List<PaymentAccount>();

    public virtual ICollection<Special> Specials { get; set; } = new List<Special>();

    public virtual ICollection<TaxPayerRole> TaxPayerRoles { get; set; } = new List<TaxPayerRole>();
}

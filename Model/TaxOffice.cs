using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TaxOffice
{
    public int TaxOfficeId { get; set; }

    public string? TaxOfficeName { get; set; }

    public int? AddressTypeId { get; set; }

    public int? BuildingId { get; set; }

    public int? Approver1 { get; set; }

    public int? Approver2 { get; set; }

    public int? Approver3 { get; set; }

    public int? ZoneId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AddressType? AddressType { get; set; }

    public virtual Building? Building { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<Government> Governments { get; set; } = new List<Government>();

    public virtual ICollection<Individual> Individuals { get; set; } = new List<Individual>();

    public virtual ICollection<MapTaxOfficeTarget> MapTaxOfficeTargets { get; set; } = new List<MapTaxOfficeTarget>();

    public virtual ICollection<MapTaxOfficerTarget> MapTaxOfficerTargets { get; set; } = new List<MapTaxOfficerTarget>();

    public virtual ICollection<Special> Specials { get; set; } = new List<Special>();
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Special
{
    public int SpecialId { get; set; }

    public string? SpecialRin { get; set; }

    public string? SpecialTaxPayerName { get; set; }

    public string? Tin { get; set; }

    public int? TaxOfficeId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? ContactNumber { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactName { get; set; }

    public string? Description { get; set; }

    public int? NotificationMethodId { get; set; }

    public int? TaxOfficerId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapSpecialAddressInformation> MapSpecialAddressInformations { get; set; } = new List<MapSpecialAddressInformation>();

    public virtual NotificationMethod? NotificationMethod { get; set; }

    public virtual TaxOffice? TaxOffice { get; set; }

    public virtual TaxPayerType? TaxPayerType { get; set; }
}

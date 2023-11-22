using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Government
{
    public int GovernmentId { get; set; }

    public string? GovernmentRin { get; set; }

    public string? Password { get; set; }

    public string? GovernmentName { get; set; }

    public int? GovernmentTypeId { get; set; }

    public string? Tin { get; set; }

    public int? TaxOfficeId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? ContactNumber { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactName { get; set; }

    public int? NotificationMethodId { get; set; }

    public string? ContactAddress { get; set; }

    public int? RegisterationStatusId { get; set; }

    public DateTime? RegisterationDate { get; set; }

    public int? VerificationOtp { get; set; }

    public int? TaxOfficerId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? DataSourceId { get; set; }

    public long? DsrefId { get; set; }

    public virtual GovernmentType? GovernmentType { get; set; }

    public virtual ICollection<MapGovernmentAddressInformation> MapGovernmentAddressInformations { get; set; } = new List<MapGovernmentAddressInformation>();

    public virtual NotificationMethod? NotificationMethod { get; set; }

    public virtual MstRegisterationStatus? RegisterationStatus { get; set; }

    public virtual TaxOffice? TaxOffice { get; set; }

    public virtual TaxPayerType? TaxPayerType { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Company
{
    public int CompanyId { get; set; }

    public string? CompanyRin { get; set; }

    public string? Password { get; set; }

    public string? CompanyName { get; set; }

    public string? Tin { get; set; }

    public string? MobileNumber1 { get; set; }

    public string? MobileNumber2 { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? EmailAddress2 { get; set; }

    public int? TaxOfficeId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? EconomicActivitiesId { get; set; }

    public int? NotificationMethodId { get; set; }

    public string? ContactAddress { get; set; }

    public int? RegisterationStatusId { get; set; }

    public DateTime? RegisterationDate { get; set; }

    public int? VerificationOtp { get; set; }

    public int? TaxOfficerId { get; set; }

    public string? CacregistrationNumber { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? DataSourceId { get; set; }

    public long? DsrefId { get; set; }

    public string? Cac { get; set; }

    public virtual EconomicActivity? EconomicActivities { get; set; }

    public virtual ICollection<MapCompanyAddressInformation> MapCompanyAddressInformations { get; set; } = new List<MapCompanyAddressInformation>();

    public virtual NotificationMethod? NotificationMethod { get; set; }

    public virtual MstRegisterationStatus? RegisterationStatus { get; set; }

    public virtual TaxOffice? TaxOffice { get; set; }

    public virtual TaxPayerType? TaxPayerType { get; set; }
}

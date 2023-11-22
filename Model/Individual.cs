using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Individual
{
    public int IndividualId { get; set; }

    public string? IndividualRin { get; set; }

    public string? Password { get; set; }

    public int? GenderId { get; set; }

    public int? TitleId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public DateTime? Dob { get; set; }

    public string? Tin { get; set; }

    public string? MobileNumber1 { get; set; }

    public string? MobileNumber2 { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? EmailAddress2 { get; set; }

    public string? BiometricDetails { get; set; }

    public int? TaxOfficeId { get; set; }

    public int? MaritalStatusId { get; set; }

    public int? NationalityId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? EconomicActivitiesId { get; set; }

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

    public string? Nin { get; set; }

    public virtual EconomicActivity? EconomicActivities { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual ICollection<MapIndividualAddressInformation> MapIndividualAddressInformations { get; set; } = new List<MapIndividualAddressInformation>();

    public virtual MaritalStatus? MaritalStatus { get; set; }

    public virtual Nationality? Nationality { get; set; }

    public virtual NotificationMethod? NotificationMethod { get; set; }

    public virtual MstRegisterationStatus? RegisterationStatus { get; set; }

    public virtual TaxOffice? TaxOffice { get; set; }

    public virtual TaxPayerType? TaxPayerType { get; set; }

    public virtual Title? Title { get; set; }
}

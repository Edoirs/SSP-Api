using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class EpldIndividual
{
    public long Epldid { get; set; }

    public int? DataSourceId { get; set; }

    public long? DsrefId { get; set; }

    public string? Tin { get; set; }

    public string? Bvn { get; set; }

    public string? Nin { get; set; }

    public int? GenderId { get; set; }

    public string? GenderName { get; set; }

    public int? TitleId { get; set; }

    public string? TitleName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? StateOfOrigin { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? MaritalStatusName { get; set; }

    public int? EconomicActivityId { get; set; }

    public string? EconomicActivityName { get; set; }

    public int? NationalityId { get; set; }

    public string? NationalityName { get; set; }

    public string? PhoneNo1 { get; set; }

    public string? PhoneNo2 { get; set; }

    public string? EmailAddress { get; set; }

    public string? HouseNumber { get; set; }

    public string? StreetName { get; set; }

    public string? City { get; set; }

    public string? Lganame { get; set; }

    public string? StateName { get; set; }

    public string? ContactAddress { get; set; }

    public int? TaxOfficeId { get; set; }

    public string? TaxOfficeName { get; set; }

    public int? NotificationMethodId { get; set; }

    public string? NotificationMethodName { get; set; }

    public int? MaritalStatusId { get; set; }

    public string? RecordStatus { get; set; }

    public string? RecordResult { get; set; }

    public string? Rin { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class EsdIndividual
{
    public long Esdid { get; set; }

    public int? DataSourceId { get; set; }

    public long? DsrefId { get; set; }

    public string? Tin { get; set; }

    public string? Bvn { get; set; }

    public string? Nin { get; set; }

    public string? Gender { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? StateOfOrigin { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Occupation { get; set; }

    public string? Nationality { get; set; }

    public string? PhoneNo1 { get; set; }

    public string? PhoneNo2 { get; set; }

    public string? EmailAddress { get; set; }

    public string? HouseNumber { get; set; }

    public string? StreetName { get; set; }

    public string? City { get; set; }

    public string? Lganame { get; set; }

    public string? StateName { get; set; }

    public string? ContactAddress { get; set; }

    public string? TaxOffice { get; set; }

    public string? Notification { get; set; }

    public string? RecordStatus { get; set; }

    public string? RecordError { get; set; }
}

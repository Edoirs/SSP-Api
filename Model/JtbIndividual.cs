using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class JtbIndividual
{
    public long JtbindividualId { get; set; }

    public string? Tin { get; set; }

    public string? Bvn { get; set; }

    public string? Nin { get; set; }

    public string? Title { get; set; }

    public string? SbirtName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? GenderName { get; set; }

    public string? StateOfOrigin { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Occupation { get; set; }

    public string? NationalityName { get; set; }

    public string? PhoneNo1 { get; set; }

    public string? PhoneNo2 { get; set; }

    public string? TaxpayerPhoto { get; set; }

    public string? EmailAddress { get; set; }

    public DateTime? DateOfRegistration { get; set; }

    public string? HouseNumber { get; set; }

    public string? StreetName { get; set; }

    public string? City { get; set; }

    public string? Lganame { get; set; }

    public string? StateName { get; set; }

    public string? CountryName { get; set; }

    public string? TaxAuthorityCode { get; set; }

    public string? TaxAuthorityName { get; set; }

    public string? TaxpayerStatus { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

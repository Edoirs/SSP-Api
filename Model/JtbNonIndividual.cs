using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class JtbNonIndividual
{
    public long JtbnonIndividualId { get; set; }

    public string? Tin { get; set; }

    public string? RegisteredName { get; set; }

    public string? MainTradeName { get; set; }

    public string? OrgName { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? PhoneNo1 { get; set; }

    public string? PhoneNo2 { get; set; }

    public string? EmailAddress { get; set; }

    public string? LineOfBusinessCode { get; set; }

    public string? LobName { get; set; }

    public DateTime? DateOfRegistration { get; set; }

    public DateTime? CommencementDate { get; set; }

    public DateTime? DateOfIncorporation { get; set; }

    public string? HouseNumber { get; set; }

    public string? StreetName { get; set; }

    public string? City { get; set; }

    public string? Lganame { get; set; }

    public string? StateName { get; set; }

    public string? CountryName { get; set; }

    public string? FinYrBegin { get; set; }

    public string? FinYrEnd { get; set; }

    public string? DirectorName { get; set; }

    public string? DirectorPhone { get; set; }

    public string? DirectorEmail { get; set; }

    public string? TaxAuthorityCode { get; set; }

    public string? TaxAuthorityName { get; set; }

    public string? TaxpayerStatus { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

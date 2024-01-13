using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class Individual
{
    public long IndId { get; set; }

    public int IndCreateBy { get; set; }

    public DateTime IndCreateAt { get; set; }

    public string UserRin { get; set; } = null!;

    public int Gender { get; set; }

    public int Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string DateOfBirth { get; set; } = null!;

    public string? Tin { get; set; }

    public string MobileNumber1 { get; set; } = null!;

    public string? MobileNumber2 { get; set; }

    public string? EmailAddress1 { get; set; }

    public string? EmailAddress2 { get; set; }

    public string? BioMetricDetails { get; set; }

    public int? TaxOffice { get; set; }

    public int? MaritalStatus { get; set; }

    public int Nationality { get; set; }

    public string? TaxPayerType { get; set; }

    public int? EconomicActivity { get; set; }

    public int? PrefferedNotificationMethod { get; set; }

    public int? TaxPayerStatus { get; set; }

    public string? AccountBalance { get; set; }

    public string? CompanyTin { get; set; }

    public string? CompanyRin { get; set; }

    public string? IsValidated { get; set; }

    public string? BusinessRin { get; set; }
}

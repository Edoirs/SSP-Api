using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwInputFileMain
{
    public int Lsid { get; set; }

    public string? TpTin { get; set; }

    public string? TaxYear { get; set; }

    public double? Basic { get; set; }

    public double? Rent { get; set; }

    public double? Trans { get; set; }

    public double? Ltg { get; set; }

    public double? Others { get; set; }

    public double? Pension { get; set; }

    public double? Nhf { get; set; }

    public double? Nhis { get; set; }

    public string? BusinessRin { get; set; }

    public int? Category { get; set; }

    public string? TaxPayerRin { get; set; }

    public string? TaxPayerName { get; set; }

    public string? CompanyRin { get; set; }

    public string? CompanyTin { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactAddress { get; set; }

    public string? BusinessRin1 { get; set; }

    public string? BusinessName { get; set; }

    public string? AssessmentRuleCode { get; set; }

    public string? AssessmentRuleName { get; set; }

    public string TaxMonth { get; set; } = null!;

    public double? AssessmentAmount { get; set; }

    public string? TaxYear1 { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string Title { get; set; } = null!;

    public string Nationality { get; set; } = null!;

    public string AnnualUtility { get; set; } = null!;

    public string AnnualMeal { get; set; } = null!;

    public double? AnnualGross { get; set; }

    public string Status { get; set; } = null!;
}

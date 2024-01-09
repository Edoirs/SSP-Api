using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class VwLegacySubmission
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

    public string? MobileNumber { get; set; }

    public double AnnualUtility { get; set; }

    public double AnnualMeal { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class LegacySubmissionsPaye
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

    public double? AnnualUtility { get; set; }

    public double? AnnualMeal { get; set; }
}

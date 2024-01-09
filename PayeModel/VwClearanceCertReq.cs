using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class VwClearanceCertReq
{
    public string? AssessmentChildRef { get; set; }

    public string? AssessmentRef { get; set; }

    public string? MonthTax { get; set; }

    public string? YearTax { get; set; }

    public string? IsPaid { get; set; }

    public decimal? Amount { get; set; }

    public string? CompanyRin { get; set; }

    public string TaxPayerName { get; set; } = null!;
}

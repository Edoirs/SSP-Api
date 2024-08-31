using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwPreAssessmentRdm
{
    public string? TaxPayerRin { get; set; }

    public string? TaxPayerName { get; set; }

    public string? AssetRin { get; set; }

    public string? AssessmentRuleName { get; set; }

    public string? TaxYear { get; set; }

    public double? TaxBaseAmount { get; set; }

    public string? Status { get; set; }

    public string? AssessmentRefNo { get; set; }
}

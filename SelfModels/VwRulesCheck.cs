using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwRulesCheck
{
    public string? TaxPayerRin { get; set; }

    public string? CompanyRin { get; set; }

    public string? CompanyTin { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactAddress { get; set; }

    public string? AssetRin { get; set; }

    public string? BusinessRin { get; set; }

    public string? BusinessName { get; set; }

    public string? AssessmentRuleCode { get; set; }

    public string? AssessmentRuleName { get; set; }

    public string? TaxMonth { get; set; }

    public string? TaxMonth1 { get; set; }

    public string? TaxYear { get; set; }

    public double AssessmentAmount { get; set; }
}

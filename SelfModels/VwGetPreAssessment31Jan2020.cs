using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwGetPreAssessment31Jan2020
{
    public string? EmployerRin { get; set; }

    public string? EmployerName { get; set; }

    public string? AssetRin { get; set; }

    public string? AssessmentRuleName { get; set; }

    public string? TaxYear { get; set; }

    public string? TaxMonth { get; set; }

    public string? AssessmentItemName { get; set; }

    public double? MonthlyTax { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssetId { get; set; }

    public int? ProfileId { get; set; }

    public int? AssessmentItemId { get; set; }

    public string? AssessmentRuleId { get; set; }
}

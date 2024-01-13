using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class VwTaxComputationFinal
{
    public int? AssessmentYear { get; set; }

    public string? EmployerRin { get; set; }

    public string? EmployerName { get; set; }

    public string? BusinessRin { get; set; }

    public string? Month { get; set; }

    public decimal? TaxAmt { get; set; }

    public string? AssessmentRuleName { get; set; }

    public string? AssessmentItemName { get; set; }

    public int TaxPayerTypeId { get; set; }

    public int TaxPayerId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssetId { get; set; }

    public int? ProfileId { get; set; }

    public int? AssessmentItemId { get; set; }

    public string? AssessmentRuleId { get; set; }
}

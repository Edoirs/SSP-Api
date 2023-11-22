using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwAssessmentRule
{
    public int? TaxYear { get; set; }

    public string? AssessmentRuleName { get; set; }

    public string? RuleRunName { get; set; }

    public string? PaymentFrequencyName { get; set; }

    public decimal? AssessmentAmount { get; set; }

    public int AssessmentRuleId { get; set; }
}

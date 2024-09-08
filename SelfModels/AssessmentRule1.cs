using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class AssessmentRule1
{
    public long AssessmentRuleId { get; set; }

    public string? AssessmentRuleCode { get; set; }

    public int? ProfileId { get; set; }

    public string? AssessmentRuleName { get; set; }

    public int? RuleRunId { get; set; }

    public int? PaymentFrequencyId { get; set; }

    public double? AssessmentAmount { get; set; }

    public int? TaxYear { get; set; }

    public int? TaxMonth { get; set; }

    public int? PaymentOptionId { get; set; }

    public bool? Active { get; set; }
}

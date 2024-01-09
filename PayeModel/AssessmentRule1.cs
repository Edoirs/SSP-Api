using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class AssessmentRule1
{
    public double? AssessmentRuleId { get; set; }

    public string? AssessmentRuleCode { get; set; }

    public double? ProfileId { get; set; }

    public string? AssessmentRuleName { get; set; }

    public double? RuleRunId { get; set; }

    public double? PaymentFrequencyId { get; set; }

    public double? AssessmentAmount { get; set; }

    public double? TaxYear { get; set; }

    public double? TaxMonth { get; set; }

    public double? PaymentOptionId { get; set; }

    public double? Active { get; set; }
}

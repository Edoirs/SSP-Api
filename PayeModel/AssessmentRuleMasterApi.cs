using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class AssessmentRuleMasterApi
{
    public string? AssessmentRuleId { get; set; }

    public string? AssessmentRuleCode { get; set; }

    public string? ProfileId { get; set; }

    public string? AssessmentRuleName { get; set; }

    public int? RuleRunId { get; set; }

    public int? PaymentFrequencyId { get; set; }

    public int? AssessmentAmount { get; set; }

    public int? TaxYear { get; set; }

    public string? TaxMonth { get; set; }

    public int? PaymentOptionId { get; set; }

    public int? Active { get; set; }
}

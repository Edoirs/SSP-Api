using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class AssessmentRule
{
    public int AssessRulesId { get; set; }

    public int? AssessRulesCreateBy { get; set; }

    public DateTime? AssessRulesCreateAt { get; set; }

    public string? RuleCode { get; set; }

    public int? Profile { get; set; }

    public string? AssessmentRuleName { get; set; }

    public int? RuleRun { get; set; }

    public int? Frequency { get; set; }

    public string? AssessmentItems { get; set; }

    public double? AssessmentAmount { get; set; }

    public int? TaxYear { get; set; }

    public string? SettlementMethods { get; set; }

    public int? PaymentOptions { get; set; }

    public DateTime DateCreated { get; set; }

    public int? ApiId { get; set; }

    public long AssessmentRuleId { get; set; }
}

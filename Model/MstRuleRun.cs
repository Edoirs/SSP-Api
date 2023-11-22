using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MstRuleRun
{
    public int RuleRunId { get; set; }

    public string? RuleRunName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentRule> AssessmentRules { get; set; } = new List<AssessmentRule>();

    public virtual ICollection<MdaService> MdaServices { get; set; } = new List<MdaService>();
}

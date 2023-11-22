using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapAssessmentRuleSettlementMethod
{
    public int Arsmid { get; set; }

    public int? AssessmentRuleId { get; set; }

    public int? SettlementMethodId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual AssessmentRule? AssessmentRule { get; set; }

    public virtual SettlementMethod? SettlementMethod { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapAssessmentRuleAssessmentItem
{
    public int Araiid { get; set; }

    public int? AssessmentRuleId { get; set; }

    public int? AssessmentItemId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual AssessmentItem? AssessmentItem { get; set; }

    public virtual AssessmentRule? AssessmentRule { get; set; }
}

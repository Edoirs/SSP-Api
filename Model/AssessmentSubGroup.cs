using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class AssessmentSubGroup
{
    public int AssessmentSubGroupId { get; set; }

    public int? AssessmentGroupId { get; set; }

    public string? AssessmentSubGroupName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AssessmentGroup? AssessmentGroup { get; set; }

    public virtual ICollection<AssessmentItem> AssessmentItems { get; set; } = new List<AssessmentItem>();
}

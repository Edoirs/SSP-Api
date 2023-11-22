using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class AssessmentGroup
{
    public int AssessmentGroupId { get; set; }

    public int? AssetTypeId { get; set; }

    public string? AssessmentGroupName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentItem> AssessmentItems { get; set; } = new List<AssessmentItem>();

    public virtual ICollection<AssessmentSubGroup> AssessmentSubGroups { get; set; } = new List<AssessmentSubGroup>();

    public virtual AssetType? AssetType { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapAssessmentAssessmentRule
{
    public long Aarid { get; set; }

    public long? AssessmentId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssetId { get; set; }

    public int? ProfileId { get; set; }

    public int? AssessmentRuleId { get; set; }

    public int? AssessmentYear { get; set; }

    public decimal? AssessmentAmount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Assessment? Assessment { get; set; }

    public virtual ICollection<MapAssessmentAssessmentItem> MapAssessmentAssessmentItems { get; set; } = new List<MapAssessmentAssessmentItem>();
}

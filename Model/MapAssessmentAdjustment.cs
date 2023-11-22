using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapAssessmentAdjustment
{
    public long Aadid { get; set; }

    public long? Aaiid { get; set; }

    public DateTime? AdjustmentDate { get; set; }

    public int? AdjustmentTypeId { get; set; }

    public string? AdjustmentLine { get; set; }

    public decimal? Amount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MapAssessmentAssessmentItem? Aai { get; set; }
}

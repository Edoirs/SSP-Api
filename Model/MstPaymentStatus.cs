using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MstPaymentStatus
{
    public int PaymentStatusId { get; set; }

    public string? PaymentStatusName { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<MapAssessmentAssessmentItem> MapAssessmentAssessmentItems { get; set; } = new List<MapAssessmentAssessmentItem>();
}

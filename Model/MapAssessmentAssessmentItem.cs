using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapAssessmentAssessmentItem
{
    public long Aaiid { get; set; }

    public long? Aarid { get; set; }

    public int? AssessmentItemId { get; set; }

    public decimal? TaxBaseAmount { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? TaxAmount { get; set; }

    public int? PaymentStatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MapAssessmentAssessmentRule? Aar { get; set; }

    public virtual AssessmentItem? AssessmentItem { get; set; }

    public virtual ICollection<MapAssessmentAdjustment> MapAssessmentAdjustments { get; set; } = new List<MapAssessmentAdjustment>();

    public virtual ICollection<MapSettlementSettlementItem> MapSettlementSettlementItems { get; set; } = new List<MapSettlementSettlementItem>();

    public virtual MstPaymentStatus? PaymentStatus { get; set; }
}

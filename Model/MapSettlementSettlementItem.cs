using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapSettlementSettlementItem
{
    public long Siid { get; set; }

    public int? SettlementId { get; set; }

    public long? Aaiid { get; set; }

    public long? Sbsiid { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? SettlementAmount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual MapAssessmentAssessmentItem? Aai { get; set; }

    public virtual MapServiceBillMdaserviceItem? Sbsi { get; set; }

    public virtual Settlement? Settlement { get; set; }
}

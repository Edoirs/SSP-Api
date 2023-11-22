using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapServiceBillMdaserviceItem
{
    public long Sbsiid { get; set; }

    public long? Sbsid { get; set; }

    public int? MdaserviceItemId { get; set; }

    public decimal? ServiceBaseAmount { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? ServiceAmount { get; set; }

    public int? PaymentStatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapServiceBillAdjustment> MapServiceBillAdjustments { get; set; } = new List<MapServiceBillAdjustment>();

    public virtual ICollection<MapServiceBillLateCharge> MapServiceBillLateCharges { get; set; } = new List<MapServiceBillLateCharge>();

    public virtual ICollection<MapSettlementSettlementItem> MapSettlementSettlementItems { get; set; } = new List<MapSettlementSettlementItem>();

    public virtual MdaServiceItem? MdaserviceItem { get; set; }

    public virtual MapServiceBillMdaservice? Sbs { get; set; }
}

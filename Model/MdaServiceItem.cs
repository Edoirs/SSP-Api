using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MdaServiceItem
{
    public int MdaserviceItemId { get; set; }

    public string? MdaserviceItemReferenceNo { get; set; }

    public int? RevenueStreamId { get; set; }

    public int? RevenueSubStreamId { get; set; }

    public int? AssessmentItemCategoryId { get; set; }

    public int? AssessmentItemSubCategoryId { get; set; }

    public int? AgencyId { get; set; }

    public string? MdaserviceItemName { get; set; }

    public int ComputationId { get; set; }

    public decimal? ServiceBaseAmount { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? ServiceAmount { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Agency? Agency { get; set; }

    public virtual AssessmentItemCategory? AssessmentItemCategory { get; set; }

    public virtual AssessmentItemSubCategory? AssessmentItemSubCategory { get; set; }

    public virtual MstComputation Computation { get; set; } = null!;

    public virtual ICollection<MapMdaserviceMdaserviceItem> MapMdaserviceMdaserviceItems { get; set; } = new List<MapMdaserviceMdaserviceItem>();

    public virtual ICollection<MapServiceBillMdaserviceItem> MapServiceBillMdaserviceItems { get; set; } = new List<MapServiceBillMdaserviceItem>();

    public virtual RevenueStream? RevenueStream { get; set; }

    public virtual RevenueSubStream? RevenueSubStream { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class AssessmentItem
{
    public int AssessmentItemId { get; set; }

    public string? AssessmentItemReferenceNo { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssessmentGroupId { get; set; }

    public int? AssessmentSubGroupId { get; set; }

    public int? RevenueStreamId { get; set; }

    public int? RevenueSubStreamId { get; set; }

    public int? AssessmentItemCategoryId { get; set; }

    public int? AssessmentItemSubCategoryId { get; set; }

    public int? AgencyId { get; set; }

    public string? AssessmentItemName { get; set; }

    public int? ComputationId { get; set; }

    public decimal? TaxBaseAmount { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? TaxAmount { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Agency? Agency { get; set; }

    public virtual AssessmentGroup? AssessmentGroup { get; set; }

    public virtual AssessmentItemCategory? AssessmentItemCategory { get; set; }

    public virtual AssessmentItemSubCategory? AssessmentItemSubCategory { get; set; }

    public virtual AssessmentSubGroup? AssessmentSubGroup { get; set; }

    public virtual AssetType? AssetType { get; set; }

    public virtual MstComputation? Computation { get; set; }

    public virtual ICollection<MapAssessmentAssessmentItem> MapAssessmentAssessmentItems { get; set; } = new List<MapAssessmentAssessmentItem>();

    public virtual ICollection<MapAssessmentRuleAssessmentItem> MapAssessmentRuleAssessmentItems { get; set; } = new List<MapAssessmentRuleAssessmentItem>();

    public virtual RevenueStream? RevenueStream { get; set; }

    public virtual RevenueSubStream? RevenueSubStream { get; set; }
}

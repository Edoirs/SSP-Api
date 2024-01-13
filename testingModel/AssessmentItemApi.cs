using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class AssessmentItemApi
{
    public int TaxPayerId { get; set; }

    public int TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public string? TaxPayerRin { get; set; }

    public int? AssetId { get; set; }

    public int? AssetTypeId { get; set; }

    public string? AssetTypeName { get; set; }

    public string? AssetRin { get; set; }

    public int? ProfileId { get; set; }

    public string? ProfileReferenceNo { get; set; }

    public string? ProfileDescription { get; set; }

    public string? AssessmentRuleId { get; set; }

    public string? AssessmentRuleCode { get; set; }

    public string? AssessmentRuleName { get; set; }

    public int? AssessmentItemId { get; set; }

    public string? AssessmentItemReferenceNo { get; set; }

    public int? AssessmentGroupId { get; set; }

    public string? AssessmentGroupName { get; set; }

    public int? AssessmentSubGroupId { get; set; }

    public string? AssessmentSubGroupName { get; set; }

    public int? RevenueStreamId { get; set; }

    public string? RevenueStreamName { get; set; }

    public int? RevenueSubStreamId { get; set; }

    public string? RevenueSubStreamName { get; set; }

    public int? AssessmentItemCategoryId { get; set; }

    public string? AssessmentItemCategoryName { get; set; }

    public int? AssessmentItemSubCategoryId { get; set; }

    public string? AssessmentItemSubCategoryName { get; set; }

    public int? AgencyId { get; set; }

    public string? AgencyName { get; set; }

    public string? AssessmentItemName { get; set; }

    public int? ComputationId { get; set; }

    public string? ComputationName { get; set; }

    public string? TaxBaseAmount { get; set; }

    public string? Percentage { get; set; }

    public string? TaxAmount { get; set; }

    public string? Id { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class AssessmentsApi
{
    public int TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public string TaxPayerRin { get; set; } = null!;

    public int? AssetId { get; set; }

    public int? AssetTypeId { get; set; }

    public string? AssetTypeName { get; set; }

    public string? AssetRin { get; set; }

    public string? ProfileId { get; set; }

    public string? ProfileReferenceNo { get; set; }

    public string? ProfileDescription { get; set; }

    public int AssessmentId { get; set; }

    public string? AssessmentRefNo { get; set; }

    public DateTime? AssessmentDate { get; set; }

    public double? AssessmentAmount { get; set; }

    public DateTime? SettlementDueDate { get; set; }

    public int? SettlementStatusId { get; set; }

    public string? SettlementStatusName { get; set; }

    public DateTime? SettlementDate { get; set; }

    public string? AssessmentNotes { get; set; }

    public int? AssessmentRuleId { get; set; }

    public string? AssessmentRuleCode { get; set; }

    public string? AssessmentRuleName { get; set; }

    public double? AssessmentRuleAmount { get; set; }

    public int? AssessmentItemId { get; set; }

    public string? AssessmentItemReferenceNo { get; set; }

    public string? AssessmentItemName { get; set; }

    public double? TaxBaseAmount { get; set; }

    public int? Percentage { get; set; }

    public double? TaxAmount { get; set; }
}

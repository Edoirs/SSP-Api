using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class PreAssessmentRdmBkp2
{
    public int AssessmentRdmId { get; set; }

    public string? AssessmentRefNo { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssetId { get; set; }

    public int? ProfileId { get; set; }

    public int? AssessmentRuleId { get; set; }

    public string? TaxYear { get; set; }

    public int? AssessmentItemId { get; set; }

    public double? TaxBaseAmount { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateAt { get; set; }

    public string? Status { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ApiId { get; set; }

    public string? AssetRin { get; set; }

    public string? TaxPayerRin { get; set; }

    public string? AssessmentItemName { get; set; }

    public string? AssessmentRuleName { get; set; }
}

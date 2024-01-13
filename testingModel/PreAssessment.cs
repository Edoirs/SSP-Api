using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class PreAssessment
{
    public long AssessId { get; set; }

    public int AssessCreateBy { get; set; }

    public DateTime AssessCreateAt { get; set; }

    public string? AssessmentRef { get; set; }

    public DateTime AssessmentDate { get; set; }

    public int TaxPayerType { get; set; }

    public string TaxPayerRin { get; set; } = null!;

    public string TaxPayerName { get; set; } = null!;

    public int AssetType { get; set; }

    public int AssetRin { get; set; }

    public int ProfileRef { get; set; }

    public int RuleCode { get; set; }

    public string AssessmentRule { get; set; } = null!;

    public int TaxYear { get; set; }

    public double AssessmentAmount { get; set; }

    public DateTime SettlementDueDate { get; set; }

    public string SettlementStatus { get; set; } = null!;

    public DateTime? SettlementDate { get; set; }

    public string? CompanyTin { get; set; }

    public int? AssessmentStatus { get; set; }

    public int? AssessmentApprovalStatus { get; set; }

    public string? CompanyRin { get; set; }
}

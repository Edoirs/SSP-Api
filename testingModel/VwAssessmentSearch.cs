using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class VwAssessmentSearch
{
    public string? AssessmentRef { get; set; }

    public DateTime AssessmentDate { get; set; }

    public string? TptypeStatus { get; set; }

    public string? TaxPayerType { get; set; }

    public int TaxYear { get; set; }

    public string TaxPayerRin { get; set; } = null!;

    public string TaxPayerName { get; set; } = null!;

    public double AssessmentAmount { get; set; }

    public string SettlementStatus { get; set; } = null!;

    public string? SStatus { get; set; }

    public string? AssessmentStatus { get; set; }

    public int? AssessmentStatus1 { get; set; }

    public int? AssessmentApprovalStatus { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanyTin { get; set; }

    public string? CompanyRin { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class VwPaymentDetail
{
    public int TaxYear { get; set; }

    public double AssessmentAmount { get; set; }

    public int? AssessmentApprovalStatus { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanyTin { get; set; }

    public string EmailAddress1 { get; set; } = null!;

    public string MobileNumber1 { get; set; } = null!;

    public string? AssessmentRef { get; set; }

    public string? CompanyRin { get; set; }

    public string Expr1 { get; set; } = null!;
}

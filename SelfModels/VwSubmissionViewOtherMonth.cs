using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwSubmissionViewOtherMonth
{
    public string? TaxPayer { get; set; }

    public string? Asset { get; set; }

    public int? TaxYear { get; set; }

    public int? TaxMonth { get; set; }

    public string? AssessmentItemName { get; set; }

    public string? TaxBaseAmount { get; set; }

    public string? SubmissionNotes { get; set; }

    public string? Status { get; set; }

    public string? CompanyName { get; set; }

    public string? AssessmentRuleName { get; set; }
}

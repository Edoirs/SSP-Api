using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class SubmissionsBkpaa
{
    public string? TaxPayer { get; set; }

    public string? Asset { get; set; }

    public string? AssessmentRule { get; set; }

    public int? TaxYear { get; set; }

    public int? TaxMonth { get; set; }

    public string? AssessmentItems { get; set; }

    public string? TaxBaseAmount { get; set; }

    public string? SubmissionNotes { get; set; }

    public string? Status { get; set; }
}

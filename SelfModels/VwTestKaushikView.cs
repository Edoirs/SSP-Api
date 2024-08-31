using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwTestKaushikView
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

    public int TaxPayerTypeId { get; set; }

    public long TaxPayerId { get; set; }

    public string? CompanyName { get; set; }

    public long CompanyId { get; set; }

    public string? AssessmentRuleId { get; set; }

    public int? AssessmentItemId { get; set; }

    public long BusinessId { get; set; }

    public int AssetTypeId { get; set; }

    public string? Expr1 { get; set; }
}

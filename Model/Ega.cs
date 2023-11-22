using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Ega
{
    public int Egaid { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssetId { get; set; }

    public int? ProfileId { get; set; }

    public int? AssessmentRuleId { get; set; }

    public int? AssessmentItemId { get; set; }

    public decimal? TaxBaseAmount { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? Result { get; set; }

    public string? ErrorMessage { get; set; }

    public string? BillRefNo { get; set; }
}

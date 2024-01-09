using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class RefNoPopulate
{
    public string? BusinessName { get; set; }

    public string? BusinessAddress { get; set; }

    public int? AssessmentYear { get; set; }

    public int? Assessmentruleid { get; set; }

    public long? Assessmentid { get; set; }

    public string? AssessmentRefNo { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? AssetId { get; set; }

    public int? AssetTypeId { get; set; }

    public decimal? AssessmentAmount { get; set; }

    public string? BusinessRin { get; set; }
}

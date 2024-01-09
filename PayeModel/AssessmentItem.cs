using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class AssessmentItem
{
    public long AssessItemId { get; set; }

    public int AssessItemCreateBy { get; set; }

    public DateTime AssessItemCreateAt { get; set; }

    public string ItemRef { get; set; } = null!;

    public int AssetType { get; set; }

    public int AssessmentGroup { get; set; }

    public int AssessmentSubGroup { get; set; }

    public int RevenueStream { get; set; }

    public int RevenueSubStream { get; set; }

    public int ItemCategory { get; set; }

    public int ItemSubCategory { get; set; }

    public int RevenueAgency { get; set; }

    public string AssessmentItemName { get; set; } = null!;

    public string Computation { get; set; } = null!;

    public double TaxBaseAmount { get; set; }

    public double? Percentage { get; set; }

    public double TaxAmount { get; set; }

    public double? EarlyAmount { get; set; }

    public double? LateAmount { get; set; }
}

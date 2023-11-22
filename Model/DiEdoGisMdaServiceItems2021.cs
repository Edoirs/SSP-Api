using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class DiEdoGisMdaServiceItems2021
{
    public double? Ref { get; set; }

    public int? MdaserviceItemId { get; set; }

    public string? MdaserviceItemName { get; set; }

    public int? RevenueStreamId { get; set; }

    public string? RevenueStreamName { get; set; }

    public int? RevenueSubStreamId { get; set; }

    public string? RevenueSubStreamName { get; set; }

    public int? ItemCategoryId { get; set; }

    public string? ItemCategoryName { get; set; }

    public int? ItemSubCategoryId { get; set; }

    public string? ItemSubCategoryName { get; set; }

    public int? RevenueAgencyId { get; set; }

    public string? RevenueAgencyName { get; set; }

    public double? TaxBaseAmount { get; set; }

    public int? ComputationId { get; set; }

    public string? ComputationName { get; set; }

    public double? Percentage { get; set; }

    public double? TaxAmount { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class AssetTaxPayerDetailsApi
{
    public int Tpaid { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public int? TaxPayerId { get; set; }

    public string? TaxPayerName { get; set; }

    public string? TaxPayerRinnumber { get; set; }

    public string? TaxPayerEmailAddress { get; set; }

    public string? TaxPayerMobileNumber { get; set; }

    public int? AssetTypeId { get; set; }

    public string? AssetTypeName { get; set; }

    public int? TaxPayerRoleId { get; set; }

    public string? TaxPayerRoleName { get; set; }

    public int? AssetId { get; set; }

    public string? AssetLga { get; set; }

    public string? AssetRin { get; set; }

    public string? AssetName { get; set; }

    public string? BuildingUnitId { get; set; }

    public string? UnitNumber { get; set; }

    public string? Active { get; set; }

    public string? ActiveText { get; set; }

    public DateTime? DateCreated { get; set; }

    public int Id { get; set; }

    public int? ApiId { get; set; }

    public string? AssetAddress { get; set; }
}

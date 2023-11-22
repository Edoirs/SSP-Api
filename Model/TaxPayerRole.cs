using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TaxPayerRole
{
    public int TaxPayerRoleId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? TaxPayerRoleName { get; set; }

    public bool? IsMultiLinkable { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AssetType? AssetType { get; set; }

    public virtual ICollection<MapTaxPayerAsset> MapTaxPayerAssets { get; set; } = new List<MapTaxPayerAsset>();

    public virtual TaxPayerType? TaxPayerType { get; set; }
}

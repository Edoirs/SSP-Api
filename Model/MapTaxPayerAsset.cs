using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTaxPayerAsset
{
    public long Tpaid { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? TaxPayerRoleId { get; set; }

    public int? AssetId { get; set; }

    public int? BuildingUnitId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AssetType? AssetType { get; set; }

    public virtual ICollection<MapTaxPayerAssetProfile> MapTaxPayerAssetProfiles { get; set; } = new List<MapTaxPayerAssetProfile>();

    public virtual TaxPayerType? TaxPayer { get; set; }

    public virtual TaxPayerRole? TaxPayerRole { get; set; }
}

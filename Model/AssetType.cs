using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class AssetType
{
    public int AssetTypeId { get; set; }

    public string? AssetTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentGroup> AssessmentGroups { get; set; } = new List<AssessmentGroup>();

    public virtual ICollection<AssessmentItem> AssessmentItems { get; set; } = new List<AssessmentItem>();

    public virtual ICollection<Building> Buildings { get; set; } = new List<Building>();

    public virtual ICollection<Business> Businesses { get; set; } = new List<Business>();

    public virtual ICollection<Land> Lands { get; set; } = new List<Land>();

    public virtual ICollection<MapTaxPayerAsset> MapTaxPayerAssets { get; set; } = new List<MapTaxPayerAsset>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<ProfilesBkp> ProfilesBkps { get; set; } = new List<ProfilesBkp>();

    public virtual ICollection<TaxPayerRole> TaxPayerRoles { get; set; } = new List<TaxPayerRole>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}

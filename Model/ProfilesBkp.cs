using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class ProfilesBkp
{
    public int ProfileId { get; set; }

    public string? ProfileReferenceNo { get; set; }

    public string? ProfileDescription { get; set; }

    public int? AssetTypeStatus { get; set; }

    public int? AssetTypeId { get; set; }

    public int? ProfileTypeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentRule> AssessmentRules { get; set; } = new List<AssessmentRule>();

    public virtual AssetType? AssetType { get; set; }

    public virtual ICollection<MapTaxPayerAssetProfile> MapTaxPayerAssetProfiles { get; set; } = new List<MapTaxPayerAssetProfile>();

    public virtual ICollection<ProfileAttribute> ProfileAttributes { get; set; } = new List<ProfileAttribute>();

    public virtual ICollection<ProfileGroup> ProfileGroups { get; set; } = new List<ProfileGroup>();

    public virtual ICollection<ProfileSectorElement> ProfileSectorElements { get; set; } = new List<ProfileSectorElement>();

    public virtual ICollection<ProfileSectorSubElement> ProfileSectorSubElements { get; set; } = new List<ProfileSectorSubElement>();

    public virtual ICollection<ProfileSector> ProfileSectors { get; set; } = new List<ProfileSector>();

    public virtual ICollection<ProfileSubAttribute> ProfileSubAttributes { get; set; } = new List<ProfileSubAttribute>();

    public virtual ICollection<ProfileSubGroup> ProfileSubGroups { get; set; } = new List<ProfileSubGroup>();

    public virtual ICollection<ProfileSubSector> ProfileSubSectors { get; set; } = new List<ProfileSubSector>();

    public virtual ICollection<ProfileTaxPayerRole> ProfileTaxPayerRoles { get; set; } = new List<ProfileTaxPayerRole>();

    public virtual ICollection<ProfileTaxPayerType> ProfileTaxPayerTypes { get; set; } = new List<ProfileTaxPayerType>();
}

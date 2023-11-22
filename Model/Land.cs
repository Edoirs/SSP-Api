using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Land
{
    public int LandId { get; set; }

    public string? LandRin { get; set; }

    public string? PlotNumber { get; set; }

    public string? StreetName { get; set; }

    public int? TownId { get; set; }

    public int? Lgaid { get; set; }

    public int? WardId { get; set; }

    public int? AssetTypeId { get; set; }

    public decimal? LandSizeLength { get; set; }

    public decimal? LandSizeWidth { get; set; }

    public string? COfORef { get; set; }

    public int? LandDevelopmentId { get; set; }

    public int? LandPurposeId { get; set; }

    public int? LandFunctionId { get; set; }

    public int? LandOwnershipId { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public decimal? ValueOfLand { get; set; }

    public int? LandStreetConditionId { get; set; }

    public string? Neighborhood { get; set; }

    public string? LandOccupier { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? DataSourceId { get; set; }

    public long? DsrefId { get; set; }

    public virtual AssetType? AssetType { get; set; }

    public virtual LandDevelopment? LandDevelopment { get; set; }

    public virtual LandFunction? LandFunction { get; set; }

    public virtual LandOwnership? LandOwnership { get; set; }

    public virtual LandPurpose? LandPurpose { get; set; }

    public virtual LandStreetCondition? LandStreetCondition { get; set; }

    public virtual Lga? Lga { get; set; }

    public virtual ICollection<MapBuildingLand> MapBuildingLands { get; set; } = new List<MapBuildingLand>();

    public virtual Town? Town { get; set; }

    public virtual Ward? Ward { get; set; }
}

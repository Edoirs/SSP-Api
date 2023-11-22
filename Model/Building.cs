using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Building
{
    public int BuildingId { get; set; }

    public string? BuildingRin { get; set; }

    public string? BuildingTagNumber { get; set; }

    public string? BuildingName { get; set; }

    public string? BuildingNumber { get; set; }

    public string? StreetName { get; set; }

    public string? OffStreetName { get; set; }

    public int? TownId { get; set; }

    public int? Lgaid { get; set; }

    public int? WardId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? BuildingTypeId { get; set; }

    public int? BuildingCompletionId { get; set; }

    public int? BuildingPurposeId { get; set; }

    public int? BuildingOwnershipId { get; set; }

    public int? NoOfUnits { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public decimal? BuildingSizeLength { get; set; }

    public decimal? BuildingSizeWidth { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? DataSourceId { get; set; }

    public long? DsrefId { get; set; }

    public virtual AssetType? AssetType { get; set; }

    public virtual BuildingCompletion? BuildingCompletion { get; set; }

    public virtual BuildingOwnership? BuildingOwnership { get; set; }

    public virtual BuildingPurpose? BuildingPurpose { get; set; }

    public virtual BuildingType? BuildingType { get; set; }

    public virtual Lga? Lga { get; set; }

    public virtual ICollection<MapBuildingBuildingUnit> MapBuildingBuildingUnits { get; set; } = new List<MapBuildingBuildingUnit>();

    public virtual ICollection<MapBuildingLand> MapBuildingLands { get; set; } = new List<MapBuildingLand>();

    public virtual ICollection<MapBusinessBuilding> MapBusinessBuildings { get; set; } = new List<MapBusinessBuilding>();

    public virtual ICollection<MapCompanyAddressInformation> MapCompanyAddressInformations { get; set; } = new List<MapCompanyAddressInformation>();

    public virtual ICollection<MapGovernmentAddressInformation> MapGovernmentAddressInformations { get; set; } = new List<MapGovernmentAddressInformation>();

    public virtual ICollection<MapIndividualAddressInformation> MapIndividualAddressInformations { get; set; } = new List<MapIndividualAddressInformation>();

    public virtual ICollection<MapSpecialAddressInformation> MapSpecialAddressInformations { get; set; } = new List<MapSpecialAddressInformation>();

    public virtual ICollection<TaxOffice> TaxOffices { get; set; } = new List<TaxOffice>();

    public virtual Town? Town { get; set; }

    public virtual Ward? Ward { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Business
{
    public int BusinessId { get; set; }

    public int? BusinessTypeId { get; set; }

    public string? BusinessRin { get; set; }

    public string? BusinessName { get; set; }

    public int? Lgaid { get; set; }

    public int? AssetTypeId { get; set; }

    public int? BusinessCategoryId { get; set; }

    public int? BusinessSectorId { get; set; }

    public int? BusinessSubSectorId { get; set; }

    public int? BusinessStructureId { get; set; }

    public int? BusinessOperationId { get; set; }

    public int? SizeId { get; set; }

    public string? ContactName { get; set; }

    public string? BusinessNumber { get; set; }

    public string? BusinessAddress { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? DataSourceId { get; set; }

    public long? DsrefId { get; set; }

    public int? ZoneId { get; set; }

    public int? TaxOfficeId { get; set; }

    public virtual AssetType? AssetType { get; set; }

    public virtual BusinessCategory? BusinessCategory { get; set; }

    public virtual BusinessOperation? BusinessOperation { get; set; }

    public virtual BusinessSector? BusinessSector { get; set; }

    public virtual BusinessStructure? BusinessStructure { get; set; }

    public virtual BusinessSubSector? BusinessSubSector { get; set; }

    public virtual BusinessType? BusinessType { get; set; }

    public virtual Lga? Lga { get; set; }

    public virtual ICollection<MapBusinessBuilding> MapBusinessBuildings { get; set; } = new List<MapBusinessBuilding>();

    public virtual Size? Size { get; set; }
}

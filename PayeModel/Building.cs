using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class Building
{
    public long BuildingId { get; set; }

    public int BuildingCreateBy { get; set; }

    public DateTime BuildingCreateAt { get; set; }

    public long BuildingRin { get; set; }

    public string BuildingTagNumber { get; set; } = null!;

    public string? BuildingName { get; set; }

    public string BuildingNumber { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string OffStreetName { get; set; } = null!;

    public int Town { get; set; }

    public int Lga { get; set; }

    public int Ward { get; set; }

    public int AssetType { get; set; }

    public int BuildingType { get; set; }

    public int BuildingCompletion { get; set; }

    public int BuildingPurpose { get; set; }

    public string BuildingFunction { get; set; } = null!;

    public int? BuildingOwnership { get; set; }

    public int BuildingAccupancy { get; set; }

    public int BuildingAccupancyType { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string Profile { get; set; } = null!;

    public string Status { get; set; } = null!;
}

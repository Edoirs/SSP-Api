using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwBuilding
{
    public int BuildingId { get; set; }

    public string? BuildingRin { get; set; }

    public string? StreetName { get; set; }

    public string? BuildingPurposeName { get; set; }

    public bool? Active { get; set; }

    public string? BuildingName { get; set; }
}

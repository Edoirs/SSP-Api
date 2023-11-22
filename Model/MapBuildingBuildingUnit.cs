using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapBuildingBuildingUnit
{
    public long Bbuid { get; set; }

    public int? BuildingId { get; set; }

    public int? BuildingUnitId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Building? Building { get; set; }

    public virtual BuildingUnit? BuildingUnit { get; set; }
}

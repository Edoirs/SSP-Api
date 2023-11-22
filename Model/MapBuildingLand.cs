using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapBuildingLand
{
    public long Blid { get; set; }

    public int? BuildingId { get; set; }

    public int? LandId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Building? Building { get; set; }

    public virtual Land? Land { get; set; }
}

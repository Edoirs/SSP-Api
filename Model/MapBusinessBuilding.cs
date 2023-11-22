using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapBusinessBuilding
{
    public long Bbid { get; set; }

    public int? BuildingId { get; set; }

    public int? BusinessId { get; set; }

    public int? BuildingUnitId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Building? Building { get; set; }

    public virtual Business? Business { get; set; }
}

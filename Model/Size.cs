using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Size
{
    public int SizeId { get; set; }

    public string? SizeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<BuildingUnit> BuildingUnits { get; set; } = new List<BuildingUnit>();

    public virtual ICollection<Business> Businesses { get; set; } = new List<Business>();
}

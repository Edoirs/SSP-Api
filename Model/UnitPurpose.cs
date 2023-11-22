using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class UnitPurpose
{
    public int UnitPurposeId { get; set; }

    public string? UnitPurposeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<BuildingUnit> BuildingUnits { get; set; } = new List<BuildingUnit>();

    public virtual ICollection<UnitFunction> UnitFunctions { get; set; } = new List<UnitFunction>();
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class BuildingUnit
{
    public int BuildingUnitId { get; set; }

    public string? BuildingUnitRin { get; set; }

    public string? UnitNumber { get; set; }

    public int? UnitPurposeId { get; set; }

    public int? UnitFunctionId { get; set; }

    public int? UnitOccupancyId { get; set; }

    public int? SizeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapBuildingBuildingUnit> MapBuildingBuildingUnits { get; set; } = new List<MapBuildingBuildingUnit>();

    public virtual Size? Size { get; set; }

    public virtual UnitFunction? UnitFunction { get; set; }

    public virtual UnitOccupancy? UnitOccupancy { get; set; }

    public virtual UnitPurpose? UnitPurpose { get; set; }
}

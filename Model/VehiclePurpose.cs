using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VehiclePurpose
{
    public int VehiclePurposeId { get; set; }

    public string? VehiclePurposeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<VehicleFunction> VehicleFunctions { get; set; } = new List<VehicleFunction>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}

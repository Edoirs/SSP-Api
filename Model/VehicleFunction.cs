using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VehicleFunction
{
    public int VehicleFunctionId { get; set; }

    public string? VehicleFunctionName { get; set; }

    public int? VehiclePurposeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual VehiclePurpose? VehiclePurpose { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VehicleSubType
{
    public int VehicleSubTypeId { get; set; }

    public string? VehicleSubTypeName { get; set; }

    public int? VehicleTypeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual VehicleType? VehicleType { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}

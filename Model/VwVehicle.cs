using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwVehicle
{
    public int VehicleId { get; set; }

    public string? VehicleRin { get; set; }

    public string? VehicleRegNumber { get; set; }

    public string? VehicleSubTypeName { get; set; }

    public string? VehiclePurposeName { get; set; }
}

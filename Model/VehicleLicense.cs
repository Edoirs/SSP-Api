using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VehicleLicense
{
    public int VehicleLicenseId { get; set; }

    public int? VehicleId { get; set; }

    public string? LicenseNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? VehicleInsuranceId { get; set; }

    public int? LicenseStatusId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Vehicle? Vehicle { get; set; }

    public virtual VehicleInsurance? VehicleInsurance { get; set; }
}

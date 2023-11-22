using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string? VehicleRin { get; set; }

    public string? VehicleRegNumber { get; set; }

    public string? Vin { get; set; }

    public int? AssetTypeId { get; set; }

    public int? VehicleTypeId { get; set; }

    public int? VehicleSubTypeId { get; set; }

    public int? Lgaid { get; set; }

    public int? VehiclePurposeId { get; set; }

    public int? VehicleFunctionId { get; set; }

    public int? VehicleOwnershipId { get; set; }

    public string? VehicleDescription { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? DataSourceId { get; set; }

    public long? DsrefId { get; set; }

    public virtual AssetType? AssetType { get; set; }

    public virtual Lga? Lga { get; set; }

    public virtual VehicleFunction? VehicleFunction { get; set; }

    public virtual ICollection<VehicleInsurance> VehicleInsurances { get; set; } = new List<VehicleInsurance>();

    public virtual ICollection<VehicleLicense> VehicleLicenses { get; set; } = new List<VehicleLicense>();

    public virtual VehicleOwnership? VehicleOwnership { get; set; }

    public virtual VehiclePurpose? VehiclePurpose { get; set; }

    public virtual VehicleSubType? VehicleSubType { get; set; }

    public virtual VehicleType? VehicleType { get; set; }
}

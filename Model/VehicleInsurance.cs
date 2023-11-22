using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VehicleInsurance
{
    public int VehicleInsuranceId { get; set; }

    public int? VehicleId { get; set; }

    public string? InsuranceCertificateNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? CoverTypeId { get; set; }

    public int? InsuranceStatusId { get; set; }

    public decimal? PremiumAmount { get; set; }

    public decimal? VerificationAmount { get; set; }

    public decimal? BrokerAmount { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Vehicle? Vehicle { get; set; }

    public virtual ICollection<VehicleLicense> VehicleLicenses { get; set; } = new List<VehicleLicense>();
}

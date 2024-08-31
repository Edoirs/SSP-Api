using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class UserManagement
{
    public int Id { get; set; }

    public int VerificationOtp { get; set; }

    public string? CompanyRin { get; set; }

    public string? PhoneNumber { get; set; }

    public string UniqueId { get; set; } = null!;

    public long CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public long ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public string? Password { get; set; }

    public string? CompanyName { get; set; }

    public string? Email { get; set; }

    public int? TaxpayerTypeId { get; set; }
}

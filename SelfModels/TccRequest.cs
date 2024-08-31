using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class TccRequest
{
    public string EmployerId { get; set; } = null!;

    public string BusinessId { get; set; } = null!;

    public string EmployeeId { get; set; } = null!;

    public int? TccRequestYear { get; set; }

    public DateTime? DateRequested { get; set; }

    public string? RequestedById { get; set; }

    public string? FormH2pathName { get; set; }

    public int TccRequestRefNo { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwBusinessCompRelation
{
    public string? CompanyRin { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanyTin { get; set; }

    public string MobileNumber1 { get; set; } = null!;

    public string EmailAddress1 { get; set; } = null!;
}

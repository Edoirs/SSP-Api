using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwGovernment
{
    public int GovernmentId { get; set; }

    public string? GovernmentRin { get; set; }

    public string? GovernmentName { get; set; }

    public string? Tin { get; set; }

    public string? ContactAddress { get; set; }

    public int? TaxOfficeId { get; set; }
}

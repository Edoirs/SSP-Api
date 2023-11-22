using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwSpecial
{
    public int SpecialId { get; set; }

    public string? SpecialRin { get; set; }

    public string? SpecialTaxPayerName { get; set; }

    public string? Tin { get; set; }

    public string? ContactName { get; set; }

    public int? TaxOfficeId { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwCompany
{
    public int CompanyId { get; set; }

    public string? CompanyRin { get; set; }

    public string? CompanyName { get; set; }

    public string? Tin { get; set; }

    public string? ContactAddress { get; set; }

    public int? TaxOfficeId { get; set; }
}

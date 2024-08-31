using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwPayeInputFile
{
    public string BusinessRin { get; set; } = null!;

    public string TaxYear { get; set; } = null!;

    public string? CompanyRin { get; set; }

    public string? Tx { get; set; }

    public string? CompanyTin { get; set; }

    public string? BsnRin { get; set; }

    public string? CompanyName { get; set; }

    public string? BusinessName { get; set; }
}

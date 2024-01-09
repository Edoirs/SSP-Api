using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class VwGetDistinctInputFile
{
    public string? CompanyName { get; set; }

    public string CompanyRin { get; set; } = null!;

    public string? CompanyTin { get; set; }

    public string BusinessRin { get; set; } = null!;

    public string? BusinessName { get; set; }

    public string TaxYear { get; set; } = null!;
}

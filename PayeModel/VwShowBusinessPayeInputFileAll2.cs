using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class VwShowBusinessPayeInputFileAll2
{
    public string? BusinessRin { get; set; }

    public string BusinessName { get; set; } = null!;

    public int Totalcount { get; set; }

    public string TaxYear { get; set; } = null!;

    public string? CompanyRin { get; set; }

    public string? CompanyName { get; set; }

    public string CompanyTin { get; set; } = null!;

    public string Flag { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string FiledStatus { get; set; } = null!;

    public string CodedStatus { get; set; } = null!;

    public string SuccessfulStatus { get; set; } = null!;
}

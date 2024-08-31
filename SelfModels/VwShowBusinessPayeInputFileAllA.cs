using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwShowBusinessPayeInputFileAllA
{
    public string? BusinessRin { get; set; }

    public string? BusinessName { get; set; }

    public int? Totalcount { get; set; }

    public string TaxYear { get; set; } = null!;

    public string? CompanyRin { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyTin { get; set; }

    public int? Flag { get; set; }

    public string? Status { get; set; }

    public string? FiledStatus { get; set; }

    public string? CodedStatus { get; set; }

    public string? SuccessfulStatus { get; set; }
}

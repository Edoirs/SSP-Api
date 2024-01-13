using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class VwShowBusinessPayeInputFileAllSelected
{
    public string? BusinessRin { get; set; }

    public string? BusinessName { get; set; }

    public int? Totalcount { get; set; }

    public string TaxYear { get; set; } = null!;

    public string? CompanyRin { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyTin { get; set; }

    public int Flag { get; set; }

    public string Status { get; set; } = null!;

    public string FiledStatus { get; set; } = null!;

    public string CodedStatus { get; set; } = null!;

    public string SuccessfulStatus { get; set; } = null!;

    public string? AssessmentYear { get; set; }
}

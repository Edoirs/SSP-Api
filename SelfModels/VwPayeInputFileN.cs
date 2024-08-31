using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwPayeInputFileN
{
    public string BusinessRin { get; set; } = null!;

    public string TaxYear { get; set; } = null!;

    public string? CompanyTin { get; set; }

    public string? CompanyName { get; set; }

    public string? BusinessName { get; set; }

    public string? AssessmentYear { get; set; }

    public int? Status { get; set; }

    public string? CompanyRin { get; set; }

    public string? EmployerRin { get; set; }
}

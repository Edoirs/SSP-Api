using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class VwPateInputFile
{
    public string CompanyRin { get; set; } = null!;

    public string BusinessRin { get; set; } = null!;

    public string TaxYear { get; set; } = null!;

    public string? EmployerRin { get; set; }

    public string? AssessmentYear { get; set; }

    public int? Status { get; set; }

    public string? CmpRin { get; set; }

    public string? Tx { get; set; }

    public string? CompanyTin { get; set; }

    public string? BsnRin { get; set; }

    public string? CompanyName { get; set; }

    public string? BusinessName { get; set; }
}

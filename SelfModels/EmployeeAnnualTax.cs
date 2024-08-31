using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class EmployeeAnnualTax
{
    public string? EmployeeRin { get; set; }

    public string? AssessmentYear { get; set; }

    public decimal? AnnualTax { get; set; }
}

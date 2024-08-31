using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class PreAssessment
{
    public string? AssessmentMonth { get; set; }

    public string? AssessmentYear { get; set; }

    public decimal? Amount { get; set; }

    public string? EmployerRin { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwTaxComputationEmployerCollection
{
    public string? EmployerRin { get; set; }

    public string? Employername { get; set; }

    public string? AssessmentYear { get; set; }

    public decimal? Tax { get; set; }

    public string? AssessmentRuleName { get; set; }

    public string? AssessmentItemName { get; set; }

    public string? AssetRin { get; set; }
}

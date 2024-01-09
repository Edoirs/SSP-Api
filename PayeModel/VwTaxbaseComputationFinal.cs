using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class VwTaxbaseComputationFinal
{
    public int? AssessmentYear { get; set; }

    public string? EmployerRin { get; set; }

    public string? EmployerName { get; set; }

    public string? BusinessRin { get; set; }

    public string? Month { get; set; }

    public decimal? TaxAmt { get; set; }
}

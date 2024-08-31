using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwEmployerContribution
{
    public string? EmployerRin { get; set; }

    public string? EmployerName { get; set; }

    public string? AssessmentYear { get; set; }

    public int? EmployeeCount { get; set; }

    public decimal? Jan { get; set; }

    public decimal? Feb { get; set; }

    public decimal? Mar { get; set; }

    public decimal? Apr { get; set; }

    public decimal? May { get; set; }

    public decimal? Jun { get; set; }

    public decimal? Jul { get; set; }

    public decimal? Aug { get; set; }

    public decimal? Sep { get; set; }

    public decimal? Oct { get; set; }

    public decimal? Nov { get; set; }

    public decimal? Dec { get; set; }

    public string? TaxOffice { get; set; }

    public string BusinessRin { get; set; } = null!;
}

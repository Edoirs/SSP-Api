using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class EmployerMonthlyAssessmentHistory
{
    public int Id { get; set; }

    public string EmployerId { get; set; } = null!;

    public string BusinessId { get; set; } = null!;

    public string? EmployerRin { get; set; }

    public int TaxYear { get; set; }

    public string TaxMonth { get; set; } = null!;

    public decimal? TotalAmount { get; set; }

    public decimal? TotalAssessed { get; set; }

    public string? AssessmentRefNo { get; set; }

    public int? AssessmentRefId { get; set; }

    public string? AssCreatedBy { get; set; }

    public DateTime? AssCreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }
}

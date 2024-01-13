using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class VwPayment
{
    public string? AssessmentChildRef { get; set; }

    public string? AssessmentRef { get; set; }

    public string? MonthTax { get; set; }

    public string? YearTax { get; set; }

    public string? IsPaid { get; set; }

    public DateTime? PaidOn { get; set; }

    public DateTime? NotificationDate { get; set; }

    public decimal? Amount { get; set; }

    public string Status { get; set; } = null!;

    public string? CompanyRin { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanyTin { get; set; }
}

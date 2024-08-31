using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class EmployeesMonthlySchedule
{
    public int Id { get; set; }

    public string EmployerId { get; set; } = null!;

    public string? BusinessId { get; set; }

    public string? EmployeeRin { get; set; }

    public int? TaxYear { get; set; }

    public string? TaxMonth { get; set; }

    public decimal? Basic { get; set; }

    public decimal? Rent { get; set; }

    public decimal? Transport { get; set; }

    public decimal? OtherIncome { get; set; }

    public decimal? Pension { get; set; }

    public decimal? Nhf { get; set; }

    public decimal? Nhis { get; set; }

    public decimal? LifeAssurance { get; set; }

    public decimal? Cra { get; set; }

    public decimal? Tfp { get; set; }

    public decimal? Ci { get; set; }

    public decimal? Tax { get; set; }

    public int? AssessementStatusId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}

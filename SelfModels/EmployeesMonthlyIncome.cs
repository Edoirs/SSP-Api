using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class EmployeesMonthlyIncome : SelfBaseEntity
{
    public int Id { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string? BusinessId { get; set; }

    public string? CompanyId { get; set; }

    public decimal? Basic { get; set; }

    public decimal? Rent { get; set; }

    public decimal? Transport { get; set; }

    public decimal? Ltg { get; set; }

    public decimal? Utility { get; set; }

    public decimal? Meal { get; set; }

    public decimal? Others { get; set; }

    public decimal? Nhf { get; set; }

    public decimal? Nhis { get; set; }

    public decimal? Pension { get; set; }

    public decimal? LifeAssurance { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }
}

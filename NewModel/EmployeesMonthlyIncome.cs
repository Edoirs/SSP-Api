using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class EmployeesMonthlyIncome
{
    public string EmployeeId { get; set; } = null!;

    public string BusinessId { get; set; } = null!;

    public string Basic { get; set; } = null!;

    public decimal Rent { get; set; }

    public string Transport { get; set; } = null!;

    public string Ltg { get; set; } = null!;

    public decimal Utility { get; set; }

    public decimal Meal { get; set; }

    public string Others { get; set; } = null!;

    public string Nhf { get; set; } = null!;

    public string Nhis { get; set; } = null!;

    public decimal Pension { get; set; }

    public decimal LifeAssurance { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class EmployeesMonthlySchedule
{
    public int EmployeeId { get; set; }

    public int BusinessId { get; set; }

    public string CompanyId { get; set; } = null!;

    public int Year { get; set; }

    public int Month { get; set; }

    public int StatusId { get; set; }

    public string Basic { get; set; } = null!;

    public string Rent { get; set; } = null!;

    public string Transport { get; set; } = null!;

    public string Ltg { get; set; } = null!;

    public string Others { get; set; } = null!;

    public double TotalIncome { get; set; }

    public string Nhf { get; set; } = null!;

    public string Nhis { get; set; } = null!;

    public double Pension { get; set; }

    public double GrossIncome { get; set; }

    public string Cra { get; set; } = null!;

    public double TaxFreePay { get; set; }

    public double ChargableIncome { get; set; }

    public double Tax { get; set; }
}

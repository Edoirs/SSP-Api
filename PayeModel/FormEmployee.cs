using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class FormEmployee
{
    public int FormId { get; set; }

    public string? EmployeeId { get; set; }

    public string? BusinessId { get; set; }

    public string? CompanyId { get; set; }

    public string Basic { get; set; } = null!;

    public decimal Rent { get; set; }

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

    public string StatusId { get; set; } = null!;
}

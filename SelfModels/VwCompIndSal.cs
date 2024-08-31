using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwCompIndSal
{
    public long CompanyId { get; set; }

    public long IndId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Tin { get; set; }

    public long SalId { get; set; }

    public double? SalCalcTax { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanyTin { get; set; }

    public int Gender { get; set; }

    public int Title { get; set; }

    public double? SalGross { get; set; }

    public double? SalBasic { get; set; }

    public double? SalRent { get; set; }

    public double? SalTrans { get; set; }

    public double? SalPension { get; set; }

    public double? SalNhf { get; set; }

    public double? SalNhis { get; set; }

    public double? SalChIncome { get; set; }

    public double? SalTaxFreePay { get; set; }

    public double? SalCalcTaxMonthly { get; set; }

    public DateTime? StartDate { get; set; }

    public long? SalEmployeeId { get; set; }

    public string CompanyRin { get; set; } = null!;

    public string? CompanyRinOk { get; set; }

    public DateTime? SalCreateAt { get; set; }

    public string? Address { get; set; }

    public int? NationalityId { get; set; }

    public string? Nationality { get; set; }

    public DateTime? EndDate { get; set; }

    public string UserRin { get; set; } = null!;

    public string DateOfBirth { get; set; } = null!;

    public string MobileNumber1 { get; set; } = null!;

    public string? EmailAddress1 { get; set; }

    public string? IsValidated { get; set; }
}

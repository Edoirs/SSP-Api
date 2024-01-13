using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class SalaryBreakup
{
    public long SalId { get; set; }

    public int? SalCreateBy { get; set; }

    public DateTime? SalCreateAt { get; set; }

    public long? SalEmployeeId { get; set; }

    public double? SalGross { get; set; }

    public double? SalBasic { get; set; }

    public double? SalRent { get; set; }

    public double? SalTrans { get; set; }

    public double? SalPension { get; set; }

    public double? SalPensionDeclared { get; set; }

    public double? SalNhf { get; set; }

    public double? SalNhfDeclared { get; set; }

    public double? SalNhis { get; set; }

    public double? SalNhisDeclared { get; set; }

    public double? SalChIncome { get; set; }

    public double? SalTaxFreePay { get; set; }

    public double? SalCalcTax { get; set; }

    public double? SalCalcTaxMonthly { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? SalCra { get; set; }

    public decimal? SalUtility { get; set; }

    public decimal? SalMeal { get; set; }

    public decimal? SalOtherallowances { get; set; }

    public decimal? SalLtg { get; set; }
}

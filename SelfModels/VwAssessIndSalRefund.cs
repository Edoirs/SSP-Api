using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwAssessIndSalRefund
{
    public long IndId { get; set; }

    public string? CompanyRin { get; set; }

    public DateTime AssessmentDate { get; set; }

    public double? SalGross { get; set; }

    public double? SalBasic { get; set; }

    public double? SalRent { get; set; }

    public double? SalTrans { get; set; }

    public double? SalPension { get; set; }

    public double? SalPensionDeclared { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? SalCalcTaxMonthly { get; set; }

    public double? SalCalcTax { get; set; }
}

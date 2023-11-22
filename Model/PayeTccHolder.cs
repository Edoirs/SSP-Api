using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class PayeTccHolder
{
    public int Id { get; set; }

    public string? IndividualRin { get; set; }

    public double? AnnualGross { get; set; }

    public double? Cra { get; set; }

    public double? ValidatedPension { get; set; }

    public double? ValidatedNhf { get; set; }

    public double? ValidatedNhis { get; set; }

    public double? TaxFreePay { get; set; }

    public double? ChargeableIncome { get; set; }

    public double? AnnualTax { get; set; }

    public double? AnnualTaxIi { get; set; }

    public double? MonthlyTax { get; set; }

    public int? RowId { get; set; }

    public string? AssessmentYear { get; set; }

    public string? BusinessName { get; set; }

    public string? ReceiptDetail { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class EmBankStatement
{
    public long Bsid { get; set; }

    public int? TaxYear { get; set; }

    public int? TaxMonth { get; set; }

    public string? PaymentRefNumber { get; set; }

    public string? PaymentDateTime { get; set; }

    public string? CustomerName { get; set; }

    public string? Category { get; set; }

    public string? RevenueHead { get; set; }

    public string? Bank { get; set; }

    public decimal? Amount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}

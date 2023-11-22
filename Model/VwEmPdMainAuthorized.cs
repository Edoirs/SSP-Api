using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwEmPdMainAuthorized
{
    public int? TaxMonth { get; set; }

    public int? TaxYear { get; set; }

    public string? PaymentRefNumber { get; set; }

    public string? PaymentDateTime { get; set; }

    public string? Rin { get; set; }

    public string? CustomerName { get; set; }

    public decimal? Amount { get; set; }

    public string? Bank { get; set; }

    public string? TaxPayerType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long Pdmaid { get; set; }
}

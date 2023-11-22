using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TaxCredit
{
    public long TaxCreditId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxYear { get; set; }

    public DateTime? CreditDate { get; set; }

    public string? Description { get; set; }

    public decimal? Amount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

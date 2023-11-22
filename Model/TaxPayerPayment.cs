using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TaxPayerPayment
{
    public int Tppid { get; set; }

    public string? TransactionRefNo { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? TransactionTypeId { get; set; }

    public string? TransactionDescription { get; set; }

    public decimal? TransactionAmount { get; set; }

    public int? PaymentMethodId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

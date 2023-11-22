using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwPaymentAccount
{
    public long PaymentAccountId { get; set; }

    public string? PaymentRefNo { get; set; }

    public string? PaymentDate { get; set; }

    public decimal? Amount { get; set; }

    public string? SettlementMethodName { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? SettlementMethodId { get; set; }

    public string? TaxPayerName { get; set; }

    public string? TransactionRefNo { get; set; }

    public int? TaxOfficeId { get; set; }

    public int? TaxOfficerId { get; set; }

    public int? RevenueStreamId { get; set; }
}

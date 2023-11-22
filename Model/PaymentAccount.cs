using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class PaymentAccount
{
    public long PaymentAccountId { get; set; }

    public string? PaymentRefNo { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public decimal? Amount { get; set; }

    public int? RevenueStreamId { get; set; }

    public int? RevenueSubStreamId { get; set; }

    public int? AgencyId { get; set; }

    public int? SettlementMethodId { get; set; }

    public int? SettlementStatusId { get; set; }

    public string? TransactionRefNo { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? Notes { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsManualEntry { get; set; }

    public virtual RevenueStream? RevenueStream { get; set; }

    public virtual RevenueSubStream? RevenueSubStream { get; set; }

    public virtual SettlementMethod? SettlementMethod { get; set; }

    public virtual SettlementStatus? SettlementStatus { get; set; }

    public virtual TaxPayerType? TaxPayerType { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwServiceBillNew
{
    public long ServiceBillId { get; set; }

    public string? ServiceBillRefNo { get; set; }

    public DateTime? ServiceBillDate { get; set; }

    public decimal? ServiceBillAmount { get; set; }

    public int? SettlementStatusId { get; set; }

    public string? SettlementStatusName { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? TaxPayerName { get; set; }

    public int? TaxOfficeId { get; set; }

    public int? TaxOfficerId { get; set; }

    public DateTime? SettlementDueDate { get; set; }
}

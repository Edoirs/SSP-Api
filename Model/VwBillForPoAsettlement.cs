using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwBillForPoAsettlement
{
    public long BillId { get; set; }

    public DateTime? BillDate { get; set; }

    public int BillTypeId { get; set; }

    public string BillTypeName { get; set; } = null!;

    public string? BillRefNo { get; set; }

    public string? TaxPayerName { get; set; }

    public decimal? BillAmount { get; set; }

    public int? SettlementStatusId { get; set; }

    public string? SettlementStatusName { get; set; }
}

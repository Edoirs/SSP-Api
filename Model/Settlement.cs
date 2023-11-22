using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Settlement
{
    public int SettlementId { get; set; }

    public string? SettlementRefNo { get; set; }

    public long? ServiceBillId { get; set; }

    public long? AssessmentId { get; set; }

    public decimal? SettlementAmount { get; set; }

    public int? SettlementMethodId { get; set; }

    public DateTime? SettlementDate { get; set; }

    public string? SettlementNotes { get; set; }

    public string? TransactionRefNo { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Assessment? Assessment { get; set; }

    public virtual ICollection<MapSettlementSettlementItem> MapSettlementSettlementItems { get; set; } = new List<MapSettlementSettlementItem>();

    public virtual ICollection<MapTreasuryReceiptSettlement> MapTreasuryReceiptSettlements { get; set; } = new List<MapTreasuryReceiptSettlement>();

    public virtual ServiceBill? ServiceBill { get; set; }

    public virtual SettlementMethod? SettlementMethod { get; set; }
}

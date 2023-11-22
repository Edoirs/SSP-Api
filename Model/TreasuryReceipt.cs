using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TreasuryReceipt
{
    public long ReceiptId { get; set; }

    public string? ReceiptRefNo { get; set; }

    public long? ServiceBillId { get; set; }

    public long? AssessmentId { get; set; }

    public decimal? ReceiptAmount { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public int? StatusId { get; set; }

    public int? CancelledBy { get; set; }

    public string? CancelNotes { get; set; }

    public string? Notes { get; set; }

    public string? GeneratedPath { get; set; }

    public string? SignedPath { get; set; }

    public int? SignSourceId { get; set; }

    public string? SignImgSrc { get; set; }

    public string? DocumentUrl { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapTreasuryReceiptSettlement> MapTreasuryReceiptSettlements { get; set; } = new List<MapTreasuryReceiptSettlement>();
}

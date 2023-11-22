using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTreasuryReceiptSettlement
{
    public long Rsid { get; set; }

    public int? SettlementId { get; set; }

    public long? ReceiptId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TreasuryReceipt? Receipt { get; set; }

    public virtual Settlement? Settlement { get; set; }
}

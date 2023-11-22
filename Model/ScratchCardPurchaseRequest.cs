using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class ScratchCardPurchaseRequest
{
    public int ScprequestId { get; set; }

    public string? RequestReferenceNo { get; set; }

    public DateTime? RequestDate { get; set; }

    public int? DealerTypeId { get; set; }

    public int? ScratchCardDealerId { get; set; }

    public int? RequestedQty { get; set; }

    public decimal? Commission { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? PaymentStatusId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

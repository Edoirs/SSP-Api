using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTaxPayerMessage
{
    public long Tpmid { get; set; }

    public int? SenderTaxPayerTypeId { get; set; }

    public int? SenderTaxPayerId { get; set; }

    public int? SenderStaffId { get; set; }

    public int? ReceiverTaxPayerTypeId { get; set; }

    public int? ReceiverTaxPayerId { get; set; }

    public int? ReceiverStaffId { get; set; }

    public string? Message { get; set; }

    public DateTime? MessageDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapTaxPayerMessageDocument> MapTaxPayerMessageDocuments { get; set; } = new List<MapTaxPayerMessageDocument>();
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class ReceiptStatus
{
    public int ReceiptStatusId { get; set; }

    public string? ReceiptStatusName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TccRefHolder
{
    public int Id { get; set; }

    public string? ReqId { get; set; }

    public int? TaxYear { get; set; }

    public string? ReciptRef { get; set; }

    public int? ReceiptDate { get; set; }
}

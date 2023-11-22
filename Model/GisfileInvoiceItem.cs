using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class GisfileInvoiceItem
{
    public long Id { get; set; }

    public long InvoiceId { get; set; }

    public string? RevenueHeadId { get; set; }

    public string? Amount { get; set; }

    public string? Description { get; set; }

    public string? Year { get; set; }

    public DateTime DateSaved { get; set; }

    public string? FileNumber { get; set; }

    public string? PageNo { get; set; }
}

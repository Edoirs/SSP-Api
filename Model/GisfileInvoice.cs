using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class GisfileInvoice
{
    public long Id { get; set; }

    public string? InvoiceDate { get; set; }

    public string? InvoiceAmount { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? IsReversal { get; set; }

    public string? InvoiceId { get; set; }

    public DateTime DateSaved { get; set; }

    public long FileId { get; set; }

    public string? PageNo { get; set; }

    public string? FileNumber { get; set; }
}

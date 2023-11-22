using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class ScratchCardPrinter
{
    public int ScratchCardPrinterId { get; set; }

    public string? ScratchCardPrinterName { get; set; }

    public int? CompanyId { get; set; }

    public decimal? AgreedUnitPrice { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

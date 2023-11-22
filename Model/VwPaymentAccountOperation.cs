using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwPaymentAccountOperation
{
    public int Poaid { get; set; }

    public DateTime? OperationDate { get; set; }

    public string? OperationTypesName { get; set; }

    public string? FromTaxPayer { get; set; }

    public string? FromName { get; set; }

    public string? ToTaxPayer { get; set; }

    public string? ToName { get; set; }

    public decimal? Amount { get; set; }
}

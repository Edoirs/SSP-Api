using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwTccrequestList
{
    public long TccrequestId { get; set; }

    public string? RequestRefNo { get; set; }

    public string TaxPayerName { get; set; } = null!;

    public string? MobileNumber1 { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? ServiceBillRefNo { get; set; }

    public string? SettlementStatusName { get; set; }

    public int? StatusId { get; set; }

    public string? StatusName { get; set; }
}

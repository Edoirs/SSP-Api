using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class RevenueSubStream
{
    public int RevSsId { get; set; }

    public int? RevSsCreateBy { get; set; }

    public DateTime? RevSsCreateAt { get; set; }

    public int? AssetType { get; set; }

    public int? RevenueStream { get; set; }

    public string? RevenueSubStream1 { get; set; }
}

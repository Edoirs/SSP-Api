using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class SettlementMethod
{
    public int SettId { get; set; }

    public int? SettCreateBy { get; set; }

    public DateTime? SettCreateAt { get; set; }

    public string? SettlementMethod1 { get; set; }
}

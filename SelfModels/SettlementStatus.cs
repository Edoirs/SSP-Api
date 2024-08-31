using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class SettlementStatus
{
    public int SettStId { get; set; }

    public int SettStCreateBy { get; set; }

    public DateTime SettStCreateAt { get; set; }

    public string SettlementStatus1 { get; set; } = null!;

    public string StatusDescription { get; set; } = null!;
}

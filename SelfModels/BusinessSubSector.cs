using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class BusinessSubSector
{
    public int BsSbId { get; set; }

    public int BsSbCreateBy { get; set; }

    public DateTime BsSbCreateAt { get; set; }

    public int BusinessType { get; set; }

    public int BusinessCategory { get; set; }

    public int BusinessSector { get; set; }

    public string BusinessSubSector1 { get; set; } = null!;

    public string BsSbStatus { get; set; } = null!;
}

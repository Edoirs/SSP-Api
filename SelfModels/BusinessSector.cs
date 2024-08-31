using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class BusinessSector
{
    public int BsScId { get; set; }

    public int BsScCreateBy { get; set; }

    public DateTime BsScCreateAt { get; set; }

    public int BusinessType { get; set; }

    public int BusinessCategory { get; set; }

    public string BusinessSector1 { get; set; } = null!;

    public string BsScStatus { get; set; } = null!;
}

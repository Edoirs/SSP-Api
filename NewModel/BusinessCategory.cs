using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class BusinessCategory
{
    public int BsCtId { get; set; }

    public int BsCtCreateBy { get; set; }

    public DateTime BsCtCreateAt { get; set; }

    public int BusinessType { get; set; }

    public string BusinessCategory1 { get; set; } = null!;

    public string BsCtStatus { get; set; } = null!;
}

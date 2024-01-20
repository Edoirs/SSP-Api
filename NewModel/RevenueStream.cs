using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class RevenueStream
{
    public int ReveId { get; set; }

    public int RevCreateBy { get; set; }

    public DateTime RevCreateAt { get; set; }

    public int AssetType { get; set; }

    public string RevenueStream1 { get; set; } = null!;
}

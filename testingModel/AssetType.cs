using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class AssetType
{
    public int AssetId { get; set; }

    public int AssetCreateBy { get; set; }

    public DateTime AssetCreateAt { get; set; }

    public string AssetType1 { get; set; } = null!;

    public string AssetStatus { get; set; } = null!;
}

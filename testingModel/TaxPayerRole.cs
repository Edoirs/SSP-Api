using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class TaxPayerRole
{
    public long TptId { get; set; }

    public int TptCreateAt { get; set; }

    public DateTime TptCreateBy { get; set; }

    public int TaxPayerType { get; set; }

    public int AssetType { get; set; }

    public string TaxPayerRole1 { get; set; } = null!;

    public string TptStatus { get; set; } = null!;
}

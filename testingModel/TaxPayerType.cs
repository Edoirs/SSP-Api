using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class TaxPayerType
{
    public int TptypeId { get; set; }

    public int TptypeCreateBy { get; set; }

    public DateTime TptypeCreateAt { get; set; }

    public string TaxPayerType1 { get; set; } = null!;

    public string TptypeStatus { get; set; } = null!;
}

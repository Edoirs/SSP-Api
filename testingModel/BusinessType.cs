using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class BusinessType
{
    public int BusinessTypeId { get; set; }

    public int BusinessTypeCreateBy { get; set; }

    public DateTime BusinessTypeCreateAt { get; set; }

    public string BusinessType1 { get; set; } = null!;

    public string BusinessTypeStatus { get; set; } = null!;
}

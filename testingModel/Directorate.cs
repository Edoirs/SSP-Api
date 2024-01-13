using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class Directorate
{
    public int DirectoratesId { get; set; }

    public int DirectoratesCreateBy { get; set; }

    public DateTime DirectoratesCreateAt { get; set; }

    public int RevenueStream { get; set; }

    public string Directorate1 { get; set; } = null!;
}

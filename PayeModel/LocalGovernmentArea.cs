using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class LocalGovernmentArea
{
    public int LgaId { get; set; }

    public int LgaCreateBy { get; set; }

    public DateTime LgaCreateAt { get; set; }

    public string LgaClass { get; set; } = null!;

    public string Lga { get; set; } = null!;

    public string LgaStatus { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class Ward
{
    public int WardsId { get; set; }

    public int WardsCreateBy { get; set; }

    public DateTime WardsCreateAt { get; set; }

    public int Lga { get; set; }

    public string Wards { get; set; } = null!;

    public string WardStatus { get; set; } = null!;
}

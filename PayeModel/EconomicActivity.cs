using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class EconomicActivity
{
    public int Id { get; set; }

    public int CreateBy { get; set; }

    public DateTime CreateAt { get; set; }

    public int TaxPayerType { get; set; }

    public string Activity { get; set; } = null!;

    public string Status { get; set; } = null!;
}

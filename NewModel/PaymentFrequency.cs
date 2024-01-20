using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class PaymentFrequency
{
    public int PayfId { get; set; }

    public int PayfCreateBy { get; set; }

    public DateTime PayfCreateAt { get; set; }

    public string PaymentFrequency1 { get; set; } = null!;

    public string PayfStatus { get; set; } = null!;
}

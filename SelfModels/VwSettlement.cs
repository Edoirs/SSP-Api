using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class VwSettlement
{
    public string SettlementRef { get; set; } = null!;

    public string? AssessmentRef { get; set; }

    public double SettlementAmount { get; set; }

    public DateTime SettlementDate { get; set; }

    public string SettlementMethod { get; set; } = null!;
}

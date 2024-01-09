using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class Settlement
{
    public long SettleId { get; set; }

    public int SettleCreateBy { get; set; }

    public DateTime SettleCreateOn { get; set; }

    public string SettlementRef { get; set; } = null!;

    public string? AssessmentRef { get; set; }

    public double AssessmentAmount { get; set; }

    public double SettlementAmount { get; set; }

    public int SettlementMethod { get; set; }

    public int SettlementStatus { get; set; }

    public DateTime SettlementDate { get; set; }

    public string? SettlementNotes { get; set; }
}

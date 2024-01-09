using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class VwSettlementReport
{
    public string SettlementRef { get; set; } = null!;

    public string? AssessmentRef { get; set; }

    public double AssessmentAmount { get; set; }

    public double SettlementAmount { get; set; }

    public DateTime SettlementDate { get; set; }

    public string? SettlementStatus { get; set; }

    public string? StatusDescription { get; set; }
}

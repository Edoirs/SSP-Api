using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class VwPerformanceReport
{
    public string? AssessmentRef { get; set; }

    public string? AssessmentDate { get; set; }

    public DateTime AssessmDate { get; set; }

    public double AmountAccessed { get; set; }

    public double ActualAssessmentAmt { get; set; }

    public double SettlementAmount { get; set; }

    public DateTime? SettlementDate { get; set; }
}

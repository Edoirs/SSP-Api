using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class Exception
{
    public int ExceptionsId { get; set; }

    public int ExceptionsCreateBy { get; set; }

    public DateTime ExceptionsCreateAt { get; set; }

    public string ExceptionsRef { get; set; } = null!;

    public int ExceptionsType { get; set; }

    public int AssessmentRef { get; set; }

    public double AssessmentAmount { get; set; }

    public double? SettlementAmount { get; set; }

    public double ExceptionsAmount { get; set; }

    public int? SettlementStatus { get; set; }

    public DateTime? SettlementDate { get; set; }

    public string? SettlementRef { get; set; }
}

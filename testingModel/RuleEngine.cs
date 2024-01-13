using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class RuleEngine
{
    public int? RuleCode { get; set; }

    public decimal RuleId { get; set; }

    public string? RuleFormula { get; set; }

    public string? RuleDesc { get; set; }

    public string? RuleStatus { get; set; }

    public int? Id { get; set; }

    public DateTime? CreatedDate { get; set; }
}

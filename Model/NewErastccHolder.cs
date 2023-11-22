using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class NewErastccHolder
{
    public int Id { get; set; }

    public string? Rin { get; set; }

    public decimal? TotalIncomeEarned { get; set; }

    public int? AssessmentYear { get; set; }

    public string? Role { get; set; }

    public string? BusinessName { get; set; }

    public string? Lga { get; set; }
}

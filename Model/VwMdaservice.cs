using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwMdaservice
{
    public int MdaserviceId { get; set; }

    public int? TaxYear { get; set; }

    public string? MdaserviceName { get; set; }

    public string? RuleRunName { get; set; }

    public string? PaymentFrequencyName { get; set; }

    public decimal? ServiceAmount { get; set; }
}

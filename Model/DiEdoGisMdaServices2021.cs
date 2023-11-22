using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class DiEdoGisMdaServices2021
{
    public double? Ref { get; set; }

    public int? MdaserviceId { get; set; }

    public string? MdaserviceName { get; set; }

    public int? RunRuleId { get; set; }

    public string? RunRuleName { get; set; }

    public int? FrequencyId { get; set; }

    public string? FrequencyName { get; set; }

    public double? TaxYear { get; set; }

    public int? PaymentOptionId { get; set; }

    public string? PaymentOptionName { get; set; }

    public string? SettlementMethodIds { get; set; }

    public string? SettlementMethodNames { get; set; }

    public string? SerivceAmount { get; set; }

    public string? MdaserviceItemIds { get; set; }

    public double? ServiceItemRef { get; set; }
}

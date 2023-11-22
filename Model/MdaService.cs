using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MdaService
{
    public int MdaserviceId { get; set; }

    public string? MdaserviceCode { get; set; }

    public string? MdaserviceName { get; set; }

    public int? RuleRunId { get; set; }

    public int? PaymentFrequencyId { get; set; }

    public decimal? ServiceAmount { get; set; }

    public int? TaxYear { get; set; }

    public int? PaymentOptionId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapMdaserviceMdaserviceItem> MapMdaserviceMdaserviceItems { get; set; } = new List<MapMdaserviceMdaserviceItem>();

    public virtual ICollection<MapMdaserviceSettlementMethod> MapMdaserviceSettlementMethods { get; set; } = new List<MapMdaserviceSettlementMethod>();

    public virtual ICollection<MapServiceBillMdaservice> MapServiceBillMdaservices { get; set; } = new List<MapServiceBillMdaservice>();

    public virtual PaymentFrequency? PaymentFrequency { get; set; }

    public virtual PaymentOption? PaymentOption { get; set; }

    public virtual MstRuleRun? RuleRun { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class SettlementMethod
{
    public int SettlementMethodId { get; set; }

    public string? SettlementMethodName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapAssessmentRuleSettlementMethod> MapAssessmentRuleSettlementMethods { get; set; } = new List<MapAssessmentRuleSettlementMethod>();

    public virtual ICollection<MapMdaserviceSettlementMethod> MapMdaserviceSettlementMethods { get; set; } = new List<MapMdaserviceSettlementMethod>();

    public virtual ICollection<PaymentAccount> PaymentAccounts { get; set; } = new List<PaymentAccount>();

    public virtual ICollection<Settlement> Settlements { get; set; } = new List<Settlement>();
}

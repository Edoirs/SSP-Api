using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Upload
{
    public double? SNo { get; set; }

    public double? AssessmentId { get; set; }

    public double? Aarid { get; set; }

    public double? Aaiid { get; set; }

    public double? TaxBaseAmount { get; set; }

    public double? TaxAmount { get; set; }

    public double? SettlementId { get; set; }

    public double? SettlementAmount { get; set; }

    public DateTime? SettlementDate { get; set; }
}

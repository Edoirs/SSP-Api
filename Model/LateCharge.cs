using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class LateCharge
{
    public int LateChargeId { get; set; }

    public int? RevenueStreamId { get; set; }

    public int? TaxYear { get; set; }

    public decimal? Penalty { get; set; }

    public decimal? Interest { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

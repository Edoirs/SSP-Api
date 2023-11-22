using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapAssessmentLateCharge
{
    public long Alcid { get; set; }

    public long? Aaiid { get; set; }

    public DateTime? ChargeDate { get; set; }

    public decimal? Penalty { get; set; }

    public decimal? Interest { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

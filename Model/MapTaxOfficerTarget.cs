using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTaxOfficerTarget
{
    public long Totid { get; set; }

    public int? TaxOfficeId { get; set; }

    public int? TaxOfficerId { get; set; }

    public int? TaxYear { get; set; }

    public int? RevenueStreamId { get; set; }

    public decimal? TargetAmount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual RevenueStream? RevenueStream { get; set; }

    public virtual TaxOffice? TaxOffice { get; set; }
}

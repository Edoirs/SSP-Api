using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTaxPayerReview
{
    public long Tprid { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? ReviewStatusId { get; set; }

    public string? Notes { get; set; }

    public DateTime? ReviewDate { get; set; }

    public int? UserId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class EmCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<EmRevenueHead> EmRevenueHeads { get; set; } = new List<EmRevenueHead>();
}

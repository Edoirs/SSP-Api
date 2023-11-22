using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class LandStreetCondition
{
    public int LandStreetConditionId { get; set; }

    public string? LandStreetConditionName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Land> Lands { get; set; } = new List<Land>();
}

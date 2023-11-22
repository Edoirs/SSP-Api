using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class LandOwnership
{
    public int LandOwnershipId { get; set; }

    public string? LandOwnershipName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Land> Lands { get; set; } = new List<Land>();
}

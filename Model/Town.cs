using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Town
{
    public int TownId { get; set; }

    public string? TownName { get; set; }

    public int? Lgaid { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Building> Buildings { get; set; } = new List<Building>();

    public virtual ICollection<Land> Lands { get; set; } = new List<Land>();

    public virtual Lga? Lga { get; set; }
}

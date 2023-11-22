using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Lgaclass
{
    public int LgaclassId { get; set; }

    public string? LgaclassName { get; set; }

    public virtual ICollection<Lga> Lgas { get; set; } = new List<Lga>();
}

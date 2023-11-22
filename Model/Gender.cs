using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Gender
{
    public int GenderId { get; set; }

    public string? GenderName { get; set; }

    public virtual ICollection<Individual> Individuals { get; set; } = new List<Individual>();
}

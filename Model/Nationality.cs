using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Nationality
{
    public int NationalityId { get; set; }

    public string? NationalityName { get; set; }

    public virtual ICollection<Individual> Individuals { get; set; } = new List<Individual>();
}

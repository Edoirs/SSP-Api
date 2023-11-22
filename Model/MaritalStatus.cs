using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MaritalStatus
{
    public int MaritalStatusId { get; set; }

    public string? MaritalStatusName { get; set; }

    public virtual ICollection<Individual> Individuals { get; set; } = new List<Individual>();
}

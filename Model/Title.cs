using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Title
{
    public int TitleId { get; set; }

    public int? GenderId { get; set; }

    public string? TitleName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Individual> Individuals { get; set; } = new List<Individual>();
}

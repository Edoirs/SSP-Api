using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MstRegisterationStatus
{
    public int RegisterationStatusId { get; set; }

    public string? RegisterationStatusName { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<Government> Governments { get; set; } = new List<Government>();

    public virtual ICollection<Individual> Individuals { get; set; } = new List<Individual>();
}

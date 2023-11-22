using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class NotificationMethod
{
    public int NotificationMethodId { get; set; }

    public string? NotificationMethodName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<Government> Governments { get; set; } = new List<Government>();

    public virtual ICollection<Individual> Individuals { get; set; } = new List<Individual>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<Special> Specials { get; set; } = new List<Special>();
}

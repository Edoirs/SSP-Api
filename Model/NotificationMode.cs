using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class NotificationMode
{
    public int NotificationModeId { get; set; }

    public string? NotificationModeName { get; set; }

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}

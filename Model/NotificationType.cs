using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class NotificationType
{
    public int NotificationTypeId { get; set; }

    public string? NotificationTypeName { get; set; }

    public string? TypeDescription { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}

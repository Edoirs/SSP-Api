using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class NotificationType
{
    public int Id { get; set; }

    public int NottCreateBy { get; set; }

    public DateTime NottCreateAt { get; set; }

    public string NotificationTypes { get; set; } = null!;

    public string TypeDescription { get; set; } = null!;

    public int? FirstEscalation { get; set; }

    public int? SecondEscalation { get; set; }
}

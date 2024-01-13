using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class Notification
{
    public long Id { get; set; }

    public int? NotCreateBy { get; set; }

    public DateTime? NotCreateAt { get; set; }

    public string? NotificationsRef { get; set; }

    public DateTime? NotificationsDate { get; set; }

    public int? NotificationsMethod { get; set; }

    public int? NotificationsType { get; set; }

    public string? EventRef { get; set; }

    public string? TaxPayerRin { get; set; }

    public string? NotificationsStatus { get; set; }
}

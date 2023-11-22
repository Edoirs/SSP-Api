using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwNotification
{
    public long NotificationId { get; set; }

    public string? NotificationRefNo { get; set; }

    public DateTime? NotificationDate { get; set; }

    public string? NotificationMethodName { get; set; }

    public string? NotificationTypeName { get; set; }

    public string? TaxPayerRin { get; set; }
}

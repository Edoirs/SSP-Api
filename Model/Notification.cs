using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Notification
{
    public long NotificationId { get; set; }

    public string? NotificationRefNo { get; set; }

    public DateTime? NotificationDate { get; set; }

    public int? NotificationMethodId { get; set; }

    public int? NotificationTypeId { get; set; }

    public string? EventRefNo { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? NotificationModeId { get; set; }

    public bool? NotificationStatus { get; set; }

    public string? NotificationContent { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual NotificationMethod? NotificationMethod { get; set; }

    public virtual NotificationMode? NotificationMode { get; set; }

    public virtual NotificationType? NotificationType { get; set; }
}

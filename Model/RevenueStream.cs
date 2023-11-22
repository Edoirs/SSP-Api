using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class RevenueStream
{
    public int RevenueStreamId { get; set; }

    public string? RevenueStreamName { get; set; }

    public bool? EnableBillNotification { get; set; }

    public int? NotificationPeriod { get; set; }

    public string? EmailContent { get; set; }

    public string? Smscontent { get; set; }

    public string? BillTemplatePath { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentItem> AssessmentItems { get; set; } = new List<AssessmentItem>();

    public virtual ICollection<MapDirectoratesRevenueStream> MapDirectoratesRevenueStreams { get; set; } = new List<MapDirectoratesRevenueStream>();

    public virtual ICollection<MapTaxOfficeTarget> MapTaxOfficeTargets { get; set; } = new List<MapTaxOfficeTarget>();

    public virtual ICollection<MapTaxOfficerTarget> MapTaxOfficerTargets { get; set; } = new List<MapTaxOfficerTarget>();

    public virtual ICollection<MdaServiceItem> MdaServiceItems { get; set; } = new List<MdaServiceItem>();

    public virtual ICollection<PaymentAccount> PaymentAccounts { get; set; } = new List<PaymentAccount>();

    public virtual ICollection<RevenueSubStream> RevenueSubStreams { get; set; } = new List<RevenueSubStream>();
}

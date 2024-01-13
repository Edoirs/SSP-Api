using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class WinastAutoEmailDetail
{
    public int AutoId { get; set; }

    public int? AutoEmailId { get; set; }

    public string? AutoEmailClient { get; set; }

    public int? AutoEmailServiceId { get; set; }

    public string? AutoEmailFrom { get; set; }

    public string? AutoEmailTo { get; set; }

    public string? AutoEmailSubject { get; set; }

    public string? AutoEmailBody { get; set; }

    public string? AutoEmailImportance { get; set; }

    public string? AutoEmailAttachement { get; set; }

    public DateTime? AutoEmailSendTime { get; set; }

    public DateTime? AutoEmailActualSendTime { get; set; }

    public int? AutoEmailStatus { get; set; }

    public string? AutoEmailCc1 { get; set; }

    public string? AutoEmailCc2 { get; set; }

    public string? AutoCallNumber { get; set; }

    public int? AutoEmailAgentId { get; set; }

    public string? AutoEmailType { get; set; }

    public DateTime? AutoEmailCancelDate { get; set; }
}

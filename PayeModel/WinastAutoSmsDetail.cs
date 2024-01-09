using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class WinastAutoSmsDetail
{
    public int AutoId { get; set; }

    public int? AutoSmsId { get; set; }

    public string? AutoSmsClient { get; set; }

    public int? AutoSmsServiceId { get; set; }

    public string? AutoSmsFrom { get; set; }

    public string? AutoSmsTo { get; set; }

    public string? AutoSmsSubject { get; set; }

    public string? AutoSmsBody { get; set; }

    public string? AutoSmsImportance { get; set; }

    public DateTime? AutoSmsSendTime { get; set; }

    public DateTime? AutoSmsActualSendTime { get; set; }

    public int? AutoSmsStatus { get; set; }

    public string? AutoCallNumber { get; set; }

    public int? AutoSmsAgentId { get; set; }

    public string? AutoSmsSentRemarks { get; set; }
}

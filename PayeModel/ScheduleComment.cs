using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class ScheduleComment
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string CompanyId { get; set; } = null!;

    public string BusinessId { get; set; } = null!;

    public string CommenterType { get; set; } = null!;

    public string CommenterId { get; set; } = null!;

    public string Commenter { get; set; } = null!;
}

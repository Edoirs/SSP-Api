using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class ScheduleStatus
{
    public int Id { get; set; }

    public string ForwardedToHeadOfStation { get; set; } = null!;

    public bool Approved { get; set; }

    public bool Declined { get; set; }

    public bool Assessed { get; set; }
}

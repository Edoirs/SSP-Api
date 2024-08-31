using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class AssessmentStatus
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;
}

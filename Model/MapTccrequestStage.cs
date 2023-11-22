using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTccrequestStage
{
    public long Rsid { get; set; }

    public long? RequestId { get; set; }

    public long? StageId { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public DateTime? ApprovalDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTccrequestRevoke
{
    public long Rrid { get; set; }

    public long? RequestId { get; set; }

    public string? Reason { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual TccRequest? Request { get; set; }
}

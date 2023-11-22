using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTccrequestIssue
{
    public long Riid { get; set; }

    public long? RequestId { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TccRequest? Request { get; set; }
}

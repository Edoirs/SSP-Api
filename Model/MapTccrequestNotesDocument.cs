using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTccrequestNotesDocument
{
    public long Rndid { get; set; }

    public long? Rnid { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentPath { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MapTccrequestNote? Rn { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapCertificateStage
{
    public long Csid { get; set; }

    public long? CertificateId { get; set; }

    public long? StageId { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public virtual Certificate? Certificate { get; set; }
}

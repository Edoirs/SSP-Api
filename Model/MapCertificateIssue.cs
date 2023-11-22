using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapCertificateIssue
{
    public long Ciid { get; set; }

    public long? CertificateId { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Certificate? Certificate { get; set; }
}

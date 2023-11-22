using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class AuditLog
{
    public long Alid { get; set; }

    public int? Aslid { get; set; }

    public int? StaffId { get; set; }

    public string? Comment { get; set; }

    public string? Ipaddress { get; set; }

    public DateTime? LogDate { get; set; }

    public virtual AlScreen? Asl { get; set; }
}

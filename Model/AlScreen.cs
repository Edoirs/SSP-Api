using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class AlScreen
{
    public int Aslid { get; set; }

    public string? Aslname { get; set; }

    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
}

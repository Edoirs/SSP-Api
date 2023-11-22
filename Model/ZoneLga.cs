using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class ZoneLga
{
    public int Id { get; set; }

    public string? LgaName { get; set; }

    public string? ZoneCode { get; set; }

    public DateTime? CreatedDate { get; set; }
}

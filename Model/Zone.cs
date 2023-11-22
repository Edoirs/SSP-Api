using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Zone
{
    public int ZoneId { get; set; }

    public string? ZoneName { get; set; }

    public string ZoneCode { get; set; } = null!;

    public int? LgaId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

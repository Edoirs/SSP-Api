using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class Agency
{
    public int AgencyId { get; set; }

    public int AgencyCreateBy { get; set; }

    public DateTime AgencyCreateAt { get; set; }

    public string AgencyName { get; set; } = null!;

    public int AgencyType { get; set; }

    public string AgencyStatus { get; set; } = null!;
}

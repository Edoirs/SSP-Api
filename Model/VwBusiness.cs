using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwBusiness
{
    public int BusinessId { get; set; }

    public string? BusinessRin { get; set; }

    public string? BusinessName { get; set; }

    public string? BusinessAddress { get; set; }

    public string? BusinessSubSectorName { get; set; }
}

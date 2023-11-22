using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwIndividual
{
    public int IndividualId { get; set; }

    public string? IndividualRin { get; set; }

    public string? Tin { get; set; }

    public string? IndividualName { get; set; }

    public string? ContactAddress { get; set; }

    public int? TaxOfficeId { get; set; }
}

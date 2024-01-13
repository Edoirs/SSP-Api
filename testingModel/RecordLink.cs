using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class RecordLink
{
    public string TaxPayerInformation { get; set; } = null!;

    public string OccupantsInformation { get; set; } = null!;

    public string LandInformation { get; set; } = null!;

    public int? Id { get; set; }

    public DateTime? CreatedDate { get; set; }
}

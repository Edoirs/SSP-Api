using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class TablesApiUpdated
{
    public int Id { get; set; }

    public string? TableName { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public int? Frequency { get; set; }
}

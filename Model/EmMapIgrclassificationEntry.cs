using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class EmMapIgrclassificationEntry
{
    public long Cdseid { get; set; }

    public long? IgrclassificationId { get; set; }

    public int? DataSourceId { get; set; }

    public long? Dseid { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}

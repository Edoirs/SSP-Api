using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class EmImportLog
{
    public long ImportLogId { get; set; }

    public int? DataSourceId { get; set; }

    public string? ImportFilePath { get; set; }

    public DateTime? ImportDate { get; set; }

    public int? TotalRecord { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class GisfileHolder
{
    public long Id { get; set; }

    public string? FileNumber { get; set; }

    public string? CreationDate { get; set; }

    public string? ModifiedDate { get; set; }

    public DateTime DateSaved { get; set; }

    public long FileId { get; set; }

    public string? PageNo { get; set; }
}

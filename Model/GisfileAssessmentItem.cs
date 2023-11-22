using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class GisfileAssessmentItem
{
    public long Id { get; set; }

    public long AssessmentId { get; set; }

    public string? AssetNumber { get; set; }

    public string? AssessmentAmount { get; set; }

    public DateTime DateSaved { get; set; }

    public string? FileNumber { get; set; }

    public string? PageNo { get; set; }
}

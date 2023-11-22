using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class GisfileAssessment
{
    public long Id { get; set; }

    public long AssessmentId { get; set; }

    public string? AssessmentYear { get; set; }

    public DateTime DateSaved { get; set; }

    public long FileId { get; set; }

    public string? PageNo { get; set; }

    public string? FileNumber { get; set; }
}

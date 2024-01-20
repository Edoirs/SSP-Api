using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class AssessmentSubGroup
{
    public int AssessId { get; set; }

    public int AssessCreateAt { get; set; }

    public DateTime AssessCreateBy { get; set; }

    public int AssetType { get; set; }

    public int AssessmentGroup { get; set; }

    public string AssessmentSubGroup1 { get; set; } = null!;

    public string AssessStatus { get; set; } = null!;
}

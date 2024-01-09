using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class AssessmentGroup
{
    public int AssessId { get; set; }

    public int AssessCreateAt { get; set; }

    public DateTime AssessCreateBy { get; set; }

    public int AssetType { get; set; }

    public string AssessmentGroup1 { get; set; } = null!;

    public string AssessStatus { get; set; } = null!;
}

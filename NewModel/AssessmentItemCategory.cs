using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class AssessmentItemCategory
{
    public int AssitemId { get; set; }

    public int AssitemCreateBy { get; set; }

    public DateTime AssitemCreateAt { get; set; }

    public string ItemCategory { get; set; } = null!;

    public string AssitemStatus { get; set; } = null!;
}

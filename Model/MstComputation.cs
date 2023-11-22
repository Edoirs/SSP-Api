using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MstComputation
{
    public int ComputationId { get; set; }

    public string? ComputationName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentItem> AssessmentItems { get; set; } = new List<AssessmentItem>();

    public virtual ICollection<MdaServiceItem> MdaServiceItems { get; set; } = new List<MdaServiceItem>();
}

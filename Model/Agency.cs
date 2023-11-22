using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Agency
{
    public int AgencyId { get; set; }

    public int? AgencyTypeId { get; set; }

    public string? AgencyName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AgencyType? AgencyType { get; set; }

    public virtual ICollection<AssessmentItem> AssessmentItems { get; set; } = new List<AssessmentItem>();

    public virtual ICollection<MdaServiceItem> MdaServiceItems { get; set; } = new List<MdaServiceItem>();
}

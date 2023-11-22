using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class ReviewStatus
{
    public int ReviewStatusId { get; set; }

    public string? ReviewStatusName { get; set; }

    public string? StatusDescription { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

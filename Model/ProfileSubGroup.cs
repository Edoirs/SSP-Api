using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class ProfileSubGroup
{
    public int ProfileSubGroupId { get; set; }

    public int? ProfileId { get; set; }

    public int? SubGroupId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ProfilesBkp? Profile { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class ProfileSubAttribute
{
    public int ProfileSubAttributeId { get; set; }

    public int? ProfileId { get; set; }

    public int? SubAttributeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ProfilesBkp? Profile { get; set; }
}

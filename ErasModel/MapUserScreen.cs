using System;
using System.Collections.Generic;

namespace SelfPortalAPi.ErasModel;

public partial class MapUserScreen
{
    public long Usid { get; set; }

    public int? UserId { get; set; }

    public int? ScreenId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MstScreen? Screen { get; set; }

    public virtual MstUser? User { get; set; }
}

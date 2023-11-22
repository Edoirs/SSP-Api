using System;
using System.Collections.Generic;

namespace SelfPortalAPi.ErasModel;

public partial class MapApiUsersRight
{
    public long Uaid { get; set; }

    public int? Apiid { get; set; }

    public int? UserId { get; set; }

    public bool? Apiaccess { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MstApi? Api { get; set; }

    public virtual MstUser? User { get; set; }
}

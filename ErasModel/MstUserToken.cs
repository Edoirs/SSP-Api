using System;
using System.Collections.Generic;

namespace SelfPortalAPi.ErasModel;

public partial class MstUserToken
{
    public int TokenId { get; set; }

    public int? UserId { get; set; }

    public string? Token { get; set; }

    public DateTime? TokenIssuedDate { get; set; }

    public DateTime? TokenExpiresDate { get; set; }

    public string? Ipaddresss { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual MstUser? User { get; set; }
}

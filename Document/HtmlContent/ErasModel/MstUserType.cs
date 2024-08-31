using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class MstUserType
{
    public int UserTypeId { get; set; }

    public string? UserTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MstUser> MstUsers { get; set; } = new List<MstUser>();
}

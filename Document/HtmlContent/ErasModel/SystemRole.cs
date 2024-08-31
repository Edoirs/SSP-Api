using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class SystemRole
{
    public int SystemRoleId { get; set; }

    public string? SystemRoleName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<SystemUser> SystemUsers { get; set; } = new List<SystemUser>();
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class SystemUser
{
    public int SystemUserId { get; set; }

    public string? SystemUserName { get; set; }

    public string? UserLogin { get; set; }

    public string? UserPassword { get; set; }

    public int? SystemRoleId { get; set; }

    public bool? Active { get; set; }

    public DateTime? LastLogin { get; set; }

    public int? FailedLoginCount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual SystemRole? SystemRole { get; set; }
}

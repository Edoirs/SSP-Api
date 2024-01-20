using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class AdminUser
{
    public int AdminUserId { get; set; }

    public string? AdminUserTypeName { get; set; }

    public int PayeUserTypeId { get; set; }

    public int RoleId { get; set; }

    public string? Password { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? Designation { get; set; }

    public string? Phone { get; set; }

    public byte IsActive { get; set; }
}

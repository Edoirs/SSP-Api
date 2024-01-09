using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class UserManagement
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int BusinessId { get; set; }

    public int TaxpayerId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;
}

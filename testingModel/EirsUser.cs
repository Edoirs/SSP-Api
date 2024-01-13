using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class EirsUser
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Status { get; set; }

    public string? Designation { get; set; }

    public string? MobileNo { get; set; }

    public string? Address { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? GroupId { get; set; }
}

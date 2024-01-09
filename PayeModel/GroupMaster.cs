using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class GroupMaster
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public string? GroupStatusAI { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class StateMaster
{
    public int? StateId { get; set; }

    public string? StateName { get; set; }

    public string? StateCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

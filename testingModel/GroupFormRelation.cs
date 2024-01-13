using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class GroupFormRelation
{
    public int GroupFormId { get; set; }

    public int GroupId { get; set; }

    public int FormId { get; set; }

    public int CreatedBy { get; set; }

    public DateOnly CreatedOn { get; set; }
}

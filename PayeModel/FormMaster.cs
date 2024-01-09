using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class FormMaster
{
    public int FormId { get; set; }

    public string? FormName { get; set; }

    public string? FormPath { get; set; }

    public string? FormAppType { get; set; }

    public string? FormStatus { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

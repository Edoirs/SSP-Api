using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class ExceptionType
{
    public int Id { get; set; }

    public int CreateBy { get; set; }

    public DateTime CreateAt { get; set; }

    public string ExceptionTypes { get; set; } = null!;
}

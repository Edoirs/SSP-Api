using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class BusinessStructure
{
    public int BsStId { get; set; }

    public int BsStCreateBy { get; set; }

    public DateTime BsStCreateAt { get; set; }

    public int BusinessType { get; set; }

    public string BusinessStructure1 { get; set; } = null!;

    public string BsCtStatus { get; set; } = null!;
}

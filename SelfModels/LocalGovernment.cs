using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class LocalGovernment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string LgaCode { get; set; } = null!;

    public string UniqueId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public long CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public long ModifiedBy { get; set; }
}

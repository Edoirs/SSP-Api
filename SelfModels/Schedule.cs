using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public int ForwardedTo { get; set; }

    public int AssessmentStatus { get; set; }

    public string DateForwarded { get; set; } = null!;

    public int Status { get; set; }

    public string DueDate { get; set; } = null!;

    public int CreatedByAppId { get; set; }

    public int UserId { get; set; }

    public int CorporateId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int BusinessId { get; set; }

    public string UniqueId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public long CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public long ModifiedBy { get; set; }
}

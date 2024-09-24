using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class Projection
{
    public int Id { get; set; }

    public string AnnualProjectionId { get; set; } = null!;

    public int CorporateId { get; set; }

    public int AppId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string TaxpayerId { get; set; } = null!;

    public int ProjectionYear { get; set; }

    public string FileProjectionStatus { get; set; } = null!;

    public string ForwardedTo { get; set; } = null!;

    public string DateForwarded { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;

    public int EmployeesCount { get; set; }

    public string BusinessId { get; set; } = null!;

    public string BusinessName { get; set; } = null!;

    public int BusinessPrimaryId { get; set; }

    public int ApprovalStatus { get; set; }

    public bool Status { get; set; }

    public string UniqueId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public string ModifiedBy { get; set; }
}

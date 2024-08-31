using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class AnnualReturn
{
    public int Id { get; set; }

    public string BusinessId { get; set; } = null!;

    public string BusinessName { get; set; } = null!;

    public string LinkStatus { get; set; } = null!;

    public string IndustrySectorName { get; set; } = null!;

    public string IndustrySubsectorName { get; set; } = null!;

    public string BusinessAddress { get; set; } = null!;

    public string LgaName { get; set; } = null!;

    public string TownName { get; set; } = null!;

    public string WardName { get; set; } = null!;

    public int CorporateId { get; set; }

    public string TaxpayerId { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public int EmployeesCount { get; set; }

    public string TaxpayerRole { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;

    public string UniqueId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public long CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public long ModifiedBy { get; set; }
}

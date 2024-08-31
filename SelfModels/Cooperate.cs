using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class Cooperate
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string CacNumber { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string TaxpayerId { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string ContactAddress { get; set; } = null!;

    public string Phone2 { get; set; } = null!;

    public string Email2 { get; set; } = null!;

    public int Status { get; set; }

    public int IndustrySectorId { get; set; }

    public string CorporateLogo { get; set; } = null!;

    public int TaxOfficeId { get; set; }

    public int CreatedByAppId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int HasValidEmail { get; set; }

    public string ReminderSentAt { get; set; } = null!;

    public string ReminderAnnualReturnSentAt { get; set; } = null!;

    public string ReminderAnnualProjectionSentAt { get; set; } = null!;

    public string ParentTaxpayerId { get; set; } = null!;

    public string EconomicActivityId { get; set; } = null!;

    public string CompanyTypeId { get; set; } = null!;

    public string StateTin { get; set; } = null!;

    public string NormalizedStateTin { get; set; } = null!;

    public string StateCode { get; set; } = null!;

    public string LgaCode { get; set; } = null!;

    public string ActiveStatus { get; set; } = null!;

    public string UniqueId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public long CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public long ModifiedBy { get; set; }
}

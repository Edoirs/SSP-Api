using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwAssessmentBill
{
    public long AssessmentId { get; set; }

    public string? AssessmentRefNo { get; set; }

    public DateTime? AssessmentDate { get; set; }

    public decimal? AssessmentAmount { get; set; }

    public int? SettlementStatusId { get; set; }

    public string? SettlementStatusName { get; set; }

    public string? TaxPayerName { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxOfficeId { get; set; }

    public int? TaxOfficerId { get; set; }

    public DateTime? SettlementDueDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Assessment
{
    public long AssessmentId { get; set; }

    public string? AssessmentRefNo { get; set; }

    public DateTime? AssessmentDate { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public decimal? AssessmentAmount { get; set; }

    public DateTime? SettlementDueDate { get; set; }

    public int? SettlementStatusId { get; set; }

    public DateTime? SettlementDate { get; set; }

    public string? AssessmentNotes { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? BillPath { get; set; }

    public virtual ICollection<MapAssessmentAssessmentRule> MapAssessmentAssessmentRules { get; set; } = new List<MapAssessmentAssessmentRule>();

    public virtual ICollection<Settlement> Settlements { get; set; } = new List<Settlement>();
}

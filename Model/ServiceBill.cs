using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class ServiceBill
{
    public long ServiceBillId { get; set; }

    public string? ServiceBillRefNo { get; set; }

    public DateTime? ServiceBillDate { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public decimal? ServiceBillAmount { get; set; }

    public DateTime? SettlementDueDate { get; set; }

    public int? SettlementStatusId { get; set; }

    public DateTime? SettlementDate { get; set; }

    public string? Notes { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? BillPath { get; set; }

    public virtual ICollection<MapServiceBillMdaservice> MapServiceBillMdaservices { get; set; } = new List<MapServiceBillMdaservice>();

    public virtual ICollection<Settlement> Settlements { get; set; } = new List<Settlement>();
}

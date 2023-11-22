using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapPaymentAccountOperation
{
    public int Poaid { get; set; }

    public DateTime? OperationDate { get; set; }

    public int? OperationTypeId { get; set; }

    public int? FromTaxPayerTypeId { get; set; }

    public int? FromTaxPayerId { get; set; }

    public int? FromSettlementMethodId { get; set; }

    public int? ToTaxPayerTypeId { get; set; }

    public int? ToTaxPayerId { get; set; }

    public int? ToBillTypeId { get; set; }

    public long? ToBillId { get; set; }

    public decimal? Amount { get; set; }

    public int PoaaccountId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public int? ModifiedDate { get; set; }
}

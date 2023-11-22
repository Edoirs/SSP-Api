using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Tccdetail
{
    public long TccdetailId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxYear { get; set; }

    public decimal? AssessableIncome { get; set; }

    public decimal? TcctaxPaid { get; set; }

    public decimal? ErastaxPaid { get; set; }

    public decimal? Erasassessed { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TaxClearanceCertificate
{
    public long Tccid { get; set; }

    public string? Tccnumber { get; set; }

    public DateTime? Tccdate { get; set; }

    public int? TaxYear { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? RequestRefNo { get; set; }

    public string? SerialNumber { get; set; }

    public string? TaxPayerDetails { get; set; }

    public string? IncomeSource { get; set; }

    public int? StatusId { get; set; }

    public string? CancelNotes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

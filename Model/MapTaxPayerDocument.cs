using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTaxPayerDocument
{
    public long Tpdid { get; set; }

    public string? DocumentRefNo { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public string? DocumentTitle { get; set; }

    public string? Notes { get; set; }

    public string? DocumentPath { get; set; }

    public DateTime? DocumentDate { get; set; }

    public int? StaffId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

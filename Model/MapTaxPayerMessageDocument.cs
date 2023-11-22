using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTaxPayerMessageDocument
{
    public long Tpmdid { get; set; }

    public long? Tpmid { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentPath { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MapTaxPayerMessage? Tpm { get; set; }
}

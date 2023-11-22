using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTaxPayerAssetProfile
{
    public long Tpapid { get; set; }

    public long? Tpaid { get; set; }

    public int? ProfileId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ProfilesBkp? Profile { get; set; }

    public virtual MapTaxPayerAsset? Tpa { get; set; }
}

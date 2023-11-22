using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapCertificateTypeItem
{
    public int Ctiid { get; set; }

    public int? CertificateTypeId { get; set; }

    public int? ItemTypeId { get; set; }

    public int? ItemId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

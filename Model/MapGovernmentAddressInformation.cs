using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapGovernmentAddressInformation
{
    public int Gaiid { get; set; }

    public int? GovernmentId { get; set; }

    public int? AddressTypeId { get; set; }

    public int? BuildingId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual AddressType? AddressType { get; set; }

    public virtual Building? Building { get; set; }

    public virtual Government? Government { get; set; }
}

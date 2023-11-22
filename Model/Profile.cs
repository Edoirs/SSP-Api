using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Profile
{
    public int ProfileId { get; set; }

    public string? ProfileReferenceNo { get; set; }

    public string? ProfileDescription { get; set; }

    public int? AssetTypeStatus { get; set; }

    public int? AssetTypeId { get; set; }

    public int? ProfileTypeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AssetType? AssetType { get; set; }
}

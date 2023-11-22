using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTccrequestGenerate
{
    public long Rgid { get; set; }

    public long? RequestId { get; set; }

    public string? Notes { get; set; }

    public string? Reason { get; set; }

    public string? Location { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool? IsExpirable { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapTccrequestGenerateField> MapTccrequestGenerateFields { get; set; } = new List<MapTccrequestGenerateField>();

    public virtual TccRequest? Request { get; set; }
}

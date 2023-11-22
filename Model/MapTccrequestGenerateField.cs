using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTccrequestGenerateField
{
    public long Rgfid { get; set; }

    public int? Pfid { get; set; }

    public long? Rgid { get; set; }

    public int? FieldId { get; set; }

    public string? FieldValue { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MapTccrequestGenerate? Rg { get; set; }
}

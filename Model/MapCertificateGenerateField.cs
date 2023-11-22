using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapCertificateGenerateField
{
    public long Cgfid { get; set; }

    public int? Pfid { get; set; }

    public long? Cgid { get; set; }

    public int? FieldId { get; set; }

    public string? FieldValue { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MapCertificateGenerate? Cg { get; set; }
}

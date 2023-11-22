using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MstFieldType
{
    public int FieldTypeId { get; set; }

    public string? FieldTypeName { get; set; }

    public virtual ICollection<MapCertificateTypeField> MapCertificateTypeFields { get; set; } = new List<MapCertificateTypeField>();
}

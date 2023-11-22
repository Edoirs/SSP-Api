using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapCertificateTypeField
{
    public int Ctfid { get; set; }

    public int? CertificateTypeId { get; set; }

    public string? FieldName { get; set; }

    public string? FieldSlug { get; set; }

    public int? FieldTypeId { get; set; }

    public string? FieldComboValue { get; set; }

    public bool? IsRequired { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual CertificateType? CertificateType { get; set; }

    public virtual MstFieldType? FieldType { get; set; }

    public virtual ICollection<MapCertificateCustomField> MapCertificateCustomFields { get; set; } = new List<MapCertificateCustomField>();
}

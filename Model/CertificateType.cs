using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class CertificateType
{
    public int CertificateTypeId { get; set; }

    public string? CertificateTypeName { get; set; }

    public string? Description { get; set; }

    public int? TaxYear { get; set; }

    public int? AgencyId { get; set; }

    public int? SedePdftemplateId { get; set; }

    public string? Cnprefix { get; set; }

    public int? CnserialNumber { get; set; }

    public string? CertificateTemplatePath { get; set; }

    public int? SignMode { get; set; }

    public int? Approver1 { get; set; }

    public int? Approver2 { get; set; }

    public int? ProcessingTypeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();

    public virtual ICollection<MapCertificateTypeField> MapCertificateTypeFields { get; set; } = new List<MapCertificateTypeField>();
}

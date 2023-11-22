using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapCertificateGenerate
{
    public long Cgid { get; set; }

    public long? CertificateId { get; set; }

    public string? CertificatePath { get; set; }

    public string? Notes { get; set; }

    public string? Reason { get; set; }

    public string? Location { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool? IsExpirable { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Certificate? Certificate { get; set; }

    public virtual ICollection<MapCertificateGenerateField> MapCertificateGenerateFields { get; set; } = new List<MapCertificateGenerateField>();
}

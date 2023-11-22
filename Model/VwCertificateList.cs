using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class VwCertificateList
{
    public long CertificateId { get; set; }

    public string? CertificateNumber { get; set; }

    public string? CertificateTypeName { get; set; }

    public int? TaxYear { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? TaxPayerName { get; set; }

    public string? TaxPayerRin { get; set; }

    public int? StatusId { get; set; }

    public string? CertificateStatusName { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class ClearanceCertificate
{
    public long CcId { get; set; }

    public int CcCreateBy { get; set; }

    public DateTime CcCreateAt { get; set; }

    public string CertificateRef { get; set; } = null!;

    public int? RevenueStream { get; set; }

    public string? CertificateNumber { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int FinancialYear { get; set; }

    public string? CertificateStatus { get; set; }

    public int TaxPayerType { get; set; }

    public int TaxPayerRin { get; set; }

    public string TaxPayerName { get; set; } = null!;

    public int AssetType { get; set; }

    public string AssetRin { get; set; } = null!;

    public string? CompanyTin { get; set; }

    public string? CompanyRin { get; set; }

    public string? MonthCertificate { get; set; }
}

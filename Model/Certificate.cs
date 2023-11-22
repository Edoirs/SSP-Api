using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class Certificate
{
    public long CertificateId { get; set; }

    public string? CertificateNumber { get; set; }

    public DateTime? CertificateDate { get; set; }

    public int? CertificateTypeId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? ProfileId { get; set; }

    public int? AssetTypeId { get; set; }

    public int? AssetId { get; set; }

    public int? StatusId { get; set; }

    public int? DisplayTypeId { get; set; }

    public string? OtherInformation { get; set; }

    public string? Notes { get; set; }

    public int? SignerId { get; set; }

    public int? SignerRoleId { get; set; }

    public int? QrcodeId { get; set; }

    public string? QrimagePath { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? VisibleSignStatusId { get; set; }

    public int? PdftemplateId { get; set; }

    public string? CertificatePath { get; set; }

    public string? GeneratedPath { get; set; }

    public string? ValidatedPath { get; set; }

    public string? SignedVisiblePath { get; set; }

    public string? SignedDigitalPath { get; set; }

    public string? SealedPath { get; set; }

    public int? SedeDocumentId { get; set; }

    public long? SedeOrderId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual CertificateType? CertificateType { get; set; }

    public virtual ICollection<MapCertificateCustomField> MapCertificateCustomFields { get; set; } = new List<MapCertificateCustomField>();

    public virtual ICollection<MapCertificateGenerate> MapCertificateGenerates { get; set; } = new List<MapCertificateGenerate>();

    public virtual ICollection<MapCertificateIssue> MapCertificateIssues { get; set; } = new List<MapCertificateIssue>();

    public virtual ICollection<MapCertificateRevoke> MapCertificateRevokes { get; set; } = new List<MapCertificateRevoke>();

    public virtual ICollection<MapCertificateSeal> MapCertificateSeals { get; set; } = new List<MapCertificateSeal>();

    public virtual ICollection<MapCertificateSignDigital> MapCertificateSignDigitals { get; set; } = new List<MapCertificateSignDigital>();

    public virtual ICollection<MapCertificateStage> MapCertificateStages { get; set; } = new List<MapCertificateStage>();

    public virtual ICollection<MapCertificateValidate> MapCertificateValidates { get; set; } = new List<MapCertificateValidate>();
}

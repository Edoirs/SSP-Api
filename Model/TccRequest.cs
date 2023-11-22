using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TccRequest
{
    public long TccrequestId { get; set; }

    public string? RequestRefNo { get; set; }

    public DateTime? RequestDate { get; set; }

    public long? ServiceBillId { get; set; }

    public int? TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public int? TaxYear { get; set; }

    public int? StatusId { get; set; }

    public int? VisibleSignStatusId { get; set; }

    public int? PdftemplateId { get; set; }

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

    public virtual ICollection<MapTccrequestGenerateTccdetail> MapTccrequestGenerateTccdetails { get; set; } = new List<MapTccrequestGenerateTccdetail>();

    public virtual ICollection<MapTccrequestGenerate> MapTccrequestGenerates { get; set; } = new List<MapTccrequestGenerate>();

    public virtual ICollection<MapTccrequestIssue> MapTccrequestIssues { get; set; } = new List<MapTccrequestIssue>();

    public virtual ICollection<MapTccrequestPrepareTccdraft> MapTccrequestPrepareTccdrafts { get; set; } = new List<MapTccrequestPrepareTccdraft>();

    public virtual ICollection<MapTccrequestRevoke> MapTccrequestRevokes { get; set; } = new List<MapTccrequestRevoke>();

    public virtual ICollection<MapTccrequestSeal> MapTccrequestSeals { get; set; } = new List<MapTccrequestSeal>();

    public virtual ICollection<MapTccrequestSignDigital> MapTccrequestSignDigitals { get; set; } = new List<MapTccrequestSignDigital>();

    public virtual ICollection<MapTccrequestValidateTaxPayerIncome> MapTccrequestValidateTaxPayerIncomes { get; set; } = new List<MapTccrequestValidateTaxPayerIncome>();

    public virtual ICollection<MapTccrequestValidateTaxPayerInformation> MapTccrequestValidateTaxPayerInformations { get; set; } = new List<MapTccrequestValidateTaxPayerInformation>();

    public virtual ICollection<MapTccrequestValidate> MapTccrequestValidates { get; set; } = new List<MapTccrequestValidate>();
}

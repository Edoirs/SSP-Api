using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class SftpDataSubmission
{
    public int DataSubmissionId { get; set; }

    public string? SubmissionRefNo { get; set; }

    public int? DataSubmitterId { get; set; }

    public int? TaxYear { get; set; }

    public int? DataSubmissionTypeId { get; set; }

    public string? DocumentPath { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual SftpDataSubmissionType? DataSubmissionType { get; set; }

    public virtual SftpDataSubmitter? DataSubmitter { get; set; }
}

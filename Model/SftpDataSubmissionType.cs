using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class SftpDataSubmissionType
{
    public int DataSubmissionTypeId { get; set; }

    public string? DataSubmissionTypeName { get; set; }

    public string? TemplateFilePath { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<SftpDataSubmission> SftpDataSubmissions { get; set; } = new List<SftpDataSubmission>();

    public virtual ICollection<SftpMapDataSubmitterDataSubmissionType> SftpMapDataSubmitterDataSubmissionTypes { get; set; } = new List<SftpMapDataSubmitterDataSubmissionType>();
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class SftpMapDataSubmitterDataSubmissionType
{
    public long Dstdsid { get; set; }

    public int? DataSubmissionTypeId { get; set; }

    public int? DataSubmitterId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual SftpDataSubmissionType? DataSubmissionType { get; set; }

    public virtual SftpDataSubmitter? DataSubmitter { get; set; }
}

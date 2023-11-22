using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTccrequestSignVisible
{
    public long Rsvid { get; set; }

    public long? RequestId { get; set; }

    public int? UserId { get; set; }

    public DateTime? SignDate { get; set; }

    public string? Notes { get; set; }

    public int? SignSourceId { get; set; }

    public string? AdditionalSignatureLocation { get; set; }

    public int? StageId { get; set; }

    public string? DocumentWidth { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

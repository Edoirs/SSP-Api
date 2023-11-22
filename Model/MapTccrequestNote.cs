using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTccrequestNote
{
    public long Rnid { get; set; }

    public long? RequestId { get; set; }

    public int? StageId { get; set; }

    public int? StaffId { get; set; }

    public string? Notes { get; set; }

    public DateTime? NotesDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapTccrequestNotesDocument> MapTccrequestNotesDocuments { get; set; } = new List<MapTccrequestNotesDocument>();
}

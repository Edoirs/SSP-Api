using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapDirectoratesRevenueStream
{
    public int Drsid { get; set; }

    public int? DirectorateId { get; set; }

    public int? RevenueStreamId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Directorate? Directorate { get; set; }

    public virtual RevenueStream? RevenueStream { get; set; }
}

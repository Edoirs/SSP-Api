using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class MstAwarenessCategory
{
    public int AwarenessCategoryId { get; set; }

    public string? AwarenessCategoryName { get; set; }

    public string? SectionDescription { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MstFaq> MstFaqs { get; set; } = new List<MstFaq>();
}

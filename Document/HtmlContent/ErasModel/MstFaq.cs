using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class MstFaq
{
    public int Faqid { get; set; }

    public int? AwarenessCategoryId { get; set; }

    public string? Faqtitle { get; set; }

    public string? Faqtext { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MstAwarenessCategory? AwarenessCategory { get; set; }
}

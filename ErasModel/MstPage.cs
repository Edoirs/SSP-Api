using System;
using System.Collections.Generic;

namespace SelfPortalAPi.ErasModel;

public partial class MstPage
{
    public int PageId { get; set; }

    public string? PageName { get; set; }

    public string? PageHeader { get; set; }

    public string? ShortDesc { get; set; }

    public string? PageContent { get; set; }

    public string? PageTitle { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.ErasModel;

public partial class MstMenu
{
    public int MenuId { get; set; }

    public string? MenuName { get; set; }

    public int? ParentMenuId { get; set; }

    public string? MenuUrl { get; set; }

    public bool? Active { get; set; }

    public int? SortOrder { get; set; }

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

    public virtual ICollection<MstMenu> InverseParentMenu { get; set; } = new List<MstMenu>();

    public virtual MstMenu? ParentMenu { get; set; }
}

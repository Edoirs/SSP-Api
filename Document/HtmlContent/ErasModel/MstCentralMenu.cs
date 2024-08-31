using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class MstCentralMenu
{
    public int CentralMenuId { get; set; }

    public string? CentralMenuName { get; set; }

    public int? ParentCentralMenuId { get; set; }

    public bool? Active { get; set; }

    public decimal? SortOrder { get; set; }

    public int? MenuType { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MstCentralMenu> InverseParentCentralMenu { get; set; } = new List<MstCentralMenu>();

    public virtual ICollection<MapCentralMenuScreen> MapCentralMenuScreens { get; set; } = new List<MapCentralMenuScreen>();

    public virtual MstCentralMenu? ParentCentralMenu { get; set; }
}

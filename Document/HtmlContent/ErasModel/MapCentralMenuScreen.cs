using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class MapCentralMenuScreen
{
    public long Cmsid { get; set; }

    public int? CentralMenuId { get; set; }

    public int? ScreenId { get; set; }

    public bool? Active { get; set; }

    public bool? IsMainScreen { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MstCentralMenu? CentralMenu { get; set; }

    public virtual MstScreen? Screen { get; set; }
}

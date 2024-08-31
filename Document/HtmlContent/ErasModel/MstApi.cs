using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class MstApi
{
    public int Apiid { get; set; }

    public string? Apiname { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public string? Apidescription { get; set; }

    public string? DocumentPath { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapApiUsersRight> MapApiUsersRights { get; set; } = new List<MapApiUsersRight>();
}

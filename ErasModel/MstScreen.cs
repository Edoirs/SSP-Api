using System;
using System.Collections.Generic;

namespace SelfPortalAPi.ErasModel;

public partial class MstScreen
{
    public int ScreenId { get; set; }

    public string? ScreenName { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public string? ViewName { get; set; }

    public string? ScreenUrl { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<MapCentralMenuScreen> MapCentralMenuScreens { get; set; } = new List<MapCentralMenuScreen>();

    public virtual ICollection<MapUserScreen> MapUserScreens { get; set; } = new List<MapUserScreen>();
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class Profile
{
    public long ProfileId { get; set; }

    public int ProfileCreateBy { get; set; }

    public DateTime ProfileCreateAt { get; set; }

    public string ProfileRef { get; set; } = null!;

    public string ProfileDescription { get; set; } = null!;

    public int AssetType { get; set; }

    public string ProfileSector { get; set; } = null!;

    public string ProfileSubSector { get; set; } = null!;

    public string ProfileGroup { get; set; } = null!;

    public string ProfileSubGroup { get; set; } = null!;

    public string SectorElements { get; set; } = null!;

    public string SectorSubElements { get; set; } = null!;

    public string Attribute { get; set; } = null!;

    public string SubAttribute { get; set; } = null!;

    public int AssetStatus { get; set; }

    public int TaxPayerType { get; set; }

    public int TaxPayerRole { get; set; }

    public string ProfileStatus { get; set; } = null!;
}

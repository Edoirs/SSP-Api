using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class Business
{
    public int Id { get; set; }

    public long BusinessId { get; set; }

    public int BusinessCreateBy { get; set; }

    public DateTime BusinessCreateDate { get; set; }

    public string BusinessRin { get; set; } = null!;

    public string AssetType { get; set; } = null!;

    public string BusinessName { get; set; } = null!;

    public int BusinessLga { get; set; }

    public int BusinessCategory { get; set; }

    public int BusinessSector { get; set; }

    public int BusinessSubSector { get; set; }

    public int BusinessStructure { get; set; }

    public int BusinessOperations { get; set; }

    public string Profile { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? BusinessType { get; set; }

    public string? CompanyRin { get; set; }
}

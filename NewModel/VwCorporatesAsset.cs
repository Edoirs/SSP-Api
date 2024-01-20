using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class VwCorporatesAsset
{
    public string? TaxPayerRin { get; set; }

    public string? TaxPayerName { get; set; }

    public string? ContactAddress { get; set; }

    public string? AssetRin { get; set; }

    public string? TaxPayerRinB { get; set; }

    public string BusinessName { get; set; } = null!;

    public string AssetTypeName { get; set; } = null!;

    public string BusinessTypeName { get; set; } = null!;
}

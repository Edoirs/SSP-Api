using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Document.HtmlContent.ErasModel;

public partial class MstBusiness
{
    public long BusinessId { get; set; }

    public string? BusinessName { get; set; }

    public string? BusinessAddress { get; set; }

    public string? BusinessSector { get; set; }

    public string? BusinessSubSector { get; set; }

    public string? BusinessType { get; set; }

    public string? BusinessCategory { get; set; }

    public string? AssetType { get; set; }

    public string? BusinessStructure { get; set; }

    public string? BusinessOperation { get; set; }

    public string? Size { get; set; }

    public string? Lga { get; set; }

    public string? Tin { get; set; }

    public string? TaxOffice { get; set; }

    public string? ContactName { get; set; }

    public string? Phone { get; set; }

    public string? EmailAddress { get; set; }

    public bool? Paye { get; set; }

    public bool? DirectAssessment { get; set; }

    public bool? PresumptiveTax { get; set; }

    public bool? BusinessPremises { get; set; }

    public bool? ConsumtpionTaxes { get; set; }

    public bool? Mdaservices { get; set; }

    public string? Source { get; set; }

    public string? BuildingTag { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public bool? PhoneVerified { get; set; }

    public bool? Claimed { get; set; }

    public bool? Active { get; set; }
}

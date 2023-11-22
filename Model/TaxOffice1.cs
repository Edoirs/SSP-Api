using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class TaxOffice1
{
    public int TaxOfficeId { get; set; }

    public string? TaxOfficeName { get; set; }

    public int? AddressTypeId { get; set; }

    public string? ZoneCode { get; set; }
}

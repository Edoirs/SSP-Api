using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class AddressType
{
    public int AddressTypeId { get; set; }

    public string? AddressTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapCompanyAddressInformation> MapCompanyAddressInformations { get; set; } = new List<MapCompanyAddressInformation>();

    public virtual ICollection<MapGovernmentAddressInformation> MapGovernmentAddressInformations { get; set; } = new List<MapGovernmentAddressInformation>();

    public virtual ICollection<MapIndividualAddressInformation> MapIndividualAddressInformations { get; set; } = new List<MapIndividualAddressInformation>();

    public virtual ICollection<MapSpecialAddressInformation> MapSpecialAddressInformations { get; set; } = new List<MapSpecialAddressInformation>();

    public virtual ICollection<TaxOffice> TaxOffices { get; set; } = new List<TaxOffice>();
}

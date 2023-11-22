using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class BusinessCategory
{
    public int BusinessCategoryId { get; set; }

    public string? BusinessCategoryName { get; set; }

    public int? BusinessTypeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<BusinessSector> BusinessSectors { get; set; } = new List<BusinessSector>();

    public virtual BusinessType? BusinessType { get; set; }

    public virtual ICollection<Business> Businesses { get; set; } = new List<Business>();
}

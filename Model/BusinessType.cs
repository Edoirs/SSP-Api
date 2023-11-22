using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class BusinessType
{
    public int BusinessTypeId { get; set; }

    public string? BusinessTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<BusinessCategory> BusinessCategories { get; set; } = new List<BusinessCategory>();

    public virtual ICollection<BusinessOperation> BusinessOperations { get; set; } = new List<BusinessOperation>();

    public virtual ICollection<BusinessSector> BusinessSectors { get; set; } = new List<BusinessSector>();

    public virtual ICollection<BusinessStructure> BusinessStructures { get; set; } = new List<BusinessStructure>();

    public virtual ICollection<Business> Businesses { get; set; } = new List<Business>();
}

using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class LocalGovtPostalCodee
{
    public int Id { get; set; }

    public int StateId { get; set; }

    public string City { get; set; } = null!;

    public string Postalcode { get; set; } = null!;

    public int Active { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string UpdatedAt { get; set; } = null!;

    public string State { get; set; } = null!;

    public string UniqueId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public long CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public long ModifiedBy { get; set; }
}

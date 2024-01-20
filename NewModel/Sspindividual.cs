using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class Sspindividual : NewBaseEntity
{

    public string? Firstname { get; set; }

    public string? Surname { get; set; }

    public string? Othername { get; set; }

    public string? Phonenumber { get; set; }

    public string? Rin { get; set; }

    public string? IndividalId { get; set; }

    public string? Jtbtin { get; set; }

    public string? Nin { get; set; }

    public string? Nationality { get; set; }

    public string? Homeaddress { get; set; }

    public string? Designation { get; set; }

    public DateTime? Datetcreated { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Modifiedby { get; set; }
}

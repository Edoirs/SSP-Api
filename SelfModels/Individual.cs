using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class Individual : SelfBaseEntity
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Surname { get; set; }

    public string? Othername { get; set; }

    public string? Phonenumber { get; set; }

    public string? EmployeeRin { get; set; }

    public string? EmployeeId { get; set; }

    public string? Jtbtin { get; set; }

    public string? Nin { get; set; }

    public string? Nationality { get; set; }

    public string? Homeaddress { get; set; }

    public string? Designation { get; set; }

    public DateTime? Datetcreated { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Modifiedby { get; set; }

    public string? Title { get; set; }

    public string? EmailAddress { get; set; }

    public int? Bvn { get; set; }

    public string? ZipCode { get; set; }

    public int? LgaCode { get; set; }
}

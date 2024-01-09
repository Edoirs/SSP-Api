using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class BusinessEmployee1
{
    public int EmployeeId { get; set; }

    public int BusinessId { get; set; }

    public bool EmpployeeStatus { get; set; }

    public string Designation { get; set; } = null!;

    public DateTime StartDate { get; set; }
}

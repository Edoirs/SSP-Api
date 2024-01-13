using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class VwIndDetail
{
    public long IndId { get; set; }

    public string UserRin { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string DateOfBirth { get; set; } = null!;

    public string? Tin { get; set; }

    public string MobileNumber1 { get; set; } = null!;

    public string? EmailAddress1 { get; set; }

    public string? Nationality { get; set; }

    public string? CompanyTin { get; set; }

    public double? SalChIncome { get; set; }

    public double? SalGross { get; set; }

    public double? SalBasic { get; set; }

    public double? SalPensionDeclared { get; set; }

    public double? SalNhfDeclared { get; set; }

    public double? SalNhisDeclared { get; set; }

    public string? CompanyRin { get; set; }
}

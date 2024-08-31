using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Bvn { get; set; } = null!;

    public string TaxpayerId { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string OtherName { get; set; } = null!;

    public string Nationality { get; set; } = null!;

    public string GrossIncome { get; set; } = null!;

    public string Nhis { get; set; } = null!;

    public string Nhf { get; set; } = null!;

    public string Pension { get; set; } = null!;

    public int Basic { get; set; }

    public int Transport { get; set; }

    public int Rent { get; set; }

    public string Cra { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string OtherIncome { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string StartMonth { get; set; } = null!;

    public int Status { get; set; }

    public int CorporateId { get; set; }

    public string DeletedAt { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string HomeAddress { get; set; } = null!;

    public int TotalIncome { get; set; }

    public int LifeAssurance { get; set; }

    public string? StateTin { get; set; }

    public string? NormalizedStateTin { get; set; }

    public string? StateCode { get; set; }

    public string LgaCode { get; set; } = null!;

    public string Nin { get; set; } = null!;

    public string? AssetId { get; set; }

    public int BusinessId { get; set; }

    public string UniqueId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public long CreatedBy { get; set; }

    public DateTime ModifiedAt { get; set; }

    public long ModifiedBy { get; set; }

    public string? EmployeeRin { get; set; }

    public string? EmployeeId { get; set; }

    public string? JtbTin { get; set; }
}

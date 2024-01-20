using System;
using System.Collections.Generic;

namespace SelfPortalAPi.NewModel;

public partial class PayeInputFile
{
    public string? EmployerName { get; set; }

    public string? EmployerAddress { get; set; }

    public string? EmployerRin { get; set; }

    public string? StartMonth { get; set; }

    public string? Nationality { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? Surname { get; set; }

    public string? EmployeeRin { get; set; }

    public string? EmployeeTin { get; set; }

    public double? AnnualBasic { get; set; }

    public double? AnnualRent { get; set; }

    public double? AnnualTransport { get; set; }

    public double? AnnualUtility { get; set; }

    public double? AnnualMeal { get; set; }

    public double? OtherAllowancesAnnual { get; set; }

    public double? LeaveTransportAnnual { get; set; }

    public double? AnnualGross { get; set; }

    public double? Pension { get; set; }

    public double? Nhf { get; set; }

    public double? Nhis { get; set; }

    public string? AssessmentYear { get; set; }

    public string? EndMonth { get; set; }

    public int? Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ApiId { get; set; }

    public byte? StatusId { get; set; }

    public string? AssetRin { get; set; }
}

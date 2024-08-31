using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Models;

public partial class PayeOuputFile
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

    public double? AnnualGross { get; set; }

    public double? Cra { get; set; }

    public double? ValidatedPension { get; set; }

    public double? ValidatedNhf { get; set; }

    public double? ValidatedNhis { get; set; }

    public double? TaxFreePay { get; set; }

    public double? ChargeableIncome { get; set; }

    public double? AnnualTax { get; set; }

    public double? MonthlyTax { get; set; }

    public string? AssessmentYear { get; set; }

    public int? Status { get; set; }

    public string? EndMonth { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? Id { get; set; }

    public int? ApiId { get; set; }

    public string? AssetRin { get; set; }
}

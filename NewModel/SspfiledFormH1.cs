using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfPortalAPi.NewModel;

public partial class SspfiledFormH1 : NewBaseEntity
{
    public string? BusinessId { get; set; }

    public string? CompanyId { get; set; }
    [NotMapped]
    public string? AssetName { get; set; }
    [NotMapped]
    public string? FullName { get; set; }

    public string? TaxPayerId { get; set; }

    public string? IndividalId { get; set; }

    public string? Rin { get; set; }

    public decimal? Pension { get; set; }

    public decimal? Nhf { get; set; }

    public decimal? Nhis { get; set; }

    public decimal? Lifeassurance { get; set; }

    public decimal? Consolidatedreliefallowancecra { get; set; }

    public decimal? Annualtaxpaid { get; set; }

    public decimal? Totalmonthspaid { get; set; }

    public decimal? Rent { get; set; }

    public decimal? Transport { get; set; }

    public decimal? Basic { get; set; }

    public decimal? OtherIncome { get; set; }

    public string? FiledStatus { get; set; }

    public int? TaxYear { get; set; }

    public string? DueDate { get; set; }

    public string? ComplianceStatus { get; set; }

    public DateTime? Datetcreated { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Modifiedby { get; set; }
}
public partial class SspfiledFormH1ForSP : NewBaseEntity
{
    public string? BusinessId { get; set; }

    public string? CompanyId { get; set; }
    public string? AssetName { get; set; }
    public string? FullName { get; set; }

    public string? TaxPayerId { get; set; }

    public string? IndividalId { get; set; }

    public string? Rin { get; set; }

    public decimal? Pension { get; set; }

    public decimal? Nhf { get; set; }

    public decimal? Nhis { get; set; }

    public decimal? Lifeassurance { get; set; }

    public decimal? Consolidatedreliefallowancecra { get; set; }

    public decimal? Annualtaxpaid { get; set; }

    public decimal? Totalmonthspaid { get; set; }

    public decimal? Rent { get; set; }

    public decimal? Transport { get; set; }

    public decimal? Basic { get; set; }

    public decimal? OtherIncome { get; set; }

    public string? FiledStatus { get; set; }

    public int? TaxYear { get; set; }

    public string? DueDate { get; set; }

    public string? ComplianceStatus { get; set; }

    public DateTime? Datetcreated { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Modifiedby { get; set; }
}
public partial class SspfiledFormH3ForSP : NewBaseEntity
{
    public string? BusinessId { get; set; }

    public string? CompanyId { get; set; }
    public string? AssetName { get; set; }
    public string? FullName { get; set; }

    public string? TaxPayerId { get; set; }

    public string? IndividalId { get; set; }

    public string? Rin { get; set; }

    public decimal? Pension { get; set; }

    public decimal? Nhf { get; set; }

    public decimal? Nhis { get; set; }

    public decimal? Lifeassurance { get; set; }

    public decimal? Rent { get; set; }

    public decimal? Transport { get; set; }

    public decimal? Basic { get; set; }

    public decimal? OtherIncome { get; set; }

    public string? FiledStatus { get; set; }

    public int? TaxYear { get; set; }

    public string? DueDate { get; set; }

    public string? ComplianceStatus { get; set; }

    public DateTime? Datetcreated { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Modifiedby { get; set; }
}

public partial class SspfiledFormH1ListOfYears
{
    [Key]
    public int? TaxYear { get; set; }
}

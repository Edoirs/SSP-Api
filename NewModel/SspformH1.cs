using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfPortalAPi.NewModel;

public partial class SspformH1 : NewBaseEntity
{
    public string? BusinessId { get; set; }

    public string? CompanyId { get; set; }

    public string? TaxPayerId { get; set; }

    public string? IndividalId { get; set; }
    [NotMapped]
    public string? FIRSTNAME { get; set; }
    [NotMapped]
    public string? SURNAME  { get; set; }
    [NotMapped]
    public string? Designation { get; set; }
    [NotMapped]
    public string? NATIONALITY { get; set; }
   
    public string Rin { get; set; } = null!;

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

    public DateTime? Datetcreated { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Modifiedby { get; set; }
}
public partial class ReturnSspformH1 : NewBaseEntity
{
    public string? BusinessId { get; set; }

    public string? CompanyId { get; set; }

    public string? TaxPayerId { get; set; }

    public string? IndividalId { get; set; }
    public string? FIRSTNAME { get; set; }
    public string? SURNAME  { get; set; }
    public string? Designation { get; set; }
    public string? NATIONALITY { get; set; }
    public decimal? Total { get; set; }

    public string Rin { get; set; } = null!;

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

    public DateTime? Datetcreated { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Modifiedby { get; set; }
}

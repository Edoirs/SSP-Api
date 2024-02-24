using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfPortalAPi.NewModel;

public partial class SspformH3 : NewBaseEntity
{

    public string? BusinessId { get; set; }

    public string? CompanyId { get; set; }

    public string? Rin { get; set; }

    public string? TaxPayerId { get; set; }

    public string? IndividualId { get; set; }

    public string? Startmonth { get; set; }

    public decimal? Rent { get; set; }

    public decimal? Transport { get; set; }

    public decimal? Basic { get; set; }

    public decimal? OtherIncome { get; set; }

    public decimal? Pension { get; set; }

    public decimal? Nhf { get; set; }

    public decimal? Nhis { get; set; }

    public decimal? Lifeassurance { get; set; }

    public DateTime? Datetcreated { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Modifiedby { get; set; }
}
public partial class ReturnSspformH3 : NewBaseEntity
{
    [NotMapped]
    public int? NumberOfMonths { get; set; }
    public string? BusinessId { get; set; }

    public string? CompanyId { get; set; }

    public string? Rin { get; set; }

    public string? TaxPayerId { get; set; }

    public string? IndividualId { get; set; }

    public string? Startmonth { get; set; }

    public decimal? Rent { get; set; }
    public string? FIRSTNAME { get; set; }
    public string? SURNAME { get; set; }
    public string? NATIONALITY { get; set; }
    public decimal? Total { get; set; }

    public decimal? Transport { get; set; }

    public decimal? Basic { get; set; }

    public decimal? OtherIncome { get; set; }

    public decimal? Pension { get; set; }

    public decimal? Nhf { get; set; }

    public decimal? Nhis { get; set; }

    public decimal? Lifeassurance { get; set; }

    public DateTime? Datetcreated { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Modifiedby { get; set; }
}

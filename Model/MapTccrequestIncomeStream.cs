using System;
using System.Collections.Generic;

namespace SelfPortalAPi.Model;

public partial class MapTccrequestIncomeStream
{
    public long Trisid { get; set; }

    public long? TccrequestId { get; set; }

    public int? TaxYear { get; set; }

    public decimal? TotalIncomeEarned { get; set; }

    public int? TaxPayerRoleId { get; set; }

    public int? BusinessId { get; set; }

    public string? BusinessName { get; set; }

    public int? BusinessTypeId { get; set; }

    public int? Lgaid { get; set; }

    public int? BusinessOperationId { get; set; }

    public string? BusinessAddress { get; set; }

    public string? BusinessNumber { get; set; }

    public string? ContactPersonName { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}

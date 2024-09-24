using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfPortalAPi.Models;

public partial class TccRequest
{
    public long TCCRequestID { get; set; }

    public string? BusinessId { get; set; }

    public string? EmployeeId { get; set; } = null!;

    public int? TaxPayerTypeID { get; set; }
    public int? TccRequestYear { get; set; }
    public int? TccStatus { get; set; }

    public DateTime? DateRequested { get; set; }
    public DateTime? ModifiedDate { get; set; }

    public string? RequestedById { get; set; }

    public string? FormH2pathName { get; set; }

    public string? TccRequestRefNo { get; set; }

    public string? ModifiedBy { get; set; }

    public int? TaxOfficeId { get; set; }
}

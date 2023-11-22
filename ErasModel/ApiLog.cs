using System;
using System.Collections.Generic;

namespace SelfPortalAPi.ErasModel;

public partial class ApiLog
{
    public int LogId { get; set; }

    public string? RequestHeaders { get; set; }

    public string? RequestContentType { get; set; }

    public string? RequestUri { get; set; }

    public string? RequestBody { get; set; }

    public string? RequestMethod { get; set; }

    public DateTime? RequestTimestamp { get; set; }

    public string? ResponseHeaders { get; set; }

    public string? ResponseContentType { get; set; }

    public string? ResponseBody { get; set; }

    public int? ResponseStatusCode { get; set; }

    public DateTime? ResponseTimestamp { get; set; }
}

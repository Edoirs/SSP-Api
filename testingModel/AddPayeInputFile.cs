using System;
using System.Collections.Generic;

namespace SelfPortalAPi.testingModel;

public partial class AddPayeInputFile
{
    public string CompanyRin { get; set; } = null!;

    public string BusinessRin { get; set; } = null!;

    public string TaxYear { get; set; } = null!;

    public int? Id { get; set; }
}

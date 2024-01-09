using System;
using System.Collections.Generic;

namespace SelfPortalAPi.PayeModel;

public partial class EmployeeContributionOutputFile
{
    public string? EmployeRin { get; set; }

    public int? AssessmentYear { get; set; }

    public decimal? JanuaryContributions { get; set; }

    public decimal? FebruaryContributions { get; set; }

    public decimal? MarchContributions { get; set; }

    public decimal? AprilContributions { get; set; }

    public decimal? MayContributions { get; set; }

    public decimal? JuneContributions { get; set; }

    public decimal? JulyContributions { get; set; }

    public decimal? AugustContributions { get; set; }

    public decimal? SpetemberContributions { get; set; }

    public decimal? OctoberContributions { get; set; }

    public decimal? NovemberContributions { get; set; }

    public decimal? DecemberContributions { get; set; }

    public int? Id { get; set; }

    public int? ApiId { get; set; }
}

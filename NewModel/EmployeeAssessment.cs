namespace SelfPortalAPi.NewModel
{
    public partial class EmployeeAssessment
    {
        public int EmployeeID { get; set; } // FK references Employee_Monthly_Schedule table
        public int BusinessID { get; set; } // FK references Employee_Monthly_Schedule table
        public int EmployeeRIN { get; set; } // FK references Employee_Monthly_Schedule table
        public int TaxYear { get; set; }
        public int TaxMonth { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalAssessed { get; set; }
        public string? AssessmentRefNo { get; set; }
        public string? AssessmentRefID { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}

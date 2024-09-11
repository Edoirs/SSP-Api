namespace SelfPortalAPi.NewModel
{
    public partial class EmployeeAssessmentHistory
    {
        public string? EmployerID { get; set; } // FK references EmployeeMonthlySchedule table
        public string? BusinessID { get; set; } // FK references EmployeeMonthlySchedule table
        public string? EmployeeRIN { get; set; } // FK references EmployeeMonthlySchedule table
        public int? TaxYear { get; set; }
        public string TaxMonth { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalAssessed { get; set; }
        public string? AssessmentRefNo { get; set; }
        public int? AssessmentRefID { get; set; }
        public string? AssCreatedBy { get; set; }
        public DateTime? AssCreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}

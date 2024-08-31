namespace SelfPortalAPi.NewModel
{
    public partial class EmployeeMonthlySchedule
    {
        public int Employer_ID { get; set; } // FK references Employee_uploaded_files table
        public int Business_ID { get; set; } // FK references Employee_uploaded_files table
        public int Employee_RIN { get; set; } // FK references Employee_uploaded_files table
        public int TaxYear { get; set; }
        public string? TaxMonth { get; set; }
        public decimal? Basic { get; set; }
        public decimal? Rent { get; set; }
        public decimal? Transport { get; set; }
        public decimal? OtherIncome { get; set; }
        public decimal? Pension { get; set; }
        public decimal? NHF { get; set; }
        public decimal? NHIS { get; set; }
        public decimal? LifeAssurance { get; set; }
        public decimal? CRA { get; set; }
        public decimal? TFP { get; set; }
        public decimal? CI { get; set; }
        public decimal? Tax { get; set; }
        public int AssessmentStatusID { get; set; } // FK references Assessment_status table
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}

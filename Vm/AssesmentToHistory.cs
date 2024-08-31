namespace SelfPortalAPi.Vm
{
    public class AssesmentToHistory
    {
        public string EmployerId { get; set; } = null!;

        public string BusinessId { get; set; } = null!;

        public string? EmployeeRin { get; set; }

        public int? TaxYear { get; set; }

        public string? TaxMonth { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? TotalAssessed { get; set; }

        public string? AssessmentRefNo { get; set; }

        public string? AssessmentRefId { get; set; }

        public string? AssCreatedBy { get; set; }

        public DateTime? AssCreatedDate { get; set; }
    }

}

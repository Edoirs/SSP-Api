namespace SelfPortalAPi.PhaseIIVm
{
    public class EmployeeIncomeVm
    {
        public string? EmployeeRin { get; set; }
        public string? FullName { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal Non_TaxableIncome { get; set; }
        public decimal GrossIncome { get; set; }
        public string? Status { get; set; }
    }
}

namespace SelfPortalAPi.Vm
{
    public class ScheduleGetAllRes
    {
        public string? BusinessRin { get; set; }
        public string? CompanyRin { get; set; }
        public string? BusinessName { get; set; }
        public string? TaxMonth { get; set; }
        public int? TaxYear { get; set; }
        public int EmployeeCount { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? MonthlyTax { get; set; }
        public DateTime? DateForwarded { get; set; }
        public string? AssessementStatus { get; internal set; }
    }
    public class ScheduleForAss
    {
        public string? BusinessId { get; set; } 
        public string? CompanyId  { get; set; } 
        public string? CompanyRin  { get; set; } 
        public string? TaxMonth  { get; set; } 
        public int? TaxYear  { get; set; }
    }

    public class CompDetailsRes
    {
        public string? TaxpayerName { get; set; }
        public string? BusinessName { get; set; }
        public string? BusinessAddress { get; set; }
    }
    public class BusDetailsRes
    {
        public string? TaxpayerRin { get; set; }
        public string? BusinessRin { get; set; }
        public string? BusinessPhone { get; set; }
    }
    public class Schedulepdf
    {
        public int SerialNo { get; set; }
        public string? Rin { get; set; }
        public string? Name { get; set; }
        public string? TaxMonth { get; set; }
        public int? TaxYear { get; set; }
        public decimal? Gross { get; set; }
        public decimal? Cra { get; set; }
        public decimal? Pension { get; set; }
        public decimal? Nhf { get; set; }
        public decimal? Nhis { get; set; }
        public decimal? Tfp { get; set; }
        public decimal? Ci { get; set; }
        public decimal? Tax { get; set; }
    }

    public class ScheduleGetViewRes
    {
        public string? EmployeeRin { get; set; }
        public string? EmployeeName { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? GrossIncome { get; set; }
        public decimal? NonTaxableIncome { get; set; }
        public decimal? CRA { get; set; }
        public decimal? TaxFreePay { get; set; }
        public decimal? ChargableIncome { get; set; }
        public decimal? MonthlyTax { get; set; }

    }
    public enum AssessmentStatusEnum
    {
        Approved = 1,
        AwaitingApproval = 2,
        ReAssessed = 3
    }
    public class EmpSchFm
    {
        public string? BusinessId { get; set; }
        public string? Companyid { get; set; }
    }
    public class EmpSchFm1
    {
        public string? BusinessRin { get; set; }
        public string? CompanyRin { get; set; }
    }
    public class BusSchFm
    {
        public string? BusinessRin { get; set; }
        public string? CompanyRin { get; set; }
        public string? TaxMonth { get; set; }
        public int? TaxYear { get; set; }
    }
    public class BusSchFm1
    {
        public string? BusinessId { get; set; }
        public string? CompanyId { get; set; }
        public string? TaxMonth { get; set; }
        public int? TaxYear { get; set; }
    }

}

namespace SelfPortalAPi.Vm
{
    public class ScheduleH3
    {
        public string? BusinessRin { get; set; }
        public string? CompanyRin { get; set; }
        public int TaxYear { get; set; }
    }
    public class TccH1
    {
        public string? BusinessRin { get; set; }
        public string? CompanyRin { get; set; }
    }
    public class ProjectRes
    {
        public string? BusinessRin { get; set; }
        public string? BusinessName{ get; set; }
        public string? CompanyRin { get; set; }
        public int TaxYear { get; set; }
        public int EmployeeCount { get; set; }
    }
    public class TccRes
    {
        public string? BusinessRin { get; set; }
        public string? BusinessName { get; set; }
        public string? CompanyRin { get; set; }
        public int TccStatus { get; set; }
        public int EmployeeCount { get; set; }
        public string? RequestTCC { get; set; }
    }
    public class CombinedResult
    {
        public IEnumerable<BusinessVm> Businesses { get; set; } 
        public int TotalCount { get; set; }
    }
    public class CombinedResult2
    {
        public IEnumerable<BusinessRinVm> Businesses { get; set; } 
        public int TotalCount { get; set; }
    }
    public class CombinedResult3
    {
        public IEnumerable<ScheduleGetAllRes> Businesses { get; set; } 
        public int TotalCount { get; set; }
    }

    public class FormH1ScheduleViewModel
    {
        public string? EmployeeRin { get; set; }
        public string? EmployeeName { get; set; }
        public string? TccStatus { get; set; }
        public bool IsSelected { get; set; } 
    }

}

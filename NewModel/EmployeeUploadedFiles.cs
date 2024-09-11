namespace SelfPortalAPi.NewModel
{
    public partial class EmployeeUploadedFiles
    {
        public int EmployerId { get; set; }
        public int BusinessId { get; set; }
        public string? EmployeeRin { get; set; }
        public string? EmployeeId { get; set; }  // This can be used for Individual_ID as well
        public string? IndividualRin { get; set; }
        public string? Designation { get; set; }
        public decimal? Basic { get; set; }
        public decimal? Rent { get; set; }
        public decimal? Transport { get; set; }
        public decimal? OtherIncome { get; set; }
        public decimal? Pension { get; set; }
        public decimal? Nhf { get; set; }        // National Housing Fund
        public decimal? Nhis { get; set; }       // National Health Insurance Scheme
        public decimal? LifeAssurance { get; set; }
        public string? EmployeeStatusId { get; set; }
    }

    public enum EmployeeStatusId
    {
        Inactive = 0,
        Active = 1
    }

    public class MarkEmpInactive
    {
        public string? Employeeid { get; set; }
        public string? BusinessId { get; set; }
        public string? Companyid { get; set; }
    }
    public class MarkH3Inactive
    {
        public string? BusinessRin { get; set; }
        public string? CompanyRin { get; set; } 
        
    }
    public class MarkEmpInactive1
    {
        [Required]
        public string BusinessRin { get; set; }
        [Required]
        public string CompanyRin { get; set; }
        public string? EmployeeRin { get; set; }
        [Required]
        public int ActiveDet { get; set; }
    }

    public class UpdateEmpIncome
    {
        public string? EmployeeId { get; set; } = null!;

        public string? BusinessId { get; set; } = null!;
        public string? Companyid { get; set; } 

        public decimal Basic { get; set; } 

        public decimal Rent { get; set; }

        public decimal Transport { get; set; }

        public decimal Ltg { get; set; }

        public decimal Utility { get; set; }

        public decimal Meal { get; set; }

        public decimal Others { get; set; }

        public decimal Nhf { get; set; }

        public decimal Nhis { get; set; } 
        public decimal Pension { get; set; }

        public decimal LifeAssurance { get; set; }

    }
    public class UpdateEmpIncome1
    {
        public string EmployeeRin { get; set; } = null!;

        public string BusinessRin { get; set; } = null!;
        public string CompanyRin { get; set; } 

        public decimal Basic { get; set; } 

        public decimal Rent { get; set; }

        public decimal Transport { get; set; }

        public decimal Ltg { get; set; }

        public decimal Utility { get; set; }

        public decimal Meal { get; set; }

        public decimal Others { get; set; }

        public decimal Nhf { get; set; }

        public decimal Nhis { get; set; } 
        public decimal Pension { get; set; }

        public decimal LifeAssurance { get; set; }

    }

    public class EmpSchedule
    {
        public string? BusinessId { get; set; }

        public string? Companyid { get; set; }
        public string? EmployeeRin { get; set; }
        public int Year { get; set; }

        public string? Month { get; set; }

    }
    public class BusCmp
    {
        public string? BusinessId { get; set; }
        public string? Companyid { get; set; }

    }
    public class EmpSchedule1
    {
        public string? BusinessId { get; set; }

        public string? CompanyId { get; set; }
        public int Year { get; set; }

        public string? Month { get; set; }

    }

    public class EmpScheduleDetails
    {
        public string? EmployeeId { get; set; }
        public string? BusinessId { get; set; }
        public string? Companyid { get; set; }
        public int TaxYear { get; set; }
        public string? TaxMonth { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal NonTaxableIncome { get; set; }
        public decimal GrossIncome { get; set; }
        public decimal Cra { get; set; }
        public decimal Tfp { get; set; }
        public decimal Ci { get; set; }
        public decimal Tax { get; set; }


    }
    public class ScheduleList
    {
        public string? BusinessId { get; set; }
        public string? CompanyId { get; set; }

    }


    public class FormH1FormModel
    {
        public string? BusinessId { get; set; }
        public string? CompanyId { get; set; }
    }
    public class FormH1FormModel1
    {
        public string? BusinessRin { get; set; }
        public string? CompanyRin { get; set; }
    }
    public class AddFormEmployee : FormH1FormModel1
    {
        public IFormFile File { get; set; }
    }
    public class UploadEmployeesFm
    {
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? OtherName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? RIN { get; set; }
        public string? JTBTIN { get; set; }
        public string? NIN { get; set; }
        public string? Nationality { get; set; }
        public string? HomeAddress { get; set; }
        public decimal Basic { get; set; }
        public decimal Rent { get; set; }
        public decimal Transport { get; set; }
        public decimal OtherIncome { get; set; }
        public decimal Pension { get; set; }
        public decimal NHF { get; set; }
        public decimal NHIS { get; set; }
        public decimal LifeAssurance { get; set; }
        public decimal Meal { get; set; }
        public decimal Utility { get; set; }
        public decimal Ltg { get; set; }
    }
    public class UploadEmployeesFm2
    {
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? OtherName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? RIN { get; set; }
        public string? JTBTIN { get; set; }
        public string? NIN { get; set; }
        public string? Nationality { get; set; }
        public string? HomeAddress { get; set; }
        public string? Basic { get; set; }
        public string? Rent { get; set; }
        public string? Transport { get; set; }
        public string? OtherIncome { get; set; }
        public string? Pension { get; set; }
        public string? NHF { get; set; }
        public string? NHIS { get; set; }
        public string? LifeAssurance { get; set; }
        public string? Meal { get; set; }
        public string? Utility { get; set; }
        public string? Ltg { get; set; }
    }
    public class EmployeesViewFmModel
    {
        public string? BusinessId { get; set; }
        public string? CompanyId { get; set; }
        public string? EmployeeId  { get; set; }
     
    }
    public class EmployeesMonthlyIncomeRes
    {
        public int Id { get; set; }

        public string EmployeeId { get; set; } = null!;

        public string? BusinessId { get; set; }

        public string? CompanyId { get; set; }

        public string? Basic { get; set; }

        public string? Rent { get; set; }

        public string? Transport { get; set; }

        public string? Ltg { get; set; }

        public string? Utility { get; set; }

        public string? Meal { get; set; }

        public string? Others { get; set; }

        public string? Nhf { get; set; }

        public string? Nhis { get; set; }

        public string? Pension { get; set; }

        public string? LifeAssurance { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }
    }

}

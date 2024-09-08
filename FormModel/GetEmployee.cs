using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPortalAPi.FormModel
{
    public class GetEmployee
    {
        public string corporate_id { get; set; }
        public int business_id { get; set; }
    }
    public class CompanyStep
    {
        [Required(ErrorMessage = "Please enter Company Rin")]
        [Display(Name = "Company Rin")]
        public string CompanyRin { get; set; }

    }
    public class CompanyStep1
    {
        public bool IsAdmin { get; set; }
        [Required(ErrorMessage = "Please enter Company Rin")]
        [Display(Name = "Company Rin")]
        public string CompanyRin { get; set; }
        [Required(ErrorMessage = "Please enter Phone Number")]
        [Display(Name = "Company Phone Number")]
        public string PhoneNumber { get; set; }
    }
    public class CompanyStep2
    {
        [Required(ErrorMessage = "Please enter Company Rin")]
        [Display(Name = "Company Rin")]
        public string CompanyRin { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        [Display(Name = "Company Password")]
        public string Password { get; set; }
    }
    public class CompanyStepOne
    {
        [Required(ErrorMessage = "Please enter Company Rin")]
        [Display(Name = "Company Rin")]
        public string? CompanyRin { get; set; }
        [Required(ErrorMessage = "Please enter Company Name")]
        [Display(Name = "CompanyName")]
        [StringLength(140, MinimumLength = 5)]
        public string? CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Number")]
        [StringLength(14, MinimumLength = 10)]
        public string? MobileNumber1 { get; set; }
        [Required(ErrorMessage = "Please enter Contact Address")]
        [Display(Name = "Contact Address")]
        public string? ContactAddress { get; set; }
    }
    public class CompanyStepTwo
    {
        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Enter your Confirm password")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        public string? ConfirmPassword { get; set; }
        public int? VerificationOtp { get; set; }
    }
}

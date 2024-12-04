using FluentValidation;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SelfPortalAPi
{
    public class FM
    {
        public string? MDAServiceID { get; set; } = null;
        public string? TaxYear { get; set; }
        public string? MDAServiceName { get; set; } = null;
        public string? MDAName { get; set; } = null;
    }

    public class FormH1FormModel
    {
        public string BusinessId { get; set; }
        public string CompanyId { get; set; }
    }
    public class AddFormH : FormH1FormModel
    {
        public IFormFile File { get; set; }
    }
    public class AddFormHWith : FormH1FormModel
    {
        public string File { get; set; }
    }
    public class FileFormH1 : FormH1FormModel
    {

        public int TaxYear { get; set; }
    }
    public class TaxPayers : FormH1FM
    {

        [Required(ErrorMessage = "BusinessId is required")]
        public string BusinessId { get; set; }

        [Required(ErrorMessage = "CompanyId is required")]
        public string CompanyId { get; set; }

        [Required(ErrorMessage = "TaxPayerId is required")]
        public string TaxPayerId { get; set; }
    }

    public class TaxPayersH3
    {
        public string? BusinessId { get; set; }
        public string? CompanyId { get; set; }
        public string? TaxPayerId { get; set; }
        public string? FIRSTNAME { get; set; }
        public string? SURNAME { get; set; }
        public string? OTHERNAME { get; set; }
        public string? PHONENUMBER { get; set; }
        public string? JTBTIN { get; set; }
        public string? NIN { get; set; }
        public string? RIN { get; set; }
        public string? NATIONALITY { get; set; }
        public string? HOMEADDRESS { get; set; }
        public string? Designation { get; set; }
        public string? STARTMONTH { get; set; }
        public string? Rent { get; set; }
        public string? Transport { get; set; }
        public string? Basic { get; set; }
        public string? OtherIncome { get; set; }
        public string? PENSION { get; set; }
        public string? NHF { get; set; }
        public string? NHIS { get; set; }
        public string? LIFEASSURANCE { get; set; }
    }
    public class FormH1FM
    {
        public string FIRSTNAME { get; set; }
        public string? SURNAME { get; set; }
        public string? OTHERNAME { get; set; }
        public string? PHONENUMBER { get; set; }
        public string? RIN { get; set; }
        public string? JTBTIN { get; set; }
        public string? NIN { get; set; }
        public string? NATIONALITY { get; set; }
        public string? HOMEADDRESS { get; set; }
        public string? Designation { get; set; }
        public string? PENSION { get; set; }
        public string? NHF { get; set; }
        public string? NHIS { get; set; }
        public string? LIFEASSURANCE { get; set; }
        public string? CONSOLIDATEDRELIEFALLOWANCECRA { get; set; }
        public string? ANNUALTAXPAID { get; set; }
        public string? TOTALMONTHSPAID { get; set; }
        public string? Rent { get; set; }
        public string? Transport { get; set; }
        public string? Basic { get; set; }
        public string? OtherIncome { get; set; }

    }
    public class FormH3FM
    {
        public string FIRSTNAME { get; set; }
        public string SURNAME { get; set; }
        public string OTHERNAME { get; set; }
        public string PHONENUMBER { get; set; }
        public string JTBTIN { get; set; }
        public string NIN { get; set; }
        public string RIN { get; set; }
        public string NATIONALITY { get; set; }
        public string HOMEADDRESS { get; set; }
        public string Designation { get; set; }
        public string STARTMONTH { get; set; }
        public string Rent { get; set; }
        public string Transport { get; set; }
        public string Basic { get; set; }
        public string OtherIncome { get; set; }
        public string PENSION { get; set; }
        public string NHF { get; set; }
        public string NHIS { get; set; }
        public string LIFEASSURANCE { get; set; }

    }

    public class PersonInfo
    {

        //	TRANSPORT	OTHER INCOME	PENSION	NHF	NHIS	LIFE INSURANCE

        public int SerialNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string OtherName { get; set; }
        public string PhoneNumber { get; set; }
        public string RIN { get; set; }
        public string JTBTin { get; set; }
        public string NIN { get; set; }
        public string Nationality { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string Basic { get; set; }
        public string Rent { get; set; }
        public string Transport { get; set; }
        public string OtherIncome { get; set; }
        public string Pension { get; set; }
        public string NHF { get; set; }
        public string NHIS { get; set; }
        public string LifeInsurance { get; set; }

    }
    public class ProjectionFm
    {
        public string company_name { get; set; }
        public string taxpayer_id { get; set; }
        public int projection_year { get; set; }
        public string forwarded_to { get; set; }
        public string date_forwarded { get; set; }
        public int employees_count { get; set; }
        public string business_id { get; set; }
        public string business_name { get; set; }

    }
    public class AnnualReturnFm
    {
        //  public int id { get; set; }
        public string business_id { get; set; }
        public string business_name { get; set; }
        public string link_status { get; set; }
        public string industry_sector_name { get; set; }
        public string industry_subsector_name { get; set; }
        public string business_address { get; set; }
        public string lga_name { get; set; }
        public string town_name { get; set; }
        public string ward_name { get; set; }
        public int corporate_id { get; set; }
        public string taxpayer_id { get; set; }
        public string company_name { get; set; }
        public int employees_count { get; set; }
        public string taxpayer_role { get; set; }
        public string created_at
        {
            get; set;
        }
    }
    public class IndividualFormModel
    {
        public string? IndividualRin { get; set; }

        public int? GenderId { get; set; }

        public int? TitleId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? MiddleName { get; set; }

        public DateTime? Dob { get; set; }

        public string? Tin { get; set; }

        public string? MobileNumber1 { get; set; }

        public string? MobileNumber2 { get; set; }

        public string? EmailAddress1 { get; set; }

        public string? EmailAddress2 { get; set; }

        public string? BiometricDetails { get; set; }

        public int? TaxOfficeId { get; set; }

        public int? MaritalStatusId { get; set; }

        public int? NationalityId { get; set; }

        public int? TaxPayerTypeId { get; set; }

        public int? EconomicActivitiesId { get; set; }

        public int? NotificationMethodId { get; set; }

        public string? ContactAddress { get; set; }
        public DateTime? RegisterationDate { get; set; }
        public int? TaxOfficerId { get; set; }

        public string? Nin { get; set; }
    }
    public class BusinessFormModel
    {
        public int BusinessId { get; set; }

        public int? BusinessTypeId { get; set; }

        public string? BusinessRin { get; set; }

        public string? BusinessName { get; set; }

        public int? Lgaid { get; set; }

        public int? AssetTypeId { get; set; }

        public int? BusinessCategoryId { get; set; }

        public int? BusinessSectorId { get; set; }

        public int? BusinessSubSectorId { get; set; }

        public int? BusinessStructureId { get; set; }

        public int? BusinessOperationId { get; set; }

        public int? SizeId { get; set; }

        public string? ContactName { get; set; }

        public string? BusinessNumber { get; set; }

        public string? BusinessAddress { get; set; }

        public bool? Active { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? DataSourceId { get; set; }

        public long? DsrefId { get; set; }

        public int? ZoneId { get; set; }

        public int? TaxOfficeId { get; set; }
    }
    public class TokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
    }
    public class AdminSignUp
    {
        public string UserRole { get; set; }
        public string UserName { get; set; }
    }
    public class UpdateUserResponse
    {
        public int UserId { get; set; }
        public string UserType { get; set; }
        public bool Status { get; set; }
    }
    public class UpdateUserResponseRole
    {
        public int UserId { get; set; }
        public string UserRole { get; set; }
    }


    public class JobSchedule
    {
        public Type JobType { get; }
        public string CronExpression { get; }

        public JobSchedule(Type jobType, string cronExpression)
        {
            JobType = jobType;
            CronExpression = cronExpression;
        }
    }

    public class TokenRequest
    {
        public string PhoneNumber_RIN { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
    //public class ChangePassword
    //{
    //    public string CompanyRin { get; set; }
    //}  
    public class UpdateUser
    {
        public bool IsAdmin { get; set; }
        public string NewPassword { get; set; }
        public string CompanyRin_Phone { get; set; }
        public int OTP { get; set; }
    }
    public class TokenRequestValidator : AbstractValidator<TokenRequest>
    {
        public TokenRequestValidator()
        {
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.PhoneNumber_RIN).NotEmpty();
            RuleFor(x => x.UserType).NotEmpty();
        }
    }

    public class BusinessViewModel
    {
        public string business_id { get; set; }
        public string company_id { get; set; }
        public string business_name { get; set; }
        public string link_status { get; set; }
        public string industry_sector_name { get; set; }
        public string industry_subsector_name { get; set; }
        public string business_address { get; set; }
        public string town_name { get; set; }
        public string ward_name { get; set; }
        public string lga_name { get; set; }
        public string created_at { get; set; }
        public string taxpayer_role { get; set; }
        public int taxpayer_role_id { get; set; }
        public int employees_count { get; set; }
    }

    //public class BusinessViewModelValidator : AbstractValidator<BusinessViewModel>
    //{
    //    public BusinessViewModelValidator()
    //    {
    //        RuleFor(x => x.AssetTypeID).NotEmpty();
    //        RuleFor(x => x.BusinessTypeID).NotEmpty();
    //        RuleFor(x => x.LGAID).NotEmpty();
    //        RuleFor(x => x.ZoneId).NotEmpty();
    //        RuleFor(x => x.TaxOfficeId).NotEmpty();
    //        RuleFor(x => x.BusinessCategoryID).NotEmpty();
    //        RuleFor(x => x.BusinessSectorID).NotEmpty();
    //        RuleFor(x => x.BusinessSubSectorID).NotEmpty();
    //        RuleFor(x => x.BusinessStructureID).NotEmpty();
    //        RuleFor(x => x.BusinessOperationID).NotEmpty();
    //        RuleFor(x => x.BusinessNumber).NotEmpty();
    //        RuleFor(x => x.BusinessAddress).NotEmpty();
    //        RuleFor(x => x.BusinessName).NotEmpty();
    //        RuleFor(x => x.BusinessRIN).NotEmpty();
    //    }
    //}
    public class IndividualViewModel
    {
        //public int IndividualID { get; set; }
        //public string IndividualRIN { get; set; }
        [Display(Name = "Gender")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select individual’s gender")]
        public int GenderID { get; set; }

        //   public string GenderName { get; set; }

        [Display(Name = "Title")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select title")]
        public int TitleID { get; set; }

        //  public string TitleName { get; set; }

        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter individuals first name")]
        [MaxLength(250, ErrorMessage = "Only 250 characters allowed.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter individuals surname name")]
        [MaxLength(250, ErrorMessage = "Only 250 characters allowed.")]
        public string LastName { get; set; }


        [Display(Name = "Middle Name")]
        [MaxLength(250, ErrorMessage = "Only 250 characters allowed.")]
        public string MiddleName { get; set; }


        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "TIN")]
        public string TIN { get; set; }
        [Display(Name = "NIN")]
        public string NIN { get; set; }

        [Display(Name = "Mobile No 1")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter mobile phone number of individual")]
        [RegularExpression(@"^[1-9][0-9]{9}$", ErrorMessage = "Looks like you entered invalid mobile number")]
        [MaxLength(10, ErrorMessage = "Only 10 numbers allowed.")]
        public string MobileNumber1 { get; set; }

        public string MobileNumber2 { get; set; }

        [Display(Name = "Email Address 1")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Enter valid email address")]
        public string EmailAddress1 { get; set; }

        [Display(Name = "Email Address 2")]
        [DataType(DataType.EmailAddress)]
        //[EmailAddress(ErrorMessage = "Enter valid email address")]
        public string EmailAddress2 { get; set; }


        [Display(Name = "Biometric Details")]
        public string BiometricDetails { get; set; }

        [Display(Name = "Tax Office")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Tax Office")]
        public int? TaxOfficeID { get; set; }


        [Display(Name = "Marital Status")]
        public int? MaritalStatusID { get; set; }


        [Display(Name = "Nationality")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Nationality")]
        public int NationalityID { get; set; }

        [Display(Name = "Tax Payer Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Tax Payer Type")]
        public int TaxPayerTypeID { get; set; }


        [Display(Name = "Economic Activity")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Economic Activity")]
        public int EconomicActivitiesID { get; set; }
        [Display(Name = "Preferred Notification")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Preferred Notification")]
        public int NotificationMethodID { get; set; }

        [Display(Name = "Contact Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Contact Address")]
        public string ContactAddress { get; set; }

    }
    public class IndividualViewModelValidator : AbstractValidator<IndividualViewModel>
    {
        public IndividualViewModelValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.FirstName).MaximumLength(250);
            RuleFor(x => x.ContactAddress).NotEmpty();
            RuleFor(x => x.ContactAddress).MaximumLength(250);
            RuleFor(x => x.NotificationMethodID).NotNull();
            RuleFor(x => x.TaxOfficeID).NotEmpty();
            RuleFor(x => x.TitleID).NotEmpty();
            RuleFor(x => x.TaxPayerTypeID).NotEmpty();
            RuleFor(x => x.NationalityID).NotEmpty();
            RuleFor(x => x.EconomicActivitiesID).NotEmpty();
            RuleFor(x => x.EmailAddress1).NotEmpty();
            RuleFor(x => x.EmailAddress1).MaximumLength(200);
            RuleFor(x => x.EmailAddress1).EmailAddress();
            RuleFor(x => x.MobileNumber1).NotEmpty();
        }
    }
}

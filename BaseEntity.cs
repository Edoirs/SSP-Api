

namespace SelfPortalAPi
{
    public class NewBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public string BusinessName { get; set; }
        [NotMapped]
        public string CompanyName { get; set; }
    }
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public long ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class SelfBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public string? EmployeeId { get; set; }
    }
    public class Receiver
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public List<TaxPayerClassResult> Result { get; set; }
    }
    public class ReceiverError
    {
        public int Id { get; set; }
        public List<Receiver> Error { get; set; }
    }
    public class AddTaxPayer
    {
        public int PresentTaxOfficeID { get; set; }
        public int NewTaxOfficeID { get; set; }
        public int TaxPayerTypeId { get; set; }
        public int GenderID { get; set; }
        public int TitleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string DOB { get; set; }
        public string TIN { get; set; }
        public string MobileNumber1 { get; set; }
        public string EmailAddress1 { get; set; }
        public string BiometricDetails { get; set; }
        public int TaxOfficeID { get; set; }
        public int MaritalStatusID { get; set; }
        public int NationalityID { get; set; }
        public int EconomicActivitiesID { get; set; }
        public int NotificationMethodID { get; set; }
        public string ContactAddress { get; set; }
    }

    public class TaxPayerClassResult
    {
        public long TaxPayerID { get; set; }
        public int TaxPayerTypeID { get; set; }
        public string TaxPayerRIN { get; set; }
        public string TaxPayerName { get; set; }
        public string TaxPayerMobileNumber { get; set; }
        public string TaxPayerAddress { get; set; }
        public string TaxOfficeID { get; set; }
        public string TaxOfficeName { get; set; }
        public string TaxPayerTypeName { get; set; }
    }
    public class ConnectionStrings
    {
        public string SmsBaseUrl { get; set; }
        public string eirsusername { get; set; }
        public string eirspassword { get; set; }
        public string ErasBaseUrl { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string templatepath { get; set; }
        public string HtmlTemplatePath { get; set; }
        public string upload { get; set; }
        public string EirsContext { get; set; }
        public string ERASContext { get; set; }
        public string DefaultConnection { get; set; }
    }
}

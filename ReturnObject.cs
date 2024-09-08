
namespace SelfPortalAPi
{
    public class ReturnObject
    {
        public int id { get; set; }
        public dynamic data { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
    }
    public class ReturnAPIObject
    {
        public bool Success { get; set; }
        public object Message { get; set; }
    }

    public class GetPayeTaxOffice: ReturnAPIObject
    {
        public ResultGetPayeTaxOffice[] Result { get; set; }
    }

    public class ResultGetPayeTaxOffice
    {
        public string taxofficeId { get; set; }
        public string taxofficeName { get; set; }
    }


    public class TaxOfficerLoginDetail : ReturnAPIObject
    {
        public Result Result { get; set; }
    }

    public class Result
    {
        public int UserID { get; set; }
        public int UserTypeID { get; set; }
        public string? UserTypeName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? ContactName { get; set; }
        public string? EmailAddress { get; set; }
        public string? ContactNumber { get; set; }
        public bool Active { get; set; }
        public string? ActiveText { get; set; }
        public bool? IsTOManager { get; set; }
        public string? IsTOManagerText { get; set; }
        public int TaxOfficeID { get; set; }
        public string? TaxOfficeName { get; set; }
        public string? TOManagerID { get; set; }
        public string? TOManagerName { get; set; }
        public string? SignaturePath { get; set; }
        public bool IsDirector { get; set; }
        public string? IsDirectorText { get; set; }
    }

}

using Bogus.DataSets;

namespace SelfPortalAPi.Vm
{
    public class AssessmentRDMRes
    {
        public int? TaxPayerTypeID { get; set; }
        public string? TaxPayerID { get; set; }
        public int? AssetTypeID { get; set; }
        public int? AssetID { get; set; }
        public string? Notes { get; set; }
        public int? TaxYear { get; set; }
        public decimal? TaxBaseAmount { get; set; }
        public int? ProfileID { get; set; }
        public long? AssessmentRuleID { get; set; }
        public List<AssessmentItemss> LstAssessmentItem { get; set; } // Added property
    }
    public class AssessmentItemss
    {
        public int? AssessmentItemID { get; set; }
        public decimal? TaxBaseAmount { get; set; } // Ensure this property matches your data source
    }

    public class ResponseModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<AssessmentRefRes> Result { get; set; } // Adjust based on your actual API response structure
    }
    public class AssessmentRefRes
    {
        public string? AssessmentRefNo { get; set; }
        public string? AssessmentRefId { get; set; }
    }
    public class EmpMtAss
    {
        public string? BusinessRin { get; set; }
        public string? CompanyRin { get; set; }
        public string? TaxMonth { get; set; }
        public int TaxYear { get; set; }
    }
    public class AllAssessmentRess
    {
        public string? BusinessRin { get; set; }
        public string? BusinessName { get; set; }
        public DateTime DateGenerated { get; set; }
        public string? TaxMonth { get; set; }
        public int TaxYear { get; set; }
        public int ListofEmployees { get; set; }
        public string? AssessmentRefNo { get; set; }
        public int? AssessmentRefId { get; set; }
        public Decimal? TotalMonthlyTax { get; set; }
        public Decimal? AmountPaid { get; set; }
        public Decimal? Balance { get; set; }
        public string? PaymentStatus  { get; set; }
    }


}

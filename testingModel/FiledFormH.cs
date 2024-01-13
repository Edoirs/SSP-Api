namespace SelfPortalAPi.testingModel
{
    public class FiledFormH : BaseEntity
    {
        public string TaxYear { get; set; }
        public string FiledStatus { get; set; }
        public string BusinessId { get; set; }
        public string CompanyId { get; set; }
        public int Source { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal AnnualTaxPaid { get; set; }
    }
}

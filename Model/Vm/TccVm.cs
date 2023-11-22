namespace SelfPortalAPi.Model.Vm
{
    public class TccVm
    {
        public long TccrequestId { get; set; }
        public string? RequestRefNo { get; set; }
        public DateTime? RequestDate { get; set; }
        public long? ServiceBillId { get; set; }
        public int? TaxPayerId { get; set; }
        public int? TaxPayerTypeId { get; set; }
        public int? TaxYear { get; set; }
        public int? StatusId { get; set; }
        public int? VisibleSignStatusId { get; set; }
        public int? PdftemplateId { get; set; }
        public string? GeneratedPath { get; set; }
        public string? ValidatedPath { get; set; }
        public string? SignedVisiblePath { get; set; }
        public string? SignedDigitalPath { get; set; }
        public string? SealedPath { get; set; }
        public int? SedeDocumentId { get; set; }
        public long? SedeOrderId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}

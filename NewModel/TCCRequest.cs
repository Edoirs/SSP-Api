namespace SelfPortalAPi.NewModel
{
    public partial class TCCRequest
    {
        public int EmployerTaxpayerID { get; set; } 
        public int BusinessID { get; set; } 
        public int EmployeeID { get; set; } 
        public int TCCRequestYear { get; set; } 
        public DateTime? DateRequested { get; set; } // Nullable DateTime
        public int RequestedByID { get; set; } 
        public string? FormH2PathName { get; set; } // Nullable string
        public string? TCCRequestRefNo { get; set; }
    }
}

namespace SelfPortalAPi.Vm
{
    public class BusinessVm
    {
        //assetId=>businessId,assetName=>businessName, lga=>assetLgaName
        public string? BusinessRin { get; set; }
        public string? BusinessName { get; set; }
        public string? LgaName { get; set; }
        public string? CompanyRin { get; set; }
        public string? CompanyName { get; set; }
        public string? TaxOffice { get; set; }
    }

    public class BusinessRinVm
    {
        public int? businessId { get; set; }
        public string? businessRin { get; set; }
        public string? CompanyRin { get; set; }
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? businessName { get; set; }
        public string? businessAddress { get; set; }
        public string? businessLga { get; set; }
        public string? taxOffice { get; set; }
        public int? NoOfEmployees { get; set; }
    }
    public class FileFormH3Vm
    {
        public string? BusinessRin { get; set; }
        public string? BusinessName { get; set; }
        public decimal? TotalIncome { get; set; } 
        public decimal? NonTaxibleIncome { get; set; } 
    }

    //public class BusinessRinVm
    //{
    //    public string? business_rin { get; set; }
    //    public string? business_name { get; set; }
    //    public string? business_address { get; set; }
    //    public string? business_lga { get; set; }
    //    public int? total_businesses { get; set; }
    //}
}

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SelfPortalAPi.NewModel.ResModel
{
    public class BusinessReturnModel
    {
        public string BusinessID { get; set; }
        public string BusinessName { get; set; }
        public string BusinessRIN { get; set; }
        public string BusinessAddress { get; set; }
        public string TaxPayerName { get; set; }
        public string NoOfEmployees { get; set; }
        public string DateForwarded { get; set; }
        public string ProjectionYear { get; set; }

    } 
    public class NewBusinessReturnModel
    {
        public string BusinessID { get; set; }
        public string BusinessName { get; set; }
        public string BusinessRIN { get; set; }
        public string CompanyRin { get; set; }
        public string ForwardedTO => "ERAS";
        public string DueDate => $"31st-Jan- {TaxYear}";
        public string AnnualReturnStatus { get; set; }
        public string NoOfEmployees { get; set; }
        public string DateForwarded { get; set; }
        public string TaxYear { get; set; }

    }
}

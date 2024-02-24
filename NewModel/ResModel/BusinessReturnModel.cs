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
}

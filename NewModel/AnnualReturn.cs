
namespace SelfPortalAPi.NewModel
{
    public class AnnualReturn : BaseEntity
    {
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
}

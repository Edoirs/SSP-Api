namespace SelfPortalAPi.testingModel
{
    public class Projection : BaseEntity
    {
        public string annual_projection_id { get; set; }
        public int corporate_id { get; set; }
        public int app_id { get; set; }
        public string company_name { get; set; }
        public string taxpayer_id { get; set; }
        public int projection_year { get; set; }
        public string file_projection_status { get; set; }
        public string forwarded_to { get; set; }
        public string date_forwarded { get; set; }
        public string created_at { get; set; }
        public int employees_count { get; set; }
        public string business_id { get; set; }
        public string business_name { get; set; }
        public int business_primary_id { get; set; }
        public int approval_status { get; set; }
        public bool status { get; set; } = false;
    }
}

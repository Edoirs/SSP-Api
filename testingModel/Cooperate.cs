
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPortalAPi.testingModel
{
    public class Cooperate: BaseEntity
    {
        public string email { get; set; }
        public string cac_number { get; set; }
        public string tin { get; set; }
        public string taxpayer_id { get; set; }
        public string phone { get; set; }
        public string company_name { get; set; }
        public string contact_address { get; set; }
        public string phone_2 { get; set; }
        public string email_2 { get; set; }
        public int status { get; set; }
        public int industry_sector_id { get; set; }
        public string corporate_logo { get; set; }
        public int tax_office_id { get; set; }
        public int created_by_app_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int has_valid_email { get; set; }
        public string reminder_sent_at { get; set; }
        public string reminder_annual_return_sent_at { get; set; }
        public string reminder_annual_projection_sent_at { get; set; }
        public string parent_taxpayer_id { get; set; }
        public string economic_activity_id { get; set; }
        public string company_type_id { get; set; }
        public string state_tin { get; set; }
        public string normalized_state_tin { get; set; }
        public string state_code { get; set; }
        public string lga_code { get; set; }
        public string active_status { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPortalAPi.NewTables
{
    public class Business: BaseEntity
    {
        public string business_id { get; set; }
        public string company_id { get; set; }
        public string business_name { get; set; }
        public string link_status { get; set; }
        public string industry_sector_name { get; set; }
        public string industry_subsector_name { get; set; }
        public string business_address { get; set; }
        public string town_name { get; set; }
        public string ward_name { get; set; }
        public string lga_name { get; set; }
        public string created_at { get; set; }
        public string taxpayer_role { get; set; }
        public int taxpayer_role_id { get; set; }
        public int employees_count { get; set; }
    }
}

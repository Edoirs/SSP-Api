using SelfPortalAPi.NewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPortalAPi.Vm
{
    public class EmployeeVm
    {
        public string bvn { get; set; }
        public string taxpayer_id { get; set; }
        public string tin { get; set; }
        public string email { get; set; }
        public string designation { get; set; }
        public string title { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string other_name { get; set; }
        public string nationality { get; set; }
        public string gross_income { get; set; }
        public string nhis { get; set; }
        public string nhf { get; set; }
        public string pension { get; set; }
        public int basic { get; set; }
        public int transport { get; set; }
        public int rent { get; set; }
        public string cra { get; set; }
        public string zip_code { get; set; }
        public string other_income { get; set; }
        public string phone { get; set; }
        public string start_month { get; set; }
        public int status { get; set; }
        public int corporate_id { get; set; }
        public string deleted_at { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string home_address { get; set; }
        public int total_income { get; set; }
        public int life_assurance { get; set; }
        public string state_tin { get; set; }
        public string normalized_state_tin { get; set; }
        public string state_code { get; set; }
        public string lga_code { get; set; }
        public string nin { get; set; }
        public string asset_id { get; set; }
        public int business_id { get; set; }
        public Cooperate Cooperates { get; set; }

    }
}

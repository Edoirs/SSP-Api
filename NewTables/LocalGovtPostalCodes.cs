using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPortalAPi.NewTables
{
    public class LocalGovtPostalCodes: BaseEntity
    {
        public int state_id { get; set; }
        public string city { get; set; }
        public string postalcode { get; set; }
        public int active { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string state { get; set; }
    }
}

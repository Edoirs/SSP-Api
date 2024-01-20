using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPortalAPi.NewModel
{
    public class LocalGovernment: BaseEntity
    {
        public string name { get; set; }
        public int active { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string lga_code { get; set; }
    }
}

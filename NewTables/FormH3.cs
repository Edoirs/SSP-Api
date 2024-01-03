using System.ComponentModel.DataAnnotations;

namespace SelfPortalAPi.NewTables
{
    public class FormH3
    {
        [Key]
        public int Id { get; set; }
        public string BusinessId { get; set; }
        public string CompanyId { get; set; }
        public string RIN { get; set; }
        public string TaxPayerId { get; set; }
        public string? FIRSTNAME { get; set; }
        public string? SURNAME { get; set; }
        public string? OTHERNAME { get; set; }
        public string? PHONENUMBER { get; set; }
        public string? JTBTIN { get; set; }
        public string? NIN { get; set; }
        public string? NATIONALITY { get; set; }
        public string? HOMEADDRESS { get; set; }
        public string? Designation { get; set; }
        public string? STARTMONTH { get; set; }
        public string? Rent { get; set; }
        public string? Transport { get; set; }
        public string? Basic { get; set; }
        public string? OtherIncome { get; set; }
        public string? PENSION { get; set; }
        public string? NHF { get; set; }
        public string? NHIS { get; set; }
        public string? LIFEASSURANCE { get; set; }
    }
}

     
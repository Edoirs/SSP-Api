namespace SelfPortalAPi.NewModel
{
    public partial class ComplianceStatus
    {
        public int ComplianceStatusID { get; set; } 
        public string? ComplianceStatusName { get; set; } // Nullable string

        public enum ComplianceStatusNames
        {
            Complied = 1,
            Defaulted
        }
    }
}

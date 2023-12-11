namespace SelfPortalAPi.NewTables
{
    public class UserManagement : BaseEntity
    {
        public int VerificationOtp { get; set; }
        public string? CompanyRin { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? CompanyName { get; set; }
        public string? Password { get; set; }
    }

}
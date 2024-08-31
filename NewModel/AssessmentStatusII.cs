namespace SelfPortalAPi.NewModel
{
    public partial class AssessmentStatusII
    {
        public int StatusId { get; set; }
        public string? StatusName { get; set; }
    }
    public enum StatusName : byte
    {
        Approved = 1,
        PendingApproval,
        ReAssessed
    }
}

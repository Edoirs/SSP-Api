namespace SelfPortalAPi.NewModel
{
    public partial class ProjectionStatus
    {
        public int ProjectionStatusID { get; set; } 
        public string? ProjectionStatusName { get; set; } // Nullable string

        public enum ProjectionStatusNames
        {
            Completed = 1,
            Pending
        }
    }
}

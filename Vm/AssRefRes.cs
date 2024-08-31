namespace SelfPortalAPi.Vm
{
    public class AssReturnObject
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public string? AssessmentRefNo { get; set; } 
        public object? data { get; set; }
    }
    public class AssRefRes
    {
        public string? AssessmentRefNo { get; set; }
    }

}

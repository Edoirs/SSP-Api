namespace SelfPortalAPi.NewTables
{

    public class Schedule:BaseEntity
    {
        public int forwarded_to { get; set; }
        public int assessment_status { get; set; }
        public string date_forwarded { get; set; }
        public int status { get; set; }
        public string due_date { get; set; }
        public int created_by_app_id { get; set; }
        public int user_id { get; set; }
        public int corporate_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int business_id { get; set; }
       // public Schedule_Records[] schedule_records { get; set; }
    }

    public class ScheduleFm
    {
        public int forwarded_to { get; set; }
        public int assessment_status { get; set; }
        public string date_forwarded { get; set; }
        public int status { get; set; }
        public string due_date { get; set; }
        public int created_by_app_id { get; set; }
        public int user_id { get; set; }
        public int corporate_id { get; set; }
        public int business_id { get; set; }
       public List<Schedule_RecordFm> schedule_records { get; set; }
    }

    public class Schedule_RecordFm
    {
        public int gross_income { get; set; }
        public int nhis { get; set; }
        public int nhf { get; set; }
        public int pension { get; set; }
        public float cra { get; set; }
        public int employee_id { get; set; }
        public int schedule_id { get; set; }
        public int total_income { get; set; }
        public int life_assurance { get; set; }
    }
    public class Schedule_Record:BaseEntity
    {
        public int gross_income { get; set; }
        public int nhis { get; set; }
        public int nhf { get; set; }
        public int pension { get; set; }
        public float cra { get; set; }
        public int employee_id { get; set; }
        public int schedule_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int total_income { get; set; }
        public int life_assurance { get; set; }
    }
}

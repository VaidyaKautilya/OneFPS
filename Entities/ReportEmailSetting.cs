namespace OneFPS.Entities
{
    public class ReportEmailSetting
    {
        public int Id { get; set; }
        public string Recipients { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool Has_Attachment_Link { get; set; }
        public ScheduleReportManager ScheduleReportManager { get; set; }
        public int Scheduled_Report_ID { get; set; }

    }
}

using System;

namespace OneFPS.Entities
{
    public class ReportFrequancy
    {
        public int Id { get; set; }
        public bool IsReattempt { get; set; }
        public bool Reattempt_Occurence { get; set; }
        public int Reattempt_Hour { get; set; }
        public DateTime Created_At { get; set; }
        public ScheduleReportManager ScheduleReportManager { get; set; }
        public int Scheduled_Report_ID { get; set; }

    }
}

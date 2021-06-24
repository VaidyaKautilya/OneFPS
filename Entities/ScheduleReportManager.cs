namespace OneFPS.Entities
{
    public class ScheduleReportManager
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string Status { get; set; }
        public string TransMissionType { get; set; }
        public string ParameterJson { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int UseReportPageSize { get; set; }
        public string FileStoragePath { get; set; }
        public int ReportFrequancyId { get; set; }
        public int ReportFileSettingId { get; set; }
    }
}

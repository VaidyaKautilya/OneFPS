using System.ComponentModel.DataAnnotations;

namespace OneFPS.Entities
{
    public class ReportFileSetting
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string FileName { get; set; }

        public bool IsDatePrefix { get; set; }
        public bool IsDateSuffix { get; set; }
        public string AttechedFileType { get; set; }
        public int ScheduleReportId { get; set; }
    }
}

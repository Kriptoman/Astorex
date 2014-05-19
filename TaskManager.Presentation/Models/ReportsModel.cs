using System;
using System.Collections;

namespace TaskManager.Presentation.Models
{
    public class ReportsModel
    {
        public DateTime? PeriodStart { get; set; }

        public DateTime? PeriodEnd { get; set; }

        public ReportType Type { get; set; }

        public IEnumerable Staff { get; set; }

        public int EmployeeId { get; set; }
    }

    public enum ReportType
    {
        Developer = 0,

        QA = 1
    }
}

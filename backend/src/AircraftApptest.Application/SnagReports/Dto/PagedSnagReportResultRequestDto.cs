using System;
using Abp.Application.Services.Dto;

namespace AircraftApptest.SnagReports.Dto
{
    public class PagedSnagReportResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string Keyword { get; set; }
        public long? AircraftId { get; set; }
        public string AtaChapter { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Severity { get; set; }
        public long? ReportedById { get; set; }
        public DateTime? DetectionDate { get; set; }
        public string WorkPerformed { get; set; }
        public string CrsNumber { get; set; }
        public string RevisionNote { get; set; }
        public int? Status { get; set; }
        public long? LineMechanicId { get; set; }
        public long? CertifyingStaffId { get; set; }
    }
}

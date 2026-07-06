using AutoMapper;
using AircraftApptest.Approvals.Dto;
using AircraftApptest.Entities;

namespace AircraftApptest.Approvals
{
    public class ApprovalMapProfile : Profile
    {
        public ApprovalMapProfile()
        {
            CreateMap<ApprovalRecord, ApprovalRecordDto>();
            CreateMap<StatusChangeLog, StatusChangeLogDto>();
        }
    }
}

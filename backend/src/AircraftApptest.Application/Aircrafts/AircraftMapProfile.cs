using AutoMapper;
using AircraftApptest.Entities;
using AircraftApptest.Aircrafts.Dto;

namespace AircraftApptest.Aircrafts
{
    public class AircraftMapProfile : Profile
    {
        public AircraftMapProfile()
        {
            CreateMap<Aircraft, AircraftDto>();
            CreateMap<CreateAircraftDto, Aircraft>();
            CreateMap<AircraftDto, Aircraft>();
        }
    }
}

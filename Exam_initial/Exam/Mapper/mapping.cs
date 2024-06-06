using AutoMapper;
using Exam.Models;

namespace Exam.Mapper
{
    public class mapping: Profile
    {
        public mapping()
        {
            CreateMap<busDTO, Bus>().ReverseMap();
            CreateMap<seatDTO, Seat>().ReverseMap();
            CreateMap<BookingSeatDTO, Seat>().ReverseMap();
        }
    }
}

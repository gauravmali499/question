using AutoMapper;
using Exam.Models;
using Exam.Models.DTOs;

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

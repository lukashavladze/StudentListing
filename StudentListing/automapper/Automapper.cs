using AutoMapper;
using Microsoft.Build.Framework.Profiler;
using StudentListing.Dto;

namespace StudentListing.automapper
{
    public class Automapper : Profile
    {
        public Automapper()
        {
            CreateMap<Student, PostStudentDto>().ReverseMap();
            CreateMap<Student, BaseStudentDto>().ReverseMap();

        }
    }
}

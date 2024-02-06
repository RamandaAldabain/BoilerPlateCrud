using AutoMapper;
using StudentsCrud.Models;
using StudentsCrud.Students.Dto;

namespace StudentsCrud.Web.Host.Startup
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Student, StudentDto>().ReverseMap();
			CreateMap<Course, CourseDto>().ReverseMap();
		}
	}
}
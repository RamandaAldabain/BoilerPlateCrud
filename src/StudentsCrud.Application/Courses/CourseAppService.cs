using Abp.Domain.Services;
using AutoMapper;
using StudentsCrud.DomainServices;
using StudentsCrud.Models;
using StudentsCrud.Students;
using StudentsCrud.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrud.Courses
{
	public class CourseAppService : DomainService , ICourseAppService
	{
		private readonly ICourseManager _courseManager;
		private readonly Mapper _mapper;

		public CourseAppService(ICourseManager courseManager, Mapper mapper)
		{
			_courseManager = courseManager;
			_mapper = mapper;
		}

		public async Task<CourseDto> Create(CourseDto model)
		{
			var course = _mapper.Map<CourseDto, Course>(model);
			course = await _courseManager.Create(course);
			return _mapper.Map<Course, CourseDto>(course);
		}

		public void Delete(int id)
		{
			_courseManager.Delete(id);
		}

		public IEnumerable<CourseDto> GetAll()
		{
			var courses = _courseManager.GetAll().ToList();
			return _mapper.Map<List<Course>, List<CourseDto>>(courses);
		}

		public async Task<CourseDto> GetById(int id)
		{
			var course = await _courseManager.GetById(id);
			return _mapper.Map<Course, CourseDto>(course);
		}

		public async Task<CourseDto> Update(CourseDto model)
		{
			var course = _mapper.Map<CourseDto, Course>(model);
			var UpdatedCourse = await _courseManager.Update(course);
			return _mapper.Map<Course, CourseDto>(UpdatedCourse);
		}
	}

}

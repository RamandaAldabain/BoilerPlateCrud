using Abp.Application.Services;
using StudentsCrud.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCrud.Students
{
	public interface ICourseAppService : IApplicationService
	{
		IEnumerable<CourseDto> GetAll();
		Task<CourseDto> GetById(int id);
		Task<CourseDto> Create(CourseDto model);
		Task<CourseDto> Update(CourseDto model);
		void Delete(int id);


	}
}

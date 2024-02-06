using Abp.Application.Services;
using StudentsCrud.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCrud.Students
{
	public interface IStudentAppService : IApplicationService
	{
		IEnumerable<StudentDto> GetAll();
		Task<StudentDto> GetById(int id);
		Task<StudentDto> Create(StudentDto model);
		Task<StudentDto> Update(StudentDto model);
		void Delete(int id);


	}
}

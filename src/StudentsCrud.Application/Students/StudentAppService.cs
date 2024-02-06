using Abp.Application.Services;
using Abp.AutoMapper;
using AutoMapper;
using StudentsCrud.DomainServices;
using StudentsCrud.Models;
using StudentsCrud.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCrud.Students
{
	public class StudentAppService : IApplicationService, IStudentAppService
	{
		private readonly IStudentManager _studentManager;
		private readonly Mapper _mapper;

		public StudentAppService(IStudentManager studentManager, Mapper mapper)
		{
			_studentManager = studentManager;
			_mapper = mapper;
		}

		public async Task<StudentDto> Create(StudentDto model)
		{
			var student = _mapper.Map<StudentDto,Student>(model);
			student = await _studentManager.Create(student);
			 return  _mapper.Map<Student, StudentDto>(student);
		}

		public void Delete(int id)
		{
			_studentManager.Delete(id);
		}

		public IEnumerable<StudentDto> GetAll()
		{
			var students =_studentManager.GetAll().ToList();
			return _mapper.Map<List<Student>,List<StudentDto>>(students);
		}

		public async Task<StudentDto> GetById(int id)
		{
			var student =  await _studentManager.GetById(id);
			return  _mapper.Map<Student, StudentDto>(student);
		}

		public async Task<StudentDto> Update(StudentDto model)
		{
			var student = _mapper.Map<StudentDto, Student>(model);
			 var UpdatedStudent = await _studentManager.Update(student);
			return _mapper.Map<Student, StudentDto>(UpdatedStudent);
		}
	}
}

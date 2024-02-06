using Abp.Domain.Repositories;
using Abp.Domain.Services;
using StudentsCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCrud.DomainServices
{
	public class StudentManager : DomainService, IStudentManager
	{
		private readonly IRepository<Student> _studentRepository;
		public StudentManager(IRepository<Student> repository)
		{
			_studentRepository = repository;
		}

		public async Task<Student> Create(Student model)
		{
			return await _studentRepository.InsertAsync(model);
		}

		public async void Delete(int id)
		{
			var student = _studentRepository.FirstOrDefault(x => x.Id == id);
			if (student == null)
			{
				throw new Exception("student Not Found");
			}
			else
			{
				await _studentRepository.DeleteAsync(id);
			}
		}

		public IEnumerable<Student> GetAll()
		{
			return _studentRepository.GetAll();
		}

		public async Task<Student> GetById(int id)
		{
			return await _studentRepository.GetAsync(id);

		}

		public async Task<Student> Update(Student model)
		{
			var student = _studentRepository.FirstOrDefault(x => x.Id == model.Id);
			if (student == null)
			{
				throw new Exception("student Not Found");
			}
			else
			{
				return await _studentRepository.UpdateAsync(model);
			}
		}
	}
}

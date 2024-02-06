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
	public class CourseManager : DomainService, ICourseManager
	{
		private readonly IRepository<Course> _courseRepository;
		public CourseManager(IRepository<Course> repository)
		{
			_courseRepository = repository;
		}

		public async Task<Course> Create(Course model)
		{
			return await _courseRepository.InsertAsync(model);
		}

		public async void Delete(int id)
		{
			var course = _courseRepository.FirstOrDefault(x => x.Id == id);
			if (course == null)
			{
				throw new Exception("course Not Found");
			}
			else
			{
				await _courseRepository.DeleteAsync(id);
			}
		}

		public  IEnumerable<Course> GetAll()
		{
			return  _courseRepository.GetAll();
		}

		public async Task<Course> GetById(int id)
		{
			return await _courseRepository.GetAsync(id);

		}

		public async Task<Course> Update(Course model)
		{
			var course = _courseRepository.FirstOrDefault(x => x.Id == model.Id);
			if (course == null)
			{
				throw new Exception("course Not Found");
			}
			else
			{
				return await _courseRepository.UpdateAsync(model);
			}
		}
	}
}

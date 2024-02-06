using Abp.Domain.Services;
using StudentsCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCrud.DomainServices
{
	public interface ICourseManager : IDomainService
	{
		IEnumerable<Course> GetAll();
		Task<Course> GetById(int id);
		Task <Course> Create(Course model);
		Task<Course> Update(Course model);
		void Delete(int id);
	}
}

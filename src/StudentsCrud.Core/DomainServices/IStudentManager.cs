using Abp.Domain.Services;
using StudentsCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCrud.DomainServices
{
	public interface IStudentManager : IDomainService
	{
		IEnumerable<Student> GetAll();
		Task<Student> GetById(int id);
		Task <Student> Create(Student model);
		Task<Student> Update(Student model);
		void Delete(int id);
	}
}

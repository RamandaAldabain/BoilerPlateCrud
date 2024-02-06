using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCrud.Models
{
	public class Student : FullAuditedEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string AdvisorName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
	}
}

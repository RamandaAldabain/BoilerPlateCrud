using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCrud.Students.Dto
{
	public class CourseDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string TeacherName { get; set; }
		public int AvailableSpots { get; set; }
	}
}

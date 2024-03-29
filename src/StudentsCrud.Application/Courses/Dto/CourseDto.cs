﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCrud.Students.Dto
{
	public class CourseDto
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string TeacherName { get; set; }
		[Required]
		public int AvailableSpots { get; set; }
	}
}

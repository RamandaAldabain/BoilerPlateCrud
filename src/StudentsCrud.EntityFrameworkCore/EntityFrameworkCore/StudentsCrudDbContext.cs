using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using StudentsCrud.Authorization.Roles;
using StudentsCrud.Authorization.Users;
using StudentsCrud.MultiTenancy;
using StudentsCrud.Models;

namespace StudentsCrud.EntityFrameworkCore
{
    public class StudentsCrudDbContext : AbpZeroDbContext<Tenant, Role, User, StudentsCrudDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public StudentsCrudDbContext(DbContextOptions<StudentsCrudDbContext> options)
            : base(options)
        {
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Student Entity
            modelBuilder.Entity<Student>().Property(s=>s.FirstName).IsRequired();
            modelBuilder.Entity<Student>().Property(s=>s.LastName).IsRequired();
            modelBuilder.Entity<Student>().Property(s=>s.Email).IsRequired();
            modelBuilder.Entity<Student>().Property(s=>s.PhoneNumber).IsRequired();
            modelBuilder.Entity<Student>().Property(s=>s.AdvisorName).IsRequired();

			//Course
			modelBuilder.Entity<Course>().Property(s => s.Name).IsRequired();
			modelBuilder.Entity<Course>().Property(s => s.TeacherName).IsRequired();
			modelBuilder.Entity<Course>().Property(s => s.Description).IsRequired();
			modelBuilder.Entity<Course>().Property(s => s.AvailableSpots).IsRequired();

		}


		public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

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
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

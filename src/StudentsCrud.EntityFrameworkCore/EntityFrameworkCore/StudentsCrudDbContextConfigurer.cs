using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace StudentsCrud.EntityFrameworkCore
{
    public static class StudentsCrudDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<StudentsCrudDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<StudentsCrudDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

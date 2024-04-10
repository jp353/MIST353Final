using MIST353FinalAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace MIST353FinalAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { 
        }
        public DbSet<User> User { get; set; }
    }
}

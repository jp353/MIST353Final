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
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Subscription> Subcription { get; set; }
       // public DbSet<Rating> Rating { get; set; }
       // public DbSet<Climate_Event> Climate_Event { get; set; }
       // public DbSet<Region> Region { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EFRelationAPI.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Character> Characters => Set<Character>();

    }
}

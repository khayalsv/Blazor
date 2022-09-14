using Microsoft.EntityFrameworkCore;

namespace MudBlazorTest.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }


        public DbSet<Role> Roles => Set<Role>();
        public DbSet<About> Abouts => Set<About>();


    }

}

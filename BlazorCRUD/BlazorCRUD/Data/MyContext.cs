using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Data
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) :base(options) { }


        public DbSet<Game> Games => Set<Game>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "Half Life 2",
                    Developer = "Valve",
                    Release = new DateTime(2004, 11, 16)
                },
                new Game
                {
                    Id = 2,
                    Name = "Valorant",
                    Developer = "Riot Games",
                    Release = new DateTime(2020, 3, 25)
                });
        }
    }

}

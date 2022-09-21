using Microsoft.EntityFrameworkCore;

namespace StateApprove.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Stage> Stages => Set<Stage>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<BaseCompany> BaseCompanies => Set<BaseCompany>();
    }
}

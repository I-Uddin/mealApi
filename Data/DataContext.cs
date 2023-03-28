using Microsoft.EntityFrameworkCore;

namespace MowAPI.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Meal> Meals => Set<Meal>();

        public DbSet<User> Users => Set<User>();


    }
}

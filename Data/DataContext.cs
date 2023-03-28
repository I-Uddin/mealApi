using Microsoft.EntityFrameworkCore;
using MowAPI.Models;

namespace MowAPI.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Meal> Meals => Set<Meal>();



    }
}

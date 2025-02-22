using eticaret.Entities;
using Microsoft.EntityFrameworkCore;

namespace eticaret.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Product> Products => Set<Product>();
    }
}

using Microsoft.EntityFrameworkCore;
using THUCHANH.Models;

namespace THUCHANH.DbAccess
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) {
        }

        public DbSet<Product> Products { get; set; }
    }
}

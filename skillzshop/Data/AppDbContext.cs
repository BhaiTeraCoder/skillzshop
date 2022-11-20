using Microsoft.EntityFrameworkCore;
using skillzshop.Models;

namespace skillzshop.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Skills> Skills { get; set; }
        public DbSet<Category> Category { get; set; }

    }

}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Volunteia.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
         public DbSet<Action> Actions { get; set; }
        public DbSet<Action> User { get; set; }
    }
    }


       



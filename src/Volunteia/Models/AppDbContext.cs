using Microsoft.EntityFrameworkCore;

namespace Volunteia.Models
{
    public class AppDbContext : DbContext
    {
        // Construtor que recebe as opções do DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        // Propriedade que representa a tabela de ações
        public DbSet<UserAction> UserActions { get; set; }

        // Propriedade que representa a tabela de usuários
        public DbSet<User> Users { get; set; }

        // Override do método OnModelCreating se precisar de configurações adicionais

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}

using Microsoft.EntityFrameworkCore;
using ClientsControl;

namespace DbOfClients
{
    public class ApplicationContextOfClients : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Clients.db");
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UserControl;

namespace DbOfUser
{
    public class ApplicationContextOfUser : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContextOfUser() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var projectDir = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;
            var dbPath = Path.Combine(projectDir, "Databases", "Users.db");
            optionsBuilder
                .UseSqlite($"Data Source={dbPath}")
                .LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace CoreWebSite.Models
{
    public class ProjectContext : DbContext
    {
 public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        { }

           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./database.db");
        }

        public DbSet<Projects> Projects { get; set; }
    }
}
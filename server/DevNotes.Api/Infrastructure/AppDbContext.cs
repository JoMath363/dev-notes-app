using DevNotes.Api.Models;
using Microsoft.EntityFrameworkCore;



namespace DevNotes.Api.Infrastructure
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("WebApiDatabase"));
        }
        public DbSet<Note> Notes {  get; set; }
    }
}

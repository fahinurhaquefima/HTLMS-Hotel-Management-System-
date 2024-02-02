using Microsoft.EntityFrameworkCore;
using HTLMS.WebApp.Models;

namespace HTLMS.WebApp.DatabaseContest
{
    public class ApplicationDbContest(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContest).Assembly);
        }
        public DbSet<HTLMS.WebApp.Models.Hotel> Hotel { get; set; } = default!;
    }
}

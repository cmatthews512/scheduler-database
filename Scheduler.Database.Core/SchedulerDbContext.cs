using Microsoft.EntityFrameworkCore;
using Scheduler.Database.Core.Models;

namespace Scheduler.Database.Core
{
    public class SchedulerDbContext : DbContext
    {
        public SchedulerDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<League> Leagues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

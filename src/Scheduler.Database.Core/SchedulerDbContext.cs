using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Scheduler.Database.Core.Models;

namespace Scheduler.Database.Core
{
    public class SchedulerDbContext : DbContext
    {
        public SchedulerDbContext()
        {
        }
        public SchedulerDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<League> Leagues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultSchedulerDbConnection"));
            }
        }
    }
}

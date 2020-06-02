using Scheduler.Database.Core.Interfaces;
using Scheduler.Database.Core.Repositories;

namespace Scheduler.Database.Core
{
    public class UnitOfWork
    {
        private readonly SchedulerDbContext _context;

        public UnitOfWork(SchedulerDbContext context)
        {
            _context = context;
            Leagues = new LeagueRepository(_context);
        }

        public ILeagueRepository Leagues { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

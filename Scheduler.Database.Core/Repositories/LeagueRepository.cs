using Scheduler.Database.Core.Interfaces;
using Scheduler.Database.Core.Models;

namespace Scheduler.Database.Core.Repositories
{
    public class LeagueRepository : Repository<League>, ILeagueRepository
    {
        public LeagueRepository(SchedulerDbContext context) : base(context)
        {
        }
    }
}

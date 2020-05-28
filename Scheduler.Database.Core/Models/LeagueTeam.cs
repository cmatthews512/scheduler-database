using System;

namespace Scheduler.Database.Core.Models
{
    public class LeagueTeam
    {
        public int LeagueId { get; set; }

        public int TeamId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}

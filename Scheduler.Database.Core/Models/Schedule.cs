using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scheduler.Database.Core.Models
{
    [Table("season")]
    public class Schedule
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("season_home_team_id")]
        public int SeasonHomeTeamId { get; set; }
        
        [Column("season_away_team_id")]
        public int SeasonAwayTeamId { get; set; }

        public DateTime GameDateTime { get; set; }


    }
}

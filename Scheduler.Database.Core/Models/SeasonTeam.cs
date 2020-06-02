using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scheduler.Database.Core.Models
{
    [Table("season_team")]
    public class SeasonTeam
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("season_id")]
        public int SeasonId { get; set; }

        [Column("team_id")]
        public int TeamId { get; set; }
    }
}

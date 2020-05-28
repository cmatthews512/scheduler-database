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

        public int SeasonId { get; set; }

        public int TeamId { get; set; }
    }
}

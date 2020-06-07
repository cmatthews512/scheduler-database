using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scheduler.Database.Core.Models
{
    [Table("season")]
    public class Season
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("league_id")]
        public int LeagueId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
